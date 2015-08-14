using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class QueryDataItemLink : IEnumerable<QueryDataItemLinkLine>
    {
        private List<QueryDataItemLinkLine> innerList = new List<QueryDataItemLinkLine>();

        internal QueryDataItemLink()
        {
        }

        public int FindIndex(Predicate<QueryDataItemLinkLine> match)
        {
            return innerList.FindIndex(match);
        }

        public int FindIndex(int startIndex, Predicate<QueryDataItemLinkLine> match)
        {
            return innerList.FindIndex(startIndex, match);
        }

        public int FindIndex(int startIndex, int count,Predicate<QueryDataItemLinkLine> match)
        {
            return innerList.FindIndex(startIndex, count, match);
        }

        public int FindLastIndex(Predicate<QueryDataItemLinkLine> match)
        {
            return innerList.FindLastIndex(match);
        }

        public int FindLastIndex(int startIndex, Predicate<QueryDataItemLinkLine> match)
        {
            return innerList.FindLastIndex(startIndex, match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<QueryDataItemLinkLine> match)
        {
            return innerList.FindLastIndex(startIndex, count, match);
        }

        public QueryDataItemLinkLine Add(String field, String referenceTable, String referenceField)
        {
            QueryDataItemLinkLine item = new QueryDataItemLinkLine(field, referenceTable, referenceField);
            innerList.Add(item);
            return item;
        }

        public QueryDataItemLinkLine Insert(int index, String field, String referenceTable, String referenceField)
        {
            QueryDataItemLinkLine item = new QueryDataItemLinkLine(field, referenceTable, referenceField);
            innerList.Insert(index, item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<QueryDataItemLinkLine> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}
