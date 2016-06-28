using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
        public class DateTimeVariable : Variable
    {
        public DateTimeVariable(int id, string name)
            : base(id, name)
        {
        }

        public override VariableType Type
        {
            get
            {
                return VariableType.DateTime;
            }
        }

        public string Dimensions
        {
            get;
            set;
        }
    }
}
