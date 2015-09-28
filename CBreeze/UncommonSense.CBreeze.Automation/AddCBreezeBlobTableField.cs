﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.Utils;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeBlobTableField")]
    public class AddCBreezeBlobTableField : AddCBreezeTableField
    {
        [Parameter()]
        public bool? Compressed
        {
            get;
            set;
        }

        [Parameter()]
        public string Owner
        {
            get;
            set;
        }

        [Parameter()]
        public BlobSubType? SubType
        {
            get;
            set;
        }

        [Parameter()]
        public bool? Volatile
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            foreach (var table in Table)
            {
                var field = table.Fields.Add(new BlobTableField(GetNo(table), Name));

                field.Properties.Compressed = Compressed;
                field.Properties.Description = Description;
                field.Properties.Owner = Owner;
                field.Properties.SubType = SubType;
                field.Properties.Volatile = Volatile;

                if (AutoCaption)
                    field.AutoCaption();

                if (PassThru)
                    WriteObject(field);
            }
        }
    }
}
