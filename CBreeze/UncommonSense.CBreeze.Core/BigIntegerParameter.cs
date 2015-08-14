using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class BigIntegerParameter : Parameter
    {
        private String dimensions;

        internal BigIntegerParameter(Boolean var, Int32 id, String name) : base(var, id, name)
        {
        }

        public override ParameterType Type
        {
            get
            {
                return ParameterType.BigInteger;
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
