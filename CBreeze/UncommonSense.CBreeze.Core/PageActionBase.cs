using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public abstract partial class PageActionBase
    {
        private Int32 id;
        private Int32? indentationLevel;

        internal PageActionBase(Int32 id, Int32? indentationLevel)
        {
            this.id = id;
            this.indentationLevel = indentationLevel;
        }

        public abstract PageActionBaseType Type
        {
            get;
        }

        public Int32 ID
        {
            get
            {
                return this.id;
            }
        }

        public Int32? IndentationLevel
        {
            get
            {
                return this.indentationLevel;
            }
        }

    }
}
