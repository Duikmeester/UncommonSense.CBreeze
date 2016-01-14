using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class PartPageControl : PageControl
    {
        public PartPageControl(int id, int? indentationLevel)
            : base(id, indentationLevel)
        {
            Properties = new PartPageControlProperties();
        }

        public override PageControlType Type
        {
            get
            {
                return PageControlType.Part;
            }
        }

        public PartPageControlProperties Properties
        {
            get;
            protected set;
        }

        public override string GetName()
        {
            return Properties.Name;
        }

        public override Properties AllProperties
        {
            get
            {
                return Properties;
            }
        }
    }
}
