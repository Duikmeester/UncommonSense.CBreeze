using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class BooleanProperty : Property
    {
        private System.Boolean value = false;

        internal BooleanProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value;
            }
        }

        public System.Boolean Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }

}
