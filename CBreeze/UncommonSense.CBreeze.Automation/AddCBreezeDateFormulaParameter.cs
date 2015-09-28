﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeDateFormulaParameter")]
    public class AddCBreezeDateFormulaParameter : AddCBreezeParameter
    {
        protected override void ProcessRecord()
        {
            foreach (var inputObject in InputObject)
            {
                var parameter = GetParameters(inputObject).Add(new DateFormulaParameter(Var, GetParameterID(inputObject), Name));

                parameter.Dimensions = Dimensions;

                if (PassThru)
                    WriteObject(parameter);
            }
        }
    }
}
