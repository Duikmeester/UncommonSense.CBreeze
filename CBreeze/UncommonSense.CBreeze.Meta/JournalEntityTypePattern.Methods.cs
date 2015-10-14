﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.Utils;

namespace UncommonSense.CBreeze.Meta
{
    public partial class JournalEntityTypePattern
    {
        protected override void VerifyRequirements()
        {
            if (MasterEntityTypeTable == null)
                throw new ArgumentNullException("MasterEntityTypeTable");
        }

        protected override void CreateObjects()
        {
            TemplateTable = Application.Tables.Add(new Table(Range.GetNextTableID(Application), TemplateName).AutoCaption());
            BatchTable = Application.Tables.Add(new Table(Range.GetNextTableID(Application), BatchName).AutoCaption());
            LineTable = Application.Tables.Add(new Table(Range.GetNextTableID(Application), LineName).AutoCaption());

            TemplatesPage = Application.Pages.Add(new Page(Range.GetNextPageID(Application), TemplatePluralName).AutoCaption());
            TemplateListPage = Application.Pages.Add(new Page(Range.GetNextPageID(Application), string.Format("{0} List", TemplateName)).AutoCaption());
            BatchesPage = Application.Pages.Add(new Page(Range.GetNextPageID(Application), BatchPluralName).AutoCaption());
            JournalPage = Application.Pages.Add(new Page(Range.GetNextPageID(Application), Name).AutoCaption());
            RecurringJournalPage = CanBeRecurring ? Application.Pages.Add(new Page(Range.GetNextPageID(Application), string.Format("Recurring {0}", Name)).AutoCaption()) : null;

            JournalMgtCodeunit = Application.Codeunits.Add(new Codeunit(Range.GetNextCodeunitID(Application), string.Format("{0} Mgt.", Name)));
        }

        protected override void AfterCreateObjects()
        {
            TemplatesPage.Properties.SourceTable = TemplateTable.ID;
            TemplatesPage.Properties.PageType = PageType.List;

            TemplateListPage.Properties.SourceTable = TemplateTable.ID;
            TemplateListPage.Properties.PageType = PageType.List;
            TemplateListPage.Properties.Editable = false;
            TemplateListPage.Properties.RefreshOnActivate = true;

            BatchesPage.Properties.SourceTable = BatchTable.ID;
            BatchesPage.Properties.PageType = PageType.List;

            JournalPage.Properties.SourceTable = LineTable.ID;
            JournalPage.Properties.PageType = PageType.Worksheet;
            JournalPage.Properties.SaveValues = true;
            JournalPage.Properties.DelayedInsert = true;
            JournalPage.Properties.AutoSplitKey = true;

            if (CanBeRecurring)
            {
                RecurringJournalPage.Properties.SourceTable = LineTable.ID;
                RecurringJournalPage.Properties.PageType = PageType.Worksheet;
                RecurringJournalPage.Properties.SaveValues = true;
                RecurringJournalPage.Properties.DelayedInsert = true;
                RecurringJournalPage.Properties.AutoSplitKey = true;
            }

            JournalMgtCodeunit.Properties.Permissions.Set(TemplateTable.ID, false, true, true, true);
            JournalMgtCodeunit.Properties.Permissions.Set(BatchTable.ID, false, true, true, true);
        }

        protected override void CreateFields()
        {
            TemplateTableNameField = TemplateTable.Fields.Add(new CodeTableField(Range.GetNextPrimaryKeyFieldNo(TemplateTable), "Name", 10).AutoCaption());
            TemplateTableDescriptionField = TemplateTable.Fields.Add(new TextTableField(Range.GetNextTableFieldNo(TemplateTable), "Description", 80).AutoCaption());
            TemplateTableTestReportIDField = HasTestReportID ? TemplateTable.Fields.Add(new IntegerTableField(Range.GetNextTableFieldNo(TemplateTable), "Test Report ID").AutoCaption()) : null;
            TemplateTableTestReportCaptionField = HasTestReportID ? TemplateTable.Fields.Add(new TextTableField(Range.GetNextTableFieldNo(TemplateTable), "Test Report Caption", 250).AutoCaption()) : null;
            TemplateTablePageIDField = TemplateTable.Fields.Add(new IntegerTableField(Range.GetNextTableFieldNo(TemplateTable), "Page ID").AutoCaption());
            TemplateTablePageCaptionField = TemplateTable.Fields.Add(new TextTableField(Range.GetNextTableFieldNo(TemplateTable), "Page Caption", 250).AutoCaption());
            TemplateTablePostingReportIDField = HasPostingReportID ? TemplateTable.Fields.Add(new IntegerTableField(Range.GetNextTableFieldNo(TemplateTable), "Posting Report ID").AutoCaption()) : null;
            TemplateTablePostingReportCaptionField = HasPostingReportID ? TemplateTable.Fields.Add(new TextTableField(Range.GetNextTableFieldNo(TemplateTable), "Posting Report Caption", 250).AutoCaption()) : null;
            TemplateTableForcePostingReportField = HasPostingReportID ? TemplateTable.Fields.Add(new BooleanTableField(Range.GetNextTableFieldNo(TemplateTable), "Force Posting Report").AutoCaption()) : null;
            TemplateTableSourceCodeField = HasSourceCode ? TemplateTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(TemplateTable), "Source Code", 10).AutoCaption()) : null;
            TemplateTableReasonCodeField = HasReasonCode ? TemplateTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(TemplateTable), "Reason Code", 10).AutoCaption()) : null;
            TemplateTableRecurringField = CanBeRecurring ? TemplateTable.Fields.Add(new BooleanTableField(Range.GetNextTableFieldNo(TemplateTable), "Recurring").AutoCaption()) : null;
            TemplateTableNoSeriesField = TemplateTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(TemplateTable), "No. Series", 10).AutoCaption());
            TemplateTablePostingNoSeriesField = TemplateTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(TemplateTable), "Posting No. Series", 10).AutoCaption());

            BatchTableJournalTemplateNameField = BatchTable.Fields.Add(new CodeTableField(Range.GetNextPrimaryKeyFieldNo(BatchTable), "Journal Template Name", 10).AutoCaption());
            BatchTableNameField = BatchTable.Fields.Add(new CodeTableField(Range.GetNextPrimaryKeyFieldNo(BatchTable), "Name", 10).AutoCaption());
            BatchTableDescriptionField = BatchTable.Fields.Add(new TextTableField(Range.GetNextTableFieldNo(BatchTable), "Description", 50).AutoCaption());
            BatchTableReasonCodeField = HasReasonCode ? BatchTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(BatchTable), "Reason Code", 10).AutoCaption()) : null;
            BatchTableNoSeriesField = BatchTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(BatchTable), "No. Series", 10).AutoCaption());
            BatchTablePostingNoSeriesField = BatchTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(BatchTable), "Posting No. Series").AutoCaption());
            BatchTableRecurringField = CanBeRecurring ? BatchTable.Fields.Add(new BooleanTableField(Range.GetNextTableFieldNo(BatchTable), "Recurring").AutoCaption()) : null;

            LineTableJournalTemplateNameField = LineTable.Fields.Add(new CodeTableField(Range.GetNextPrimaryKeyFieldNo(LineTable), "Journal Template Name", 10).AutoCaption());
            LineTableJournalBatchNameField = LineTable.Fields.Add(new CodeTableField(Range.GetNextPrimaryKeyFieldNo(LineTable), "Journal Batch Name", 10).AutoCaption());
            LineTableLineNoField = LineTable.Fields.Add(new IntegerTableField(Range.GetNextPrimaryKeyFieldNo(LineTable), "Line No.").AutoCaption());
            LineTablePostingDateField = LineTable.Fields.Add(new DateTableField(Range.GetNextTableFieldNo(LineTable), "Posting Date").AutoCaption());
            LineTableMasterEntityTypeField = LineTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(LineTable), string.Format("{0} No.", MasterEntityTypeTable.Name), 20).AutoCaption());
            LineTableDescriptionField = LineTable.Fields.Add(new TextTableField(Range.GetNextTableFieldNo(LineTable), "Description", 50).AutoCaption());
            LineTableSourceCodeField = HasSourceCode ? LineTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(LineTable), "Source Code", 10).AutoCaption()) : null;
            LineTableReasonCodeField = HasReasonCode ? LineTable.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(LineTable), "Reason Code", 10).AutoCaption()) : null;
            LineTableDocumentDateField = LineTable.Fields.Add(new DateTableField(Range.GetNextTableFieldNo(LineTable), "Document Date").AutoCaption());
        }

        protected override void AfterCreateFields()
        {
            TemplateTableNameField.Properties.NotBlank = true;

            BatchTableJournalTemplateNameField.Properties.NotBlank = true;
            BatchTableNameField.Properties.NotBlank = true;

            if (HasTestReportID)
            {
                TemplateTableTestReportIDField.Properties.TableRelation.Set("Object", "ID").TableFilter.Add("Type", TableFilterType.Const, "Report");

                TemplateTableTestReportCaptionField.Properties.FieldClass = FieldClass.FlowField;
                TemplateTableTestReportCaptionField.Properties.Editable = false;
                TemplateTableTestReportCaptionField.Properties.CalcFormula.Set(
                    CalcFormulaMethod.Lookup, 
                    "AllObjWithCaption", 
                    "Object Caption", 
                    false,
                    new CalcFormulaTableFilterLine("Object Type", TableFilterType.Const, "Report"),
                    new CalcFormulaTableFilterLine("Object ID", TableFilterType.Field, TemplateTableTestReportIDField.Name));
            }

            JournalPage.Properties.DataCaptionFields.Add(LineTableJournalBatchNameField.Name);

            if (CanBeRecurring)
            {
                RecurringJournalPage.Properties.DataCaptionFields.Add(LineTableJournalBatchNameField.Name);
            }
        }

        protected override void CreateKeys()
        {
            var templateTableKey = TemplateTable.Keys.Add(new TableKey(TemplateTableNameField.Name));
            templateTableKey.Properties.Clustered = true;

            var batchTableKey = BatchTable.Keys.Add(new TableKey(BatchTableJournalTemplateNameField.Name, BatchTableNameField.Name));
            batchTableKey.Properties.Clustered = true;

            var lineTableKey = LineTable.Keys.Add(new TableKey(LineTableJournalTemplateNameField.Name, LineTableJournalBatchNameField.Name, LineTableLineNoField.Name));
            lineTableKey.Properties.Clustered = true;
        }

        protected override void CreateGlobals()
        {
            JournalMgtCodeunitOpenFromBatchVariable = JournalMgtCodeunit.Code.Variables.Add(new BooleanVariable(Range.GetNextVariableID(JournalMgtCodeunit), "OpenFromBatch"));
        }

        protected override void CreateFunctions()
        {
            BatchTableSetupNewBatchFunction = BatchTable.Code.Functions.Add(new Function(Range.GetNextFunctionID(BatchTable), "SetupNewBatch"));

            JournalMgtCodeunitTemplateSelectionFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "TemplateSelection"));
            JournalMgtCodeunitTemplateSelectionFromBatchFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "TemplateSelectionFromBatch"));
            JournalMgtCodeunitOpenJnlFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "OpenJnl"));
            JournalMgtCodeunitOpenJnlBatchFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "OpenJnlBatch"));
            JournalMgtCodeunitCheckTemplateNameFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "CheckTemplateName"));
            JournalMgtCodeunitCheckNameFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "CheckName"));
            JournalMgtCodeunitSetNameFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "SetName"));
            JournalMgtCodeunitLookupNameFunction = JournalMgtCodeunit.Code.Functions.Add(new Function(Range.GetNextFunctionID(JournalMgtCodeunit), "LookupName"));
        }
    }
}
