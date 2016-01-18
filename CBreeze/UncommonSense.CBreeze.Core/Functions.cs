using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
        public class Functions : IntegerKeyedAndNamedContainer<Function>
    {
        internal Functions(Code code)
        {
            Code = code;
        }

        public Code Code
        {
            get;
            protected set;
        }

        protected override void InsertItem(int index, Function item)
        {
            base.InsertItem(index, item);
            item.Container = this;
        }

        protected override void RemoveItem(int index)
        {
            this[index].Container = null;
            base.RemoveItem(index);
        }

        public override void ValidateName(Function item)
        {
            TestNameNotNullOrEmpty(item);
            TestNameUnique(item);
        }
    }
}
