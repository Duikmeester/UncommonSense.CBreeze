using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class GuidVariable : Variable
    {
        public GuidVariable(int id, string name)
            : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Guid;
            }
        }

        public string Dimensions
        {
            get;
            set;
        }
    }
}
