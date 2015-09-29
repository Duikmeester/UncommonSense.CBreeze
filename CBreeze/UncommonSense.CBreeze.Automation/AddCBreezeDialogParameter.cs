﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeDialogParameter")]
    public class AddCBreezeDialogParameter : AddCBreezeParameter<DialogParameter>
    {
        protected override DialogParameter CreateParameter()
        {
            return Parameters.Add(new DialogParameter(Var, GetParameterID(), Name));
        }
    }
}
