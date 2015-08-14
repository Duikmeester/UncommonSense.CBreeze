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
