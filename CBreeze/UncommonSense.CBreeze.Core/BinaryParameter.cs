using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class BinaryParameter : Parameter
    {
        private Int32 dataLength;
        private String dimensions;

        internal BinaryParameter(Boolean var, Int32 id, String name, Int32 dataLength = 100) : base(var, id, name)
        {
            this.dataLength = dataLength;
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.Binary;
            }
        }

        public Int32 DataLength
        {
            get
            {
                return this.dataLength;
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
