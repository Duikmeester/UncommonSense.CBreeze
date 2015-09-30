﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeOcxParameter")]
    public class AddCBreezeOcxParameter : AddCBreezeParameter<OcxParameter>
    {
        [Parameter(Mandatory = true)]
        public string SubType
        {
            get;
            set;
        }

        protected override OcxParameter CreateParameter(PSObject inputObject)
        {
            return GetParameters(inputObject).Add(new OcxParameter(Var, GetParameterID(inputObject), Name, SubType));
        }
    }
}
