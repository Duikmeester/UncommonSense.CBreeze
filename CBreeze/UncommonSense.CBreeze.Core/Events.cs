// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class Events : IEnumerable<Event>
    {
        private List<Event> innerList = new List<Event>();

        internal Events()
        {
        }

        public Event Add(Int32 sourceID, String sourceName, Int32 id, String name)
        {
            Event item = new Event(sourceID, sourceName, id, name);
            innerList.Add(item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<Event> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}
