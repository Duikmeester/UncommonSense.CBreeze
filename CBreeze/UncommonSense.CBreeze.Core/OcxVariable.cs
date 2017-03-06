using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public class OcxVariable : Variable
    {
        public OcxVariable(string name, string subType) : this(0, name, subType)
        {
        }

        public OcxVariable(int id, string name, string subType)
            : base(id, name)
        {
            SubType = subType;
        }

        public string Dimensions
        {
            get;
            set;
        }

        public string SubType
        {
            get;
            protected set;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Ocx;
            }
        }
    }
}