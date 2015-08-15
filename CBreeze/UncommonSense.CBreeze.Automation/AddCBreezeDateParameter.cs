﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeDateParameter")]
    public class AddCBreezeDateParameter : AddCBreezeParameter
    {
        protected override System.Collections.IEnumerable AddedObjects
        {
            get
            {
                ID = AutoAssignID(ID);

                var dateParameter = Parameters.Add(new DateParameter(Var, ID, Name));
                dateParameter.Dimensions = Dimensions;
                yield return dateParameter;
            }
        }
    }
}
