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
    public partial class TransactionTypeVariable : Variable
    {
        private String dimensions;

        internal TransactionTypeVariable(Int32 id, String name) : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.TransactionType;
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

    }
}
