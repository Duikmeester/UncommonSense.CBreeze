using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class DateFormulaVariable : Variable
    {
        public DateFormulaVariable(int id, string name)
            : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.DateFormula;
            }
        }

        public string Dimensions
        {
            get;
            set;
        }
    }
}
