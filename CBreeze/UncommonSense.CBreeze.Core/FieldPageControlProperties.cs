using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class FieldPageControlProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private NullableBooleanProperty assistEdit = new NullableBooleanProperty("AssistEdit");
        private StringProperty autoFormatExpr = new StringProperty("AutoFormatExpr");
        private AutoFormatTypeProperty autoFormatType = new AutoFormatTypeProperty("AutoFormatType");
        private BlankNumbersProperty blankNumbers = new BlankNumbersProperty("BlankNumbers");
        private NullableBooleanProperty blankZero = new NullableBooleanProperty("BlankZero");
        private StringProperty captionClass = new StringProperty("CaptionClass");
        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty charAllowed = new StringProperty("CharAllowed");
        private NullableBooleanProperty closingDates = new NullableBooleanProperty("ClosingDates");
        private NullableIntegerProperty columnSpan = new NullableIntegerProperty("ColumnSpan");
        private StringProperty controlAddIn = new StringProperty("ControlAddIn");
        private NullableBooleanProperty dateFormula = new NullableBooleanProperty("DateFormula");
        private DecimalPlacesProperty decimalPlaces = new DecimalPlacesProperty("DecimalPlaces");
        private StringProperty description = new StringProperty("Description");
        private NullableBooleanProperty drillDown = new NullableBooleanProperty("DrillDown");
        private StringProperty drillDownPageID = new StringProperty("DrillDownPageID");
        private StringProperty editable = new StringProperty("Editable");
        private StringProperty enabled = new StringProperty("Enabled");
        private ExtendedDataTypeProperty extendedDatatype = new ExtendedDataTypeProperty("ExtendedDatatype");
        private StringProperty hideValue = new StringProperty("HideValue");
        private ImportanceProperty importance = new ImportanceProperty("Importance");
        private NullableBooleanProperty lookup = new NullableBooleanProperty("Lookup");
        private StringProperty lookupPageID = new StringProperty("LookupPageID");
        private ObjectProperty maxValue = new ObjectProperty("MaxValue");
        private ObjectProperty minValue = new ObjectProperty("MinValue");
        private NullableBooleanProperty multiLine = new NullableBooleanProperty("MultiLine");
        private StringProperty name = new StringProperty("Name");
        private NullableBooleanProperty notBlank = new NullableBooleanProperty("NotBlank");
        private NullableBooleanProperty numeric = new NullableBooleanProperty("Numeric");
        private TriggerProperty onAssistEdit = new TriggerProperty("OnAssistEdit");
        private TriggerProperty onControlAddIn = new TriggerProperty("OnControlAddIn");
        private TriggerProperty onDrillDown = new TriggerProperty("OnDrillDown");
        private TriggerProperty onLookup = new TriggerProperty("OnLookup");
        private TriggerProperty onValidate = new TriggerProperty("OnValidate");
        private MultiLanguageProperty optionCaptionML = new MultiLanguageProperty("OptionCaptionML");
        private StringProperty quickEntry = new StringProperty("QuickEntry");
        private NullableIntegerProperty rowSpan = new NullableIntegerProperty("RowSpan");
        private NullableBooleanProperty showCaption = new NullableBooleanProperty("ShowCaption");
        private StringProperty sourceExpr = new StringProperty("SourceExpr");
        private StyleProperty style = new StyleProperty("Style");
        private StringProperty styleExpr = new StringProperty("StyleExpr");
        private TableRelationLinesProperty tableRelation = new TableRelationLinesProperty("TableRelation");
        private NullableBooleanProperty title = new NullableBooleanProperty("Title");
        private MultiLanguageProperty toolTipML = new MultiLanguageProperty("ToolTipML");
        private SemiColonSeparatedStringProperty valuesAllowed = new SemiColonSeparatedStringProperty("ValuesAllowed");
        private StringProperty visible = new StringProperty("Visible");
        private NullableIntegerProperty width = new NullableIntegerProperty("Width");

        internal FieldPageControlProperties()
        {
            innerList.Add(name);
            innerList.Add(extendedDatatype);
            innerList.Add(width);
            innerList.Add(lookup);
            innerList.Add(drillDown);
            innerList.Add(assistEdit);
            innerList.Add(captionML);
            innerList.Add(toolTipML);
            innerList.Add(optionCaptionML);
            innerList.Add(decimalPlaces);
            innerList.Add(notBlank);
            innerList.Add(numeric);
            innerList.Add(charAllowed);
            innerList.Add(dateFormula);
            innerList.Add(closingDates);
            innerList.Add(blankNumbers);
            innerList.Add(blankZero);
            innerList.Add(description);
            innerList.Add(sourceExpr);
            innerList.Add(autoFormatType);
            innerList.Add(autoFormatExpr);
            innerList.Add(captionClass);
            innerList.Add(title);
            innerList.Add(minValue);
            innerList.Add(maxValue);
            innerList.Add(valuesAllowed);
            innerList.Add(tableRelation);
            innerList.Add(importance);
            innerList.Add(visible);
            innerList.Add(enabled);
            innerList.Add(editable);
            innerList.Add(lookupPageID);
            innerList.Add(drillDownPageID);
            innerList.Add(multiLine);
            innerList.Add(hideValue);
            innerList.Add(style);
            innerList.Add(styleExpr);
            innerList.Add(controlAddIn);
            innerList.Add(rowSpan);
            innerList.Add(columnSpan);
            innerList.Add(onValidate);
            innerList.Add(onLookup);
            innerList.Add(onDrillDown);
            innerList.Add(onAssistEdit);
            innerList.Add(onControlAddIn);
            innerList.Add(showCaption);
            innerList.Add(quickEntry);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

      public System.Boolean? AssistEdit
        {
            get
            {
                return this.assistEdit.Value;
            }
            set
            {
                this.assistEdit.Value = value;
            }
        }

      public System.String AutoFormatExpr
        {
            get
            {
                return this.autoFormatExpr.Value;
            }
            set
            {
                this.autoFormatExpr.Value = value;
            }
        }

        public AutoFormatType? AutoFormatType
        {
            get
            {
                return this.autoFormatType.Value;
            }
            set
            {
                this.autoFormatType.Value = value;
            }
        }

        public BlankNumbers? BlankNumbers
        {
            get
            {
                return this.blankNumbers.Value;
            }
            set
            {
                this.blankNumbers.Value = value;
            }
        }

      public System.Boolean? BlankZero
        {
            get
            {
                return this.blankZero.Value;
            }
            set
            {
                this.blankZero.Value = value;
            }
        }

      public System.String CaptionClass
        {
            get
            {
                return this.captionClass.Value;
            }
            set
            {
                this.captionClass.Value = value;
            }
        }

        public MultiLanguageValue CaptionML
        {
            get
            {
                return this.captionML.Value;
            }
        }

      public System.String CharAllowed
        {
            get
            {
                return this.charAllowed.Value;
            }
            set
            {
                this.charAllowed.Value = value;
            }
        }

      public System.Boolean? ClosingDates
        {
            get
            {
                return this.closingDates.Value;
            }
            set
            {
                this.closingDates.Value = value;
            }
        }

      public System.Int32? ColumnSpan
        {
            get
            {
                return this.columnSpan.Value;
            }
            set
            {
                this.columnSpan.Value = value;
            }
        }

      public System.String ControlAddIn
        {
            get
            {
                return this.controlAddIn.Value;
            }
            set
            {
                this.controlAddIn.Value = value;
            }
        }

      public System.Boolean? DateFormula
        {
            get
            {
                return this.dateFormula.Value;
            }
            set
            {
                this.dateFormula.Value = value;
            }
        }

        public DecimalPlaces DecimalPlaces
        {
            get
            {
                return this.decimalPlaces.Value;
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

      public System.Boolean? DrillDown
        {
            get
            {
                return this.drillDown.Value;
            }
            set
            {
                this.drillDown.Value = value;
            }
        }

      public System.String DrillDownPageID
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

      public System.String Editable
        {
            get
            {
                return this.editable.Value;
            }
            set
            {
                this.editable.Value = value;
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

        public ExtendedDataType? ExtendedDatatype
        {
            get
            {
                return this.extendedDatatype.Value;
            }
            set
            {
                this.extendedDatatype.Value = value;
            }
        }

      public System.String HideValue
        {
            get
            {
                return this.hideValue.Value;
            }
            set
            {
                this.hideValue.Value = value;
            }
        }

        public Importance? Importance
        {
            get
            {
                return this.importance.Value;
            }
            set
            {
                this.importance.Value = value;
            }
        }

      public System.Boolean? Lookup
        {
            get
            {
                return this.lookup.Value;
            }
            set
            {
                this.lookup.Value = value;
            }
        }

      public System.String LookupPageID
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

      public System.Object MaxValue
        {
            get
            {
                return this.maxValue.Value;
            }
            set
            {
                this.maxValue.Value = value;
            }
        }

      public System.Object MinValue
        {
            get
            {
                return this.minValue.Value;
            }
            set
            {
                this.minValue.Value = value;
            }
        }

      public System.Boolean? MultiLine
        {
            get
            {
                return this.multiLine.Value;
            }
            set
            {
                this.multiLine.Value = value;
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

      public System.Boolean? NotBlank
        {
            get
            {
                return this.notBlank.Value;
            }
            set
            {
                this.notBlank.Value = value;
            }
        }

      public System.Boolean? Numeric
        {
            get
            {
                return this.numeric.Value;
            }
            set
            {
                this.numeric.Value = value;
            }
        }

        public Trigger OnAssistEdit
        {
            get
            {
                return this.onAssistEdit.Value;
            }
        }

        public Trigger OnControlAddIn
        {
            get
            {
                return this.onControlAddIn.Value;
            }
        }

        public Trigger OnDrillDown
        {
            get
            {
                return this.onDrillDown.Value;
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

        public MultiLanguageValue OptionCaptionML
        {
            get
            {
                return this.optionCaptionML.Value;
            }
        }

      public System.String QuickEntry
        {
            get
            {
                return this.quickEntry.Value;
            }
            set
            {
                this.quickEntry.Value = value;
            }
        }

      public System.Int32? RowSpan
        {
            get
            {
                return this.rowSpan.Value;
            }
            set
            {
                this.rowSpan.Value = value;
            }
        }

      public System.Boolean? ShowCaption
        {
            get
            {
                return this.showCaption.Value;
            }
            set
            {
                this.showCaption.Value = value;
            }
        }

      public System.String SourceExpr
        {
            get
            {
                return this.sourceExpr.Value;
            }
            set
            {
                this.sourceExpr.Value = value;
            }
        }

        public Style? Style
        {
            get
            {
                return this.style.Value;
            }
            set
            {
                this.style.Value = value;
            }
        }

      public System.String StyleExpr
        {
            get
            {
                return this.styleExpr.Value;
            }
            set
            {
                this.styleExpr.Value = value;
            }
        }

        public TableRelationLines TableRelation
        {
            get
            {
                return this.tableRelation.Value;
            }
        }

      public System.Boolean? Title
        {
            get
            {
                return this.title.Value;
            }
            set
            {
                this.title.Value = value;
            }
        }

        public MultiLanguageValue ToolTipML
        {
            get
            {
                return this.toolTipML.Value;
            }
        }

      public System.String ValuesAllowed
        {
            get
            {
                return this.valuesAllowed.Value;
            }
            set
            {
                this.valuesAllowed.Value = value;
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
