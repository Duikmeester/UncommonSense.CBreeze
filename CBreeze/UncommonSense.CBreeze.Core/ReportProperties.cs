using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class ReportProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty description = new StringProperty("Description");
        private NullableBooleanProperty enableExternalAssemblies = new NullableBooleanProperty("EnableExternalAssemblies");
        private NullableBooleanProperty enableExternalImages = new NullableBooleanProperty("EnableExternalImages");
        private NullableBooleanProperty enableHyperlinks = new NullableBooleanProperty("EnableHyperlinks");
        private TriggerProperty onInitReport = new TriggerProperty("OnInitReport");
        private TriggerProperty onPostReport = new TriggerProperty("OnPostReport");
        private TriggerProperty onPreReport = new TriggerProperty("OnPreReport");
        private PaperSourceProperty paperSourceDefaultPage = new PaperSourceProperty("PaperSourceDefaultPage");
        private PaperSourceProperty paperSourceFirstPage = new PaperSourceProperty("PaperSourceFirstPage");
        private PaperSourceProperty paperSourceLastPage = new PaperSourceProperty("PaperSourceLastPage");
        private PermissionsProperty permissions = new PermissionsProperty("Permissions");
        private NullableBooleanProperty processingOnly = new NullableBooleanProperty("ProcessingOnly");
        private NullableBooleanProperty showPrintStatus = new NullableBooleanProperty("ShowPrintStatus");
        private TransactionTypeProperty transactionType = new TransactionTypeProperty("TransactionType");
        private NullableBooleanProperty useRequestPage = new NullableBooleanProperty("UseRequestPage");
        private NullableBooleanProperty useSystemPrinter = new NullableBooleanProperty("UseSystemPrinter");

        internal ReportProperties()
        {
            innerList.Add(permissions);
            innerList.Add(transactionType);
            innerList.Add(captionML);
            innerList.Add(description);
            innerList.Add(showPrintStatus);
            innerList.Add(useSystemPrinter);
            innerList.Add(processingOnly);
            innerList.Add(enableExternalImages);
            innerList.Add(enableHyperlinks);
            innerList.Add(enableExternalAssemblies);
            innerList.Add(onInitReport);
            innerList.Add(onPreReport);
            innerList.Add(onPostReport);
            innerList.Add(paperSourceDefaultPage);
            innerList.Add(paperSourceFirstPage);
            innerList.Add(paperSourceLastPage);
            innerList.Add(useRequestPage);
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

      public System.Boolean? EnableExternalAssemblies
        {
            get
            {
                return this.enableExternalAssemblies.Value;
            }
            set
            {
                this.enableExternalAssemblies.Value = value;
            }
        }

      public System.Boolean? EnableExternalImages
        {
            get
            {
                return this.enableExternalImages.Value;
            }
            set
            {
                this.enableExternalImages.Value = value;
            }
        }

      public System.Boolean? EnableHyperlinks
        {
            get
            {
                return this.enableHyperlinks.Value;
            }
            set
            {
                this.enableHyperlinks.Value = value;
            }
        }

        public Trigger OnInitReport
        {
            get
            {
                return this.onInitReport.Value;
            }
        }

        public Trigger OnPostReport
        {
            get
            {
                return this.onPostReport.Value;
            }
        }

        public Trigger OnPreReport
        {
            get
            {
                return this.onPreReport.Value;
            }
        }

        public PaperSource? PaperSourceDefaultPage
        {
            get
            {
                return this.paperSourceDefaultPage.Value;
            }
            set
            {
                this.paperSourceDefaultPage.Value = value;
            }
        }

        public PaperSource? PaperSourceFirstPage
        {
            get
            {
                return this.paperSourceFirstPage.Value;
            }
            set
            {
                this.paperSourceFirstPage.Value = value;
            }
        }

        public PaperSource? PaperSourceLastPage
        {
            get
            {
                return this.paperSourceLastPage.Value;
            }
            set
            {
                this.paperSourceLastPage.Value = value;
            }
        }

        public Permissions Permissions
        {
            get
            {
                return this.permissions.Value;
            }
        }

      public System.Boolean? ProcessingOnly
        {
            get
            {
                return this.processingOnly.Value;
            }
            set
            {
                this.processingOnly.Value = value;
            }
        }

      public System.Boolean? ShowPrintStatus
        {
            get
            {
                return this.showPrintStatus.Value;
            }
            set
            {
                this.showPrintStatus.Value = value;
            }
        }

        public TransactionType? TransactionType
        {
            get
            {
                return this.transactionType.Value;
            }
            set
            {
                this.transactionType.Value = value;
            }
        }

      public System.Boolean? UseRequestPage
        {
            get
            {
                return this.useRequestPage.Value;
            }
            set
            {
                this.useRequestPage.Value = value;
            }
        }

      public System.Boolean? UseSystemPrinter
        {
            get
            {
                return this.useSystemPrinter.Value;
            }
            set
            {
                this.useSystemPrinter.Value = value;
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
