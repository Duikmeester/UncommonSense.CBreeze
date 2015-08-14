using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class AutomationVariable : Variable
    {
        private String dimensions;
        private String subType;
        private Boolean? withEvents;

        internal AutomationVariable(Int32 id, String name, String subType) : base(id, name)
        {
            this.subType = subType;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Automation;
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

        public Boolean? WithEvents
        {
            get
            {
                return this.withEvents;
            }
            set
            {
                this.withEvents = value;
            }
        }

    }
}
