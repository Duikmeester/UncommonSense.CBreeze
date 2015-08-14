using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class DateTimeTableField : TableField
    {
        private DateTimeTableFieldProperties properties = new DateTimeTableFieldProperties();

        internal DateTimeTableField(Int32 no, String name) : base(no, name)
        {
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.DateTime;
            }
        }

        public DateTimeTableFieldProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

    }
}
