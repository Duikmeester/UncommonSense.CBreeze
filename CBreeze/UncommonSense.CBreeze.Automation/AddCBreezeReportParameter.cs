﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeReportParameter")]
    public class AddCBreezeReportParameter : AddCBreezeParameter<ReportParameter>
    {
        [Parameter(Mandatory = true)]
        [ValidateRange(1, int.MaxValue)]
        public int SubType
        {
            get;
            set;
        }

        protected override ReportParameter CreateParameter(PSObject inputObject)
        {
            return GetParameters(inputObject).Add(new ReportParameter(Var, GetParameterID(inputObject), Name, SubType));
        }
    }
}
