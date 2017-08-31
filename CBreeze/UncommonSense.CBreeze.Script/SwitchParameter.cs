﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.Script
{
    public class SwitchParameter : ParameterBase
    {
        public SwitchParameter(string name, bool value)
            : base(name)
        {
            Value = value;
        }

        public override bool HasValue => Value;
        public bool Value { get; set; }

        public override string ToString(int indentation) => $"{Indentation(indentation)}-{Name}";
    }
}