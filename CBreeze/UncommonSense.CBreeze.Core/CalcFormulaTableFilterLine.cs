using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class CalcFormulaTableFilterLine
    {
        private String fieldName;
        private Boolean onlyMaxLimit;
        private CalcFormulaTableFilterType? type;
        private String value;
        private Boolean valueIsFilter;

        internal CalcFormulaTableFilterLine(String fieldName, CalcFormulaTableFilterType type, String value)
        {
            this.fieldName = fieldName;
            this.type = type;
            this.value = value;
        }

        public String FieldName
        {
            get
            {
                return this.fieldName;
            }
        }

        public Boolean OnlyMaxLimit
        {
            get
            {
                return this.onlyMaxLimit;
            }
            set
            {
                this.onlyMaxLimit = value;
            }
        }

        public CalcFormulaTableFilterType? Type
        {
            get
            {
                return this.type;
            }
        }

        public String Value
        {
            get
            {
                return this.value;
            }
        }

        public Boolean ValueIsFilter
        {
            get
            {
                return this.valueIsFilter;
            }
            set
            {
                this.valueIsFilter = value;
            }
        }

    }
}
