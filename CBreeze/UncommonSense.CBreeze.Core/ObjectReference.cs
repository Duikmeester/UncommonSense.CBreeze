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
    public partial class ObjectReference
    {
        private Int32 id;
        private RunObjectType? type;

        internal ObjectReference()
        {
        }

        public Int32 ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public RunObjectType? Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

    }
}