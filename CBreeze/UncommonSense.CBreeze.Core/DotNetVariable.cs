using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class DotNetVariable : Variable
    {
        private String dimensions;
        private Boolean? runOnClient;
        private String subType;
        private Boolean? withEvents;

        internal DotNetVariable(Int32 id, String name, String subType) : base(id, name)
        {
            this.subType = subType;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.DotNet;
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

        public Boolean? RunOnClient
        {
            get
            {
                return this.runOnClient;
            }
            set
            {
                this.runOnClient = value;
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
