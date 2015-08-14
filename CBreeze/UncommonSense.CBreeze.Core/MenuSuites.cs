using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class MenuSuites : IEnumerable<MenuSuite>
    {
        private Dictionary<Int32,MenuSuite> innerList = new Dictionary<Int32,MenuSuite>();

        internal MenuSuites()
        {
        }

        public MenuSuite Add(Int32 id, String name)
        {
            MenuSuite item = new MenuSuite(id, name);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<MenuSuite> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
