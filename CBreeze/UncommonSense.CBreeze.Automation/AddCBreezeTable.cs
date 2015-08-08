﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeTable")]
    public class AddCBreezeTable : AddCBreezeObject
    {
        [Parameter()]
        public string[] DataCaptionFields
        {
            get;
            set;
        }

        [Parameter()]
        public bool? DataPerCompany
        {
            get;
            set;
        }

        [Parameter()]
        public int? DrillDownPageID
        {
            get;
            set;
        }

        [Parameter()]
        public int? LookupPageID
        {
            get;
            set;
        }

        protected override System.Collections.IEnumerable AddedObjects
        {
            get
            {
                var table = Application.Tables.Add(ID, Name);

                table.ObjectProperties.DateTime = DateTime;
                table.ObjectProperties.Modified = Modified;
                table.ObjectProperties.VersionList = VersionList;

                table.Properties.DataCaptionFields.AddRange(DataCaptionFields ?? new string[] { });
                table.Properties.DataPerCompany = DataPerCompany;
                table.Properties.DrillDownPageID = DrillDownPageID;
                table.Properties.LookupPageID = LookupPageID;

                table.AutoCaptionIf(AutoCaption);

                yield return table;
            }
        }
    }
}
