using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class LinkFields : IEnumerable<LinkField>
    {
        private List<LinkField> innerList = new List<LinkField>();

        internal LinkFields()
        {
        }

        public int FindIndex(Predicate<LinkField> match)
        {
            return innerList.FindIndex(match);
        }

        public int FindIndex(int startIndex, Predicate<LinkField> match)
        {
            return innerList.FindIndex(startIndex, match);
        }

        public int FindIndex(int startIndex, int count,Predicate<LinkField> match)
        {
            return innerList.FindIndex(startIndex, count, match);
        }

        public int FindLastIndex(Predicate<LinkField> match)
        {
            return innerList.FindLastIndex(match);
        }

        public int FindLastIndex(int startIndex, Predicate<LinkField> match)
        {
            return innerList.FindLastIndex(startIndex, match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<LinkField> match)
        {
            return innerList.FindLastIndex(startIndex, count, match);
        }

        public LinkField Add(Int32 field, Int32 referenceField)
        {
            LinkField item = new LinkField(field, referenceField);
            innerList.Add(item);
            return item;
        }

        public LinkField Insert(int index, Int32 field, Int32 referenceField)
        {
            LinkField item = new LinkField(field, referenceField);
            innerList.Insert(index, item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<LinkField> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}
