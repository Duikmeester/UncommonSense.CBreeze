// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class PageVariable : Variable
    {
        private String dimensions;
        private Int32 subType;

        internal PageVariable(Int32 id, String name, Int32 subType) : base(id, name)
        {
            this.subType = subType;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Page;
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
