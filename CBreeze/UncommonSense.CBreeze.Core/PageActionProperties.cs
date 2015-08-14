using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class PageActionProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty description = new StringProperty("Description");
        private NullableBooleanProperty ellipsis = new NullableBooleanProperty("Ellipsis");
        private StringProperty enabled = new StringProperty("Enabled");
        private StringProperty image = new StringProperty("Image");
        private NullableBooleanProperty inFooterBar = new NullableBooleanProperty("InFooterBar");
        private StringProperty name = new StringProperty("Name");
        private TriggerProperty onAction = new TriggerProperty("OnAction");
        private NullableBooleanProperty promoted = new NullableBooleanProperty("Promoted");
        private PromotedCategoryProperty promotedCategory = new PromotedCategoryProperty("PromotedCategory");
        private NullableBooleanProperty promotedIsBig = new NullableBooleanProperty("PromotedIsBig");
        private ObjectReferenceProperty runObject = new ObjectReferenceProperty("RunObject");
        private RunObjectLinkProperty runPageLink = new RunObjectLinkProperty("RunPageLink");
        private RunPageModeProperty runPageMode = new RunPageModeProperty("RunPageMode");
        private NullableBooleanProperty runPageOnRec = new NullableBooleanProperty("RunPageOnRec");
        private TableViewProperty runPageView = new TableViewProperty("RunPageView");
        private StringProperty shortCutKey = new StringProperty("ShortCutKey");
        private MultiLanguageProperty toolTipML = new MultiLanguageProperty("ToolTipML");
        private StringProperty visible = new StringProperty("Visible");

        internal PageActionProperties()
        {
            innerList.Add(name);
            innerList.Add(shortCutKey);
            innerList.Add(ellipsis);
            innerList.Add(captionML);
            innerList.Add(toolTipML);
            innerList.Add(description);
            innerList.Add(runObject);
            innerList.Add(runPageOnRec);
            innerList.Add(runPageView);
            innerList.Add(runPageLink);
            innerList.Add(promoted);
            innerList.Add(visible);
            innerList.Add(enabled);
            innerList.Add(inFooterBar);
            innerList.Add(promotedIsBig);
            innerList.Add(image);
            innerList.Add(promotedCategory);
            innerList.Add(runPageMode);
            innerList.Add(onAction);
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

      public System.Boolean? Ellipsis
        {
            get
            {
                return this.ellipsis.Value;
            }
            set
            {
                this.ellipsis.Value = value;
            }
        }

      public System.String Enabled
        {
            get
            {
                return this.enabled.Value;
            }
            set
            {
                this.enabled.Value = value;
            }
        }

      public System.String Image
        {
            get
            {
                return this.image.Value;
            }
            set
            {
                this.image.Value = value;
            }
        }

      public System.Boolean? InFooterBar
        {
            get
            {
                return this.inFooterBar.Value;
            }
            set
            {
                this.inFooterBar.Value = value;
            }
        }

      public System.String Name
        {
            get
            {
                return this.name.Value;
            }
            set
            {
                this.name.Value = value;
            }
        }

        public Trigger OnAction
        {
            get
            {
                return this.onAction.Value;
            }
        }

      public System.Boolean? Promoted
        {
            get
            {
                return this.promoted.Value;
            }
            set
            {
                this.promoted.Value = value;
            }
        }

        public PromotedCategory? PromotedCategory
        {
            get
            {
                return this.promotedCategory.Value;
            }
            set
            {
                this.promotedCategory.Value = value;
            }
        }

      public System.Boolean? PromotedIsBig
        {
            get
            {
                return this.promotedIsBig.Value;
            }
            set
            {
                this.promotedIsBig.Value = value;
            }
        }

        public ObjectReference RunObject
        {
            get
            {
                return this.runObject.Value;
            }
        }

        public RunObjectLink RunPageLink
        {
            get
            {
                return this.runPageLink.Value;
            }
        }

        public RunPageMode? RunPageMode
        {
            get
            {
                return this.runPageMode.Value;
            }
            set
            {
                this.runPageMode.Value = value;
            }
        }

      public System.Boolean? RunPageOnRec
        {
            get
            {
                return this.runPageOnRec.Value;
            }
            set
            {
                this.runPageOnRec.Value = value;
            }
        }

        public TableView RunPageView
        {
            get
            {
                return this.runPageView.Value;
            }
        }

      public System.String ShortCutKey
        {
            get
            {
                return this.shortCutKey.Value;
            }
            set
            {
                this.shortCutKey.Value = value;
            }
        }

        public MultiLanguageValue ToolTipML
        {
            get
            {
                return this.toolTipML.Value;
            }
        }

      public System.String Visible
        {
            get
            {
                return this.visible.Value;
            }
            set
            {
                this.visible.Value = value;
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
