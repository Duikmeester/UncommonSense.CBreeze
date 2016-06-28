using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class TransactionTypeVariable : Variable
    {
        public TransactionTypeVariable(int id, string name)
            : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.TransactionType;
            }
        }

        public string Dimensions
        {
            get;
            set;
        }
    }
}
