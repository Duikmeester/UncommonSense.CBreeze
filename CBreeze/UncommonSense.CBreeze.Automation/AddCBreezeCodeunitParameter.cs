﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeCodeunitParameter")]
    public class AddCBreezeCodeunitParameter : AddCBreezeParameter
    {
        [Parameter(Mandatory =true)]
        [ValidateRange(1, int.MaxValue)]
        public int SubType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            foreach (var inputObject in InputObject)
            {
                var parameter = GetParameters(inputObject).Add(new CodeunitParameter(Var, GetParameterID(inputObject), Name, SubType));

                parameter.Dimensions = Dimensions;

                if (PassThru)
                    WriteObject(parameter);
            }
        }
    }
}
