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
    public partial class RecordIDTableField : TableField
    {
        private RecordIDTableFieldProperties properties = new RecordIDTableFieldProperties();

        internal RecordIDTableField(Int32 no, String name) : base(no, name)
        {
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.RecordID;
            }
        }

        public RecordIDTableFieldProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

    }
}
