using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class ReportElements : IEnumerable<ReportElement>
    {
        private Dictionary<Int32,ReportElement> innerList = new Dictionary<Int32,ReportElement>();

        internal ReportElements()
        {
        }

        public ColumnReportElement AddColumnReportElement(Int32 id, Int32? indentationLevel)
        {
            ColumnReportElement item = new ColumnReportElement(id, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public DataItemReportElement AddDataItemReportElement(Int32 id, Int32? indentationLevel)
        {
            DataItemReportElement item = new DataItemReportElement(id, indentationLevel);
            innerList.Add(id, item);
            return item;
        }

        public bool Remove(Int32 id)
        {
            return innerList.Remove(id);
        }

        public IEnumerator<ReportElement> GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.Values.GetEnumerator();
        }
    }
}
