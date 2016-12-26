﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    public abstract class NewCBreezeObject : Cmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        [ValidateRange(0, int.MaxValue)]
        public int ID
        {
            get;
            set;
        }

        [Parameter(Mandatory = true, Position = 1)]
        [ValidateLength(1, 30)]
        public string Name
        {
            get;
            set;
        }

        [Parameter()]
        public SwitchParameter AutoCaption
        {
            get;
            set;
        }

        public DateTime? DateTime
        {
            get;
            set;
        }

        public SwitchParameter Modified
        {
            get;
            set;
        }

        public string VersionList
        {
            get;
            set;
        }

        [Parameter(Position=2)]
        public ScriptBlock SubObjects
        {
            get; set;
        }

        protected void SetObjectProperties(Core.Object @object)
        {
            @object.ObjectProperties.DateTime = DateTime;
            @object.ObjectProperties.Modified = Modified;
            @object.ObjectProperties.VersionList = VersionList;
        }
    }
}
