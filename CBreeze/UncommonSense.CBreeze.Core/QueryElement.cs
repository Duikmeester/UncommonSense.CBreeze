using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public abstract partial class QueryElement
    {
        private Int32 id;
        private String name;
        private Int32? indentationLevel;

        internal QueryElement(Int32 id, String name, Int32? indentationLevel)
        {
            this.id = id;
            this.indentationLevel = indentationLevel;
            this.name = name;
        }

        public abstract QueryElementType Type
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

        public String Name
        {
            get
            {
                return this.name;
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
