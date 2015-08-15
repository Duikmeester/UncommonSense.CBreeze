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
    public class TableProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private FieldListProperty dataCaptionFields = new FieldListProperty("DataCaptionFields");
        private NullableBooleanProperty dataPerCompany = new NullableBooleanProperty("DataPerCompany");
        private StringProperty description = new StringProperty("Description");
        private PageReferenceProperty drillDownPageID = new PageReferenceProperty("DrillDownPageID");
        private NullableBooleanProperty linkedInTransaction = new NullableBooleanProperty("LinkedInTransaction");
        private NullableBooleanProperty linkedObject = new NullableBooleanProperty("LinkedObject");
        private PageReferenceProperty lookupPageID = new PageReferenceProperty("LookupPageID");
        private TriggerProperty onDelete = new TriggerProperty("OnDelete");
        private TriggerProperty onInsert = new TriggerProperty("OnInsert");
        private TriggerProperty onModify = new TriggerProperty("OnModify");
        private TriggerProperty onRename = new TriggerProperty("OnRename");
        private NullableBooleanProperty pasteIsValid = new NullableBooleanProperty("PasteIsValid");
        private PermissionsProperty permissions = new PermissionsProperty("Permissions");

        internal TableProperties()
        {
            innerList.Add(dataPerCompany);
            innerList.Add(permissions);
            innerList.Add(dataCaptionFields);
            innerList.Add(onInsert);
            innerList.Add(onModify);
            innerList.Add(onDelete);
            innerList.Add(onRename);
            innerList.Add(captionML);
            innerList.Add(description);
            innerList.Add(pasteIsValid);
            innerList.Add(lookupPageID);
            innerList.Add(drillDownPageID);
            innerList.Add(linkedInTransaction);
            innerList.Add(linkedObject);
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

        public FieldList DataCaptionFields
        {
            get
            {
                return this.dataCaptionFields.Value;
            }
        }

      public System.Boolean? DataPerCompany
        {
            get
            {
                return this.dataPerCompany.Value;
            }
            set
            {
                this.dataPerCompany.Value = value;
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

      public System.Int32? DrillDownPageID
        {
            get
            {
                return this.drillDownPageID.Value;
            }
            set
            {
                this.drillDownPageID.Value = value;
            }
        }

      public System.Boolean? LinkedInTransaction
        {
            get
            {
                return this.linkedInTransaction.Value;
            }
            set
            {
                this.linkedInTransaction.Value = value;
            }
        }

      public System.Boolean? LinkedObject
        {
            get
            {
                return this.linkedObject.Value;
            }
            set
            {
                this.linkedObject.Value = value;
            }
        }

      public System.Int32? LookupPageID
        {
            get
            {
                return this.lookupPageID.Value;
            }
            set
            {
                this.lookupPageID.Value = value;
            }
        }

        public Trigger OnDelete
        {
            get
            {
                return this.onDelete.Value;
            }
        }

        public Trigger OnInsert
        {
            get
            {
                return this.onInsert.Value;
            }
        }

        public Trigger OnModify
        {
            get
            {
                return this.onModify.Value;
            }
        }

        public Trigger OnRename
        {
            get
            {
                return this.onRename.Value;
            }
        }

      public System.Boolean? PasteIsValid
        {
            get
            {
                return this.pasteIsValid.Value;
            }
            set
            {
                this.pasteIsValid.Value = value;
            }
        }

        public Permissions Permissions
        {
            get
            {
                return this.permissions.Value;
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
