﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.Patterns;
using UncommonSense.CBreeze.Utils;

namespace UncommonSense.CBreeze.Meta
{
    public class LedgerEntityTypePattern : EntityTypePattern
    {
        private string pluralName;

        public LedgerEntityTypePattern(Application application, IEnumerable<int> range, string name)
            : base(application, range, name)
        {
        }

        protected override void VerifyRequirements()
        {
            base.VerifyRequirements();
        }

        protected override void CreateObjects()
        {
            Table = Application.Tables.Add(new Table(Range.GetNextTableID(Application), Name).AutoCaption());
            Page = Application.Pages.Add(new Page(Range.GetNextPageID(Application), PluralName).AutoCaption());

            Page.Properties.PageType = PageType.List;
        }

        protected override void LinkObjects()
        {
            Table.Properties.DrillDownPageID = Page.ID;
            Table.Properties.LookupPageID = Page.ID;
            Page.Properties.SourceTable = Table.ID;
        }

        protected override void CreateFields()
        {
            AddEntryNo();
            AddMasterEntityTypeReference();
            AddDescription();
            AddPostingDate();
        }

        protected void AddEntryNo()
        {
            var entryNoPattern = new EntryNoPattern(Range, Table, Page);
            entryNoPattern.Apply();

            EntryNoField = entryNoPattern.EntryNoField;
            EntryNoControl = entryNoPattern.EntryNoControls.First().Value;
        }

        protected void AddMasterEntityTypeReference()
        {
            if (MasterEntityTypeTable != null)
            {
                MasterEntityTypeField = Table.Fields.Add(new CodeTableField(Range.GetNextTableFieldNo(Table), string.Format("{0} No.", MasterEntityTypeTable.Name), 20).AutoCaption());
                MasterEntityTypeField.Properties.TableRelation.Add(MasterEntityTypeTable.Name);

                var contentArea = Page.GetContentArea(Range);
                var group = contentArea.GetGroupByType(GroupType.Repeater, Range, Position.FirstWithinContainer);
                MasterEntityTypeControls.Add(Page, group.AddFieldPageControl(Range.GetNextPageControlID(Page), Position.LastWithinContainer, MasterEntityTypeField.Name));
            }
        }

        protected void AddDescription()
        {
            var descriptionPattern = new DescriptionPattern(Range, Table, Page);
            descriptionPattern.HasDescription2 = false;
            descriptionPattern.HasSearchDescription = false;
            descriptionPattern.Apply();

            DescriptionField = descriptionPattern.DescriptionField;
            DescriptionControls.AddRange(descriptionPattern.DescriptionControls);
        }

        public string PluralName
        {
            get
            {
                return this.pluralName ?? string.Format("{0}s", Name);
            }
            set
            {
                this.pluralName = value;
            }
        }

        public Table MasterEntityTypeTable
        {
            get;
            set;
        }

        public Table Table
        {
            get;
            protected set;
        }

        public Page Page
        {
            get;
            protected set;
        }

        public IntegerTableField EntryNoField
        {
            get;
            protected set;
        }

        public CodeTableField MasterEntityTypeField
        {
            get;
            protected set;
        }

        public TextTableField DescriptionField
        {
            get;
            protected set;
        }

        public DateTableField PostingDateField
        {
            get;
            protected set;
        }

        public FieldPageControl EntryNoControl
        {
            get;
            protected set;
        }

        public FieldPageControl MasterEntityTypeControl
        {
            get;
            protected set;
        }

        public FieldPageControl DescriptionControl
        {
            get;
            protected set;
        }
    }
}
