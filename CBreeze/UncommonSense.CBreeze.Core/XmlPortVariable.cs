using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class XmlPortVariable : Variable
    {
        private String dimensions;
        private Int32 subType;

        internal XmlPortVariable(Int32 id, String name, Int32 subType) : base(id, name)
        {
            this.subType = subType;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.XmlPort;
            }
        }

        public String Dimensions
        {
            get
            {
                return this.dimensions;
            }
            set
            {
                this.dimensions = value;
            }
        }

        public Int32 SubType
        {
            get
            {
                return this.subType;
            }
        }

    }
}
