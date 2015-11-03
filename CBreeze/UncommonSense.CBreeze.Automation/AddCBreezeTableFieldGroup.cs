﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeTableFieldGroup")]
    public class AddCBreezeTableFieldGroup : Cmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public Table Table
        {
            get;
            set;
        }

        [Parameter()]
        [ValidateRange(1, int.MaxValue)]
        public int ID
        {
            get;
            set;
        }

        [Parameter()]
        [ValidateNotNullOrEmpty()]
        public string Name
        {
            get;
            set;
        }

        [Parameter(Mandatory = true)]
        public string[] FieldNames
        {
            get;
            set;
        }

        [Parameter()]
        public string Caption
        {
            get;
            set;
        }

        [Parameter()]
        public SwitchParameter PassThru
        {
            get;
            set;
        }

        public AddCBreezeTableFieldGroup()
        {
            ID = 1;
            Name = "DropDown";
        }

        protected override void ProcessRecord()
        {
            var tableFieldGroup = Table.FieldGroups.Add(new TableFieldGroup(ID, Name));
            tableFieldGroup.Properties.CaptionML.Set("ENU", Caption);
            tableFieldGroup.Fields.AddRange(FieldNames);

            if (PassThru)
                WriteObject(tableFieldGroup);
        }
    }
}
