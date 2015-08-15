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
    public class SIFTLevelComponents : IEnumerable<SIFTLevelComponent>
    {
        private List<SIFTLevelComponent> innerList = new List<SIFTLevelComponent>();

        internal SIFTLevelComponents()
        {
        }

        public SIFTLevelComponent Add(String fieldName, String aspect)
        {
            SIFTLevelComponent item = new SIFTLevelComponent(fieldName, aspect);
            innerList.Add(item);
            return item;
        }

        public SIFTLevelComponent Insert(int index, String fieldName, String aspect)
        {
            SIFTLevelComponent item = new SIFTLevelComponent(fieldName, aspect);
            innerList.Insert(index, item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<SIFTLevelComponent> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}
