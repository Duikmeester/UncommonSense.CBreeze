﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.New, "CBreezeQuery")]
    [OutputType(typeof(Query))]
    public class NewCBreezeQuery : NewCBreezeObject
    {
        [Parameter()]
        public string Description
        {
            get; set;
        }

        [Parameter()]
        public ReadState? ReadState
        {
            get; set;
        }

        [Parameter()]
        [ValidateRange(0, int.MaxValue)]
        public int? TopNoOfRows
        {
            get; set;
        }

        protected Query CreateQuery()
        {
            var query = new Query(ID, Name);
            SetObjectProperties(query);

            query.Properties.Description = Description;
            query.Properties.ReadState = ReadState;
            query.Properties.TopNumberOfRows = TopNoOfRows;

            if (AutoCaption)
                query.AutoCaption();

            if (SubObjects != null)
            {
                var subObjects = SubObjects.Invoke().Select(o => o.BaseObject);
                query.Properties.OrderBy.AddRange(subObjects.OfType<QueryOrderByLine>());
                query.Elements.AddRange(subObjects.OfType<QueryElement>());
                query.Code.Functions.AddRange(subObjects.OfType<Function>());
                query.Code.Variables.AddRange(subObjects.OfType<Variable>());
                query.Code.Events.AddRange(subObjects.OfType<Event>());
            }

            return query;
        }

        protected override void ProcessRecord()
        {
            WriteObject(CreateQuery());
        }
    }
}