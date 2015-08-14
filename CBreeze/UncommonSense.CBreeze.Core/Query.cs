using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class Query : Object
    {
        private Code code = new Code();
        private QueryElements elements = new QueryElements();
        private QueryProperties properties = new QueryProperties();

        internal Query(Int32 id, String name) : base(id, name)
        {
        }

        public override ObjectType Type
        {
            get
            {
                return ObjectType.Query;
            }
        }

        public Code Code
        {
            get
            {
                return this.code;
            }
        }

        public QueryElements Elements
        {
            get
            {
                return this.elements;
            }
        }

        public QueryProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

    }
}
