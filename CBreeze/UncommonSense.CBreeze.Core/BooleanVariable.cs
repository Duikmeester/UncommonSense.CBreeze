using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class BooleanVariable : Variable
    {
        private String dimensions;
        private Boolean? includeInDataset;

        internal BooleanVariable(Int32 id, String name) : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Boolean;
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

        public Boolean? IncludeInDataset
        {
            get
            {
                return this.includeInDataset;
            }
            set
            {
                this.includeInDataset = value;
            }
        }

    }
}
