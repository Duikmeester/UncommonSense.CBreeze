using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class TableRelationTableFilterLine
    {
        public TableRelationTableFilterLine(string fieldName, TableFilterType type, string value)
        {
            FieldName = fieldName;
            Type = type;
            Value = value;
        }

        public string FieldName
        {
            get;
            protected set;
        }

        public TableFilterType Type
        {
            get;
            protected set;
        }

        public string Value
        {
            get;
            protected set;
        }
    }
}
