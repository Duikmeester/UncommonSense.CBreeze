// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

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

        public BinaryParameter(Boolean var, Int32 id, String name, Int32 dataLength = 100) : base(var, id, name)
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

    }
}