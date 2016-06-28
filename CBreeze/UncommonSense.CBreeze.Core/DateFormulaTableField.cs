using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class DateFormulaTableField : TableField
    {
        public DateFormulaTableField(int no, string name)
            : base(no, name)
        {
            Properties = new DateFormulaTableFieldProperties();
        }

        public override TableFieldType Type
        {
            get
            {
                return TableFieldType.DateFormula;
            }
        }

        public DateFormulaTableFieldProperties Properties
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
