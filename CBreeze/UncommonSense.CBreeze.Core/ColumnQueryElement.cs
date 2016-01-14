using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class ColumnQueryElement : QueryElement
    {
        public ColumnQueryElement(int id, string name, int? indentationLevel)
            : base(id, name, indentationLevel)
        {
            Properties = new ColumnQueryElementProperties();
        }

        public override QueryElementType Type
        {
            get
            {
                return QueryElementType.Column;
            }
        }

        public ColumnQueryElementProperties Properties
        {
            get;
            protected set;
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
