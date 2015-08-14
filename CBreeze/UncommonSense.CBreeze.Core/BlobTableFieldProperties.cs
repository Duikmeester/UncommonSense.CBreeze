using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class BlobTableFieldProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private NullableBooleanProperty compressed = new NullableBooleanProperty("Compressed");
        private StringProperty description = new StringProperty("Description");
        private TriggerProperty onLookup = new TriggerProperty("OnLookup");
        private TriggerProperty onValidate = new TriggerProperty("OnValidate");
        private StringProperty owner = new StringProperty("Owner");
        private BlobSubTypeProperty subType = new BlobSubTypeProperty("SubType");
        private NullableBooleanProperty @volatile = new NullableBooleanProperty("Volatile");

        internal BlobTableFieldProperties()
        {
            innerList.Add(onValidate);
            innerList.Add(onLookup);
            innerList.Add(compressed);
            innerList.Add(@volatile);
            innerList.Add(captionML);
            innerList.Add(description);
            innerList.Add(owner);
            innerList.Add(subType);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

        public MultiLanguageValue CaptionML
        {
            get
            {
                return this.captionML.Value;
            }
        }

      public System.Boolean? Compressed
        {
            get
            {
                return this.compressed.Value;
            }
            set
            {
                this.compressed.Value = value;
            }
        }

      public System.String Description
        {
            get
            {
                return this.description.Value;
            }
            set
            {
                this.description.Value = value;
            }
        }

        public Trigger OnLookup
        {
            get
            {
                return this.onLookup.Value;
            }
        }

        public Trigger OnValidate
        {
            get
            {
                return this.onValidate.Value;
            }
        }

      public System.String Owner
        {
            get
            {
                return this.owner.Value;
            }
            set
            {
                this.owner.Value = value;
            }
        }

        public BlobSubType? SubType
        {
            get
            {
                return this.subType.Value;
            }
            set
            {
                this.subType.Value = value;
            }
        }

      public System.Boolean? Volatile
        {
            get
            {
                return this.@volatile.Value;
            }
            set
            {
                this.@volatile.Value = value;
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
