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
    public class TableRelationLinesProperty : Property
    {
        private TableRelationLines value = new TableRelationLines();

        internal TableRelationLinesProperty(string name) : base(name)
        {
        }

        public override bool HasValue
        {
            get
            {
                return Value.Any();
            }
        }

        public TableRelationLines Value
        {
            get
            {
                return this.value;
            }
        }
    }

}
