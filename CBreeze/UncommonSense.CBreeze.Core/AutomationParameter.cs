using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class AutomationParameter : Parameter
    {
        private String dimensions;
        private String subType;

        internal AutomationParameter(Boolean var, Int32 id, String name, String subType) : base(var, id, name)
        {
            this.subType = subType;
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.Automation;
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

        public String SubType
        {
            get
            {
                return this.subType;
            }
        }

    }
}
