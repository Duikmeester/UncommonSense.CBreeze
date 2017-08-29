﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.Script2
{
    public class SimpleParameter : ParameterBase
    {
        public SimpleParameter(string name, bool isPositional, object value)
            : base(name)
        {
            IsPositional = isPositional;
            Value = value;
        }

        public override bool HasValue => Value != null;
        public bool IsPositional { get; protected set; }
        public override bool OnCmdletLine => IsPositional;

        public Object Value { get; protected set; }

        public string ValueAsString => Value is string ? $"'{Value}'" : Value.ToString();

        public override void ScriptTo(IndentedTextWriter writer, bool useAliases, bool usePositionalParameters)
        {
            writer.Write(IsPositional && usePositionalParameters ? "" : $"-{Name} ");

            switch (OnCmdletLine)
            {
                case true:
                    writer.Write($"{ValueAsString} ");
                    break;

                case false:
                    writer.WriteLine(ValueAsString);
                    break;
            }
        }
    }
}