using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class CalcFormulaTableFilter : IEnumerable<CalcFormulaTableFilterLine>
    {
        private List<CalcFormulaTableFilterLine> innerList = new List<CalcFormulaTableFilterLine>();

        internal CalcFormulaTableFilter()
        {
        }

        public int FindIndex(Predicate<CalcFormulaTableFilterLine> match)
        {
            return innerList.FindIndex(match);
        }

        public int FindIndex(int startIndex, Predicate<CalcFormulaTableFilterLine> match)
        {
            return innerList.FindIndex(startIndex, match);
        }

        public int FindIndex(int startIndex, int count,Predicate<CalcFormulaTableFilterLine> match)
        {
            return innerList.FindIndex(startIndex, count, match);
        }

        public int FindLastIndex(Predicate<CalcFormulaTableFilterLine> match)
        {
            return innerList.FindLastIndex(match);
        }

        public int FindLastIndex(int startIndex, Predicate<CalcFormulaTableFilterLine> match)
        {
            return innerList.FindLastIndex(startIndex, match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<CalcFormulaTableFilterLine> match)
        {
            return innerList.FindLastIndex(startIndex, count, match);
        }

        public CalcFormulaTableFilterLine Add(String fieldName, CalcFormulaTableFilterType type, String value)
        {
            CalcFormulaTableFilterLine item = new CalcFormulaTableFilterLine(fieldName, type, value);
            innerList.Add(item);
            return item;
        }

        public CalcFormulaTableFilterLine Insert(int index, String fieldName, CalcFormulaTableFilterType type, String value)
        {
            CalcFormulaTableFilterLine item = new CalcFormulaTableFilterLine(fieldName, type, value);
            innerList.Insert(index, item);
            return item;
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public IEnumerator<CalcFormulaTableFilterLine> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
    }
}
