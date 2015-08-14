using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class QueryElements : IEnumerable<QueryElement>
    {
        private Dictionary<Int32,QueryElement> innerList = new Dictionary<Int32,QueryElement>();

        internal QueryElements()
        {
        }

        public ColumnQueryElement AddColumnQueryElement(Int32 id, String name, Int32? indentationLevel)
        {
            ColumnQueryElement item = new ColumnQueryElement(id, name, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public DataItemQueryElement AddDataItemQueryElement(Int32 id, String name, Int32? indentationLevel)
        {
            DataItemQueryElement item = new DataItemQueryElement(id, name, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public FilterQueryElement AddFilterQueryElement(Int32 id, String name, Int32? indentationLevel)
        {
            FilterQueryElement item = new FilterQueryElement(id, name, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<QueryElement> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
