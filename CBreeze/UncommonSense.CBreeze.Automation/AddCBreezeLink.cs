﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeLink")]
    public class AddCBreezeLink : Cmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public PSObject InputObject
        {
            get;
            set;
        }

        [Parameter(Mandatory = true)]
        public string FieldName
        {
            get;
            set;
        }

        [Parameter(Mandatory = true)]
        public TableFilterType Type
        {
            get;
            set;
        }

        [Parameter(Mandatory = true)]
        [AllowEmptyString()]
        public string Value
        {
            get;
            set;
        }

        [Parameter()]
        public bool? OnlyMaxLimit
        {
            get;
            set;
        }

        [Parameter()]
        public bool? ValueIsFilter
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            var runObjectLinkLine = RunObjectLink.Add(FieldName, Type, Value);
            runObjectLinkLine.OnlyMaxLimit = OnlyMaxLimit;
            runObjectLinkLine.ValueIsFilter = ValueIsFilter;
        }

        protected RunObjectLink RunObjectLink
        {
            get
            {
                if (InputObject.BaseObject is RunObjectLink)
                    return (InputObject.BaseObject as RunObjectLink);
                if (InputObject.BaseObject is PartPageControl)
                    return (InputObject.BaseObject as PartPageControl).Properties.SubPageLink;
                if (InputObject.BaseObject is PartPageControlProperties)
                    return (InputObject.BaseObject as PartPageControlProperties).SubPageLink;

                throw new ApplicationException("Cannot add links to this object.");
            }
        }
    }
}
