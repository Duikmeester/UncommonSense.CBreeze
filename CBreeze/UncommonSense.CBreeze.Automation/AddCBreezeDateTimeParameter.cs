﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeDateTimeParameter")]
    public class AddCBreezeDateTimeParameter : AddCBreezeParameter
    {
        protected override System.Collections.IEnumerable AddedObjects
        {
            get
            {
                ID = AutoAssignID(ID);

                var dateTimeParameter = Parameters.Add(new DateTimeParameter(Var, ID, Name));
                dateTimeParameter.Dimensions = Dimensions;
                yield return dateTimeParameter;
            }
        }
    }
}
