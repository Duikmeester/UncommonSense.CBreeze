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
        protected const string WithID = "WithID";
        protected const string WithoutID = "WithoutID";

        [Parameter()]
        public SwitchParameter AutoCaption
        {
            get;
            set;
        }

        [Parameter()]
        public DateTime? DateTime
        {
            get;
            set;
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = WithID)]
        [ValidateRange(0, int.MaxValue)]
        public int ID
        {
            get;
            set;
        }

        [Parameter()]
        public SwitchParameter Modified
        {
            get;
            set;
        }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = WithID)]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = WithoutID)]
        [ValidateLength(1, 30)]
        public string Name
        {
            get;
            set;
        }

        [Parameter(Position = 2, ParameterSetName = WithID)]
        [Parameter(Position = 1, ParameterSetName = WithoutID)]
        public ScriptBlock SubObjects
        {
            get; set;
        }

        [Parameter()]
        public string VersionList
        {
            get;
            set;
        }

        protected void SetObjectProperties(Core.Object @object)
        {
            @object.ObjectProperties.DateTime = DateTime;
            @object.ObjectProperties.Modified = Modified;
            @object.ObjectProperties.VersionList = VersionList;
        }
    }
}