using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class XmlPortTextAttributeProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

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
            innerList.Add(occurrence);
            innerList.Add(onAfterAssignVariable);
            innerList.Add(onBeforePassVariable);
            innerList.Add(width);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

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

      public System.String VariableName
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

      public System.Int32? Width
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

        public IEnumerator<Property> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

    }
}
