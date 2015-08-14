using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class RecordVariable : Variable
    {
        private String dimensions;
        private RecordSecurityFiltering? securityFiltering;
        private Int32 subType;
        private Boolean? temporary;

        internal RecordVariable(Int32 id, String name, Int32 subType) : base(id, name)
        {
            this.subType = subType;
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.Record;
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

        public RecordSecurityFiltering? SecurityFiltering
        {
            get
            {
                return this.securityFiltering;
            }
            set
            {
                this.securityFiltering = value;
            }
        }

        public Int32 SubType
        {
            get
            {
                return this.subType;
            }
        }

        public Boolean? Temporary
        {
            get
            {
                return this.temporary;
            }
            set
            {
                this.temporary = value;
            }
        }

    }
}
