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
    public partial class PartPageControl : PageControl
    {
        private PartPageControlProperties properties = new PartPageControlProperties();

        public PartPageControl(Int32 id, Int32? indentationLevel) : base(id, indentationLevel)
        {
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
            get
            {
                return this.properties;
            }
        }


        public override string GetName()
        {
            return Properties.Name;
        }
    }
}
