using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class ActionListProperty : Property
    {
        private ActionList value = new ActionList();

        internal ActionListProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value.Any();
            }
        }

        public ActionList Value
        {
            get
            {
                return this.value;
            }
        }
    }

}
