using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class CodeunitParameter : Parameter
    {
        public CodeunitParameter(bool var, int id, string name, int subType)
            : base(var, id, name)
        {
            SubType = subType;
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.Codeunit;
            }
        }

        public int SubType
        {
            get;
            protected set;
        }
    }
}
