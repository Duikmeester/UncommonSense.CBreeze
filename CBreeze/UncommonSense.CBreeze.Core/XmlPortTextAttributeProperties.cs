using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class XmlPortTextAttributeProperties : Properties
    {
#if NAV2016
        private TableFieldTypeProperty dataType = new TableFieldTypeProperty("DataType");
#endif
        private OccurrenceProperty occurrence = new OccurrenceProperty("Occurrence");
        private ScopedTriggerProperty onAfterAssignVariable = new ScopedTriggerProperty("OnAfterAssignVariable");
        private ScopedTriggerProperty onBeforePassVariable = new ScopedTriggerProperty("OnBeforePassVariable");
        private TextTypeProperty textType = new TextTypeProperty("TextType");
        private StringProperty variableName = new StringProperty("VariableName");
        private NullableIntegerProperty width = new NullableIntegerProperty("Width");

        internal XmlPortTextAttributeProperties()
        {
            innerList.Add(variableName);
            innerList.Add(textType);
#if NAV2016
            innerList.Add(dataType);
#endif
            innerList.Add(occurrence);
            innerList.Add(onAfterAssignVariable);
            innerList.Add(onBeforePassVariable);
            innerList.Add(width);
        }

#if NAV2016
        public TableFieldType? DataType
        {
            get
            {
                return this.dataType.Value;
            }
            set
            {
                this.dataType.Value = value;
            }
        }
#endif

        public Occurrence? Occurrence
        {
            get
            {
                return this.occurrence.Value;
            }
            set
            {
                this.occurrence.Value = value;
            }
        }

        public Trigger OnAfterAssignVariable
        {
            get
            {
                return this.onAfterAssignVariable.Value;
            }
        }

        public Trigger OnBeforePassVariable
        {
            get
            {
                return this.onBeforePassVariable.Value;
            }
        }

        public TextType? TextType
        {
            get
            {
                return this.textType.Value;
            }
            set
            {
                this.textType.Value = value;
            }
        }

      public string VariableName
        {
            get
            {
                return this.variableName.Value;
            }
            set
            {
                this.variableName.Value = value;
            }
        }

      public int? Width
        {
            get
            {
                return this.width.Value;
            }
            set
            {
                this.width.Value = value;
            }
        }
    }
}
