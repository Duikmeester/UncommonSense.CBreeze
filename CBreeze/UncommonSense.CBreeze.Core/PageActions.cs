using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class PageActions : IEnumerable<PageActionBase>
    {
        private Dictionary<Int32,PageActionBase> innerList = new Dictionary<Int32,PageActionBase>();

        internal PageActions()
        {
        }

        public PageAction AddPageAction(Int32 id, Int32? indentationLevel)
        {
            PageAction item = new PageAction(id, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public PageActionContainer AddPageActionContainer(Int32 id, Int32? indentationLevel)
        {
            PageActionContainer item = new PageActionContainer(id, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public PageActionGroup AddPageActionGroup(Int32 id, Int32? indentationLevel)
        {
            PageActionGroup item = new PageActionGroup(id, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public PageActionSeparator AddPageActionSeparator(Int32 id, Int32? indentationLevel)
        {
            PageActionSeparator item = new PageActionSeparator(id, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<PageActionBase> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
