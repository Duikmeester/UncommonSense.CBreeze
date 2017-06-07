﻿using System;
using UncommonSense.CBreeze.Core;
using System.Management.Automation;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.New, "CBreezeBigIntegerTableField")]
    [OutputType(typeof(BigIntegerTableField))]
    [Alias("BigIntegerField")]
    public class NewCBreezeBigIntegerTableField : NewItemWithIDAndNameCmdlet<BigIntegerTableField, int, Table>
    {
        protected override void AddItemToInputObject(BigIntegerTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<BigIntegerTableField> CreateItems()
        {
            var bigIntegerTableField = new BigIntegerTableField(ID, Name);
            bigIntegerTableField.Enabled = Enabled;
            bigIntegerTableField.Properties.Description = Description;

            bigIntegerTableField.Properties.AltSearchField = AltSearchField;
            bigIntegerTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            bigIntegerTableField.Properties.AutoFormatType = AutoFormatType;
            bigIntegerTableField.Properties.AutoIncrement = AutoIncrement;
            bigIntegerTableField.Properties.BlankNumbers = BlankNumbers;
            bigIntegerTableField.Properties.BlankZero = BlankZero;
            bigIntegerTableField.Properties.CalcFormula.Set(CalcFormula);
            bigIntegerTableField.Properties.CaptionClass = CaptionClass;
            bigIntegerTableField.Properties.Description = Description;
            bigIntegerTableField.Properties.Editable = Editable;
            bigIntegerTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            bigIntegerTableField.Properties.ExternalAccess = ExternalAccess;
            bigIntegerTableField.Properties.ExternalName = ExternalName;
            bigIntegerTableField.Properties.ExternalType = ExternalType;
            bigIntegerTableField.Properties.FieldClass = FieldClass;
            bigIntegerTableField.Properties.InitValue = InitValue;
            bigIntegerTableField.Properties.MaxValue = MaxValue;
            bigIntegerTableField.Properties.MinValue = MinValue;
            bigIntegerTableField.Properties.NotBlank = NotBlank;
            bigIntegerTableField.Properties.SignDisplacement = SignDisplacement;
            bigIntegerTableField.Properties.SqlTimestamp = SqlTimestamp;
            bigIntegerTableField.Properties.TestTableRelation = TestTableRelation;
            bigIntegerTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            bigIntegerTableField.Properties.ValuesAllowed = ValuesAllowed;
            bigIntegerTableField.Properties.Volatile = Volatile;
            bigIntegerTableField.Properties.Width = Width;

            if (AutoCaption)
                bigIntegerTableField.AutoCaption();

            yield return bigIntegerTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<Boolean> AutoIncrement { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public Nullable<Boolean> BlankZero { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<Int64> InitValue { get; set; }

        [Parameter()]
        public Nullable<Int64> MaxValue { get; set; }

        [Parameter()]
        public Nullable<Int64> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> SqlTimestamp { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }

        [Parameter()]
        public Nullable<Boolean> Volatile { get; set; }

        [Parameter()]
        public Nullable<Int32> Width { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeBinaryTableField")]
    [OutputType(typeof(BinaryTableField))]
    [Alias("BinaryField")]
    public class NewCBreezeBinaryTableField : NewItemWithIDAndNameCmdlet<BinaryTableField, int, Table>
    {
        protected override void AddItemToInputObject(BinaryTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<BinaryTableField> CreateItems()
        {
            var binaryTableField = new BinaryTableField(ID, Name, DataLength ?? 4);
            binaryTableField.Enabled = Enabled;
            binaryTableField.Properties.Description = Description;

            binaryTableField.Properties.Description = Description;

            if (AutoCaption)
                binaryTableField.AutoCaption();

            yield return binaryTableField;
        }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        [ValidateRange(1, 250)]
        public int? DataLength { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeBlobTableField")]
    [OutputType(typeof(BlobTableField))]
    [Alias("BlobField")]
    public class NewCBreezeBlobTableField : NewItemWithIDAndNameCmdlet<BlobTableField, int, Table>
    {
        protected override void AddItemToInputObject(BlobTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<BlobTableField> CreateItems()
        {
            var blobTableField = new BlobTableField(ID, Name);
            blobTableField.Enabled = Enabled;
            blobTableField.Properties.Description = Description;

            blobTableField.Properties.Compressed = Compressed;
            blobTableField.Properties.Description = Description;
            blobTableField.Properties.ExternalAccess = ExternalAccess;
            blobTableField.Properties.ExternalName = ExternalName;
            blobTableField.Properties.ExternalType = ExternalType;
            blobTableField.Properties.Owner = Owner;
            blobTableField.Properties.SubType = SubType;
            blobTableField.Properties.Volatile = Volatile;

            if (AutoCaption)
                blobTableField.AutoCaption();

            yield return blobTableField;
        }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public Nullable<Boolean> Compressed { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public String Owner { get; set; }

        [Parameter()]
        public Nullable<BlobSubType> SubType { get; set; }

        [Parameter()]
        public Nullable<Boolean> Volatile { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeBooleanTableField")]
    [OutputType(typeof(BooleanTableField))]
    [Alias("BooleanField")]
    public class NewCBreezeBooleanTableField : NewItemWithIDAndNameCmdlet<BooleanTableField, int, Table>
    {
        protected override void AddItemToInputObject(BooleanTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<BooleanTableField> CreateItems()
        {
            var booleanTableField = new BooleanTableField(ID, Name);
            booleanTableField.Enabled = Enabled;
            booleanTableField.Properties.Description = Description;

            booleanTableField.Properties.AltSearchField = AltSearchField;
            booleanTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            booleanTableField.Properties.AutoFormatType = AutoFormatType;
            booleanTableField.Properties.BlankNumbers = BlankNumbers;
            booleanTableField.Properties.BlankZero = BlankZero;
            booleanTableField.Properties.CalcFormula.Set(CalcFormula);
            booleanTableField.Properties.CaptionClass = CaptionClass;
            booleanTableField.Properties.Description = Description;
            booleanTableField.Properties.Editable = Editable;
            booleanTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            booleanTableField.Properties.ExternalAccess = ExternalAccess;
            booleanTableField.Properties.ExternalName = ExternalName;
            booleanTableField.Properties.ExternalType = ExternalType;
            booleanTableField.Properties.FieldClass = FieldClass;
            booleanTableField.Properties.InitValue = InitValue;
            booleanTableField.Properties.MaxValue = MaxValue;
            booleanTableField.Properties.MinValue = MinValue;
            booleanTableField.Properties.NotBlank = NotBlank;
            booleanTableField.Properties.SignDisplacement = SignDisplacement;
            booleanTableField.Properties.TestTableRelation = TestTableRelation;
            booleanTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            booleanTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                booleanTableField.AutoCaption();

            yield return booleanTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public Nullable<Boolean> BlankZero { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<Boolean> InitValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> MaxValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeCodeTableField")]
    [OutputType(typeof(CodeTableField))]
    [Alias("CodeField")]
    public class NewCBreezeCodeTableField : NewItemWithIDAndNameCmdlet<CodeTableField, int, Table>
    {
        protected override void AddItemToInputObject(CodeTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<CodeTableField> CreateItems()
        {
            var codeTableField = new CodeTableField(ID, Name, DataLength ?? 10);
            codeTableField.Enabled = Enabled;
            codeTableField.Properties.Description = Description;

            codeTableField.Properties.AltSearchField = AltSearchField;
            codeTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            codeTableField.Properties.AutoFormatType = AutoFormatType;
            codeTableField.Properties.CalcFormula.Set(CalcFormula);
            codeTableField.Properties.CaptionClass = CaptionClass;
            codeTableField.Properties.CharAllowed = CharAllowed;
            codeTableField.Properties.DateFormula = DateFormula;
            codeTableField.Properties.Description = Description;
            codeTableField.Properties.Editable = Editable;
            codeTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            codeTableField.Properties.ExternalAccess = ExternalAccess;
            codeTableField.Properties.ExternalName = ExternalName;
            codeTableField.Properties.ExternalType = ExternalType;
            codeTableField.Properties.FieldClass = FieldClass;
            codeTableField.Properties.InitValue = InitValue;
            codeTableField.Properties.NotBlank = NotBlank;
            codeTableField.Properties.Numeric = Numeric;
            codeTableField.Properties.SQLDataType = SQLDataType;
            codeTableField.Properties.TestTableRelation = TestTableRelation;
            codeTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            codeTableField.Properties.ValuesAllowed = ValuesAllowed;
            codeTableField.Properties.Width = Width;

            if (AutoCaption)
                codeTableField.AutoCaption();

            yield return codeTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String CharAllowed { get; set; }

        [Parameter()]
        [ValidateRange(1, 250)]
        public int? DataLength { get; set; }

        [Parameter()]
        public Nullable<Boolean> DateFormula { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public String InitValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Boolean> Numeric { get; set; }

        [Parameter()]
        public Nullable<SqlDataType> SQLDataType { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }

        [Parameter()]
        public Nullable<Int32> Width { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeDateFormulaTableField")]
    [OutputType(typeof(DateFormulaTableField))]
    [Alias("DateFormulaField")]
    public class NewCBreezeDateFormulaTableField : NewItemWithIDAndNameCmdlet<DateFormulaTableField, int, Table>
    {
        protected override void AddItemToInputObject(DateFormulaTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<DateFormulaTableField> CreateItems()
        {
            var dateFormulaTableField = new DateFormulaTableField(ID, Name);
            dateFormulaTableField.Enabled = Enabled;
            dateFormulaTableField.Properties.Description = Description;

            dateFormulaTableField.Properties.AltSearchField = AltSearchField;
            dateFormulaTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            dateFormulaTableField.Properties.AutoFormatType = AutoFormatType;
            dateFormulaTableField.Properties.CalcFormula.Set(CalcFormula);
            dateFormulaTableField.Properties.CaptionClass = CaptionClass;
            dateFormulaTableField.Properties.Description = Description;
            dateFormulaTableField.Properties.Editable = Editable;
            dateFormulaTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            dateFormulaTableField.Properties.ExternalAccess = ExternalAccess;
            dateFormulaTableField.Properties.ExternalName = ExternalName;
            dateFormulaTableField.Properties.ExternalType = ExternalType;
            dateFormulaTableField.Properties.FieldClass = FieldClass;
            dateFormulaTableField.Properties.InitValue = InitValue;
            dateFormulaTableField.Properties.NotBlank = NotBlank;
            dateFormulaTableField.Properties.TestTableRelation = TestTableRelation;
            dateFormulaTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            dateFormulaTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                dateFormulaTableField.AutoCaption();

            yield return dateFormulaTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public String InitValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeDateTableField")]
    [OutputType(typeof(DateTableField))]
    [Alias("DateField")]
    public class NewCBreezeDateTableField : NewItemWithIDAndNameCmdlet<DateTableField, int, Table>
    {
        protected override void AddItemToInputObject(DateTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<DateTableField> CreateItems()
        {
            var dateTableField = new DateTableField(ID, Name);
            dateTableField.Enabled = Enabled;
            dateTableField.Properties.Description = Description;

            dateTableField.Properties.AltSearchField = AltSearchField;
            dateTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            dateTableField.Properties.AutoFormatType = AutoFormatType;
            dateTableField.Properties.BlankNumbers = BlankNumbers;
            dateTableField.Properties.CalcFormula.Set(CalcFormula);
            dateTableField.Properties.CaptionClass = CaptionClass;
            dateTableField.Properties.ClosingDates = ClosingDates;
            dateTableField.Properties.Description = Description;
            dateTableField.Properties.Editable = Editable;
            dateTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            dateTableField.Properties.ExternalAccess = ExternalAccess;
            dateTableField.Properties.ExternalName = ExternalName;
            dateTableField.Properties.ExternalType = ExternalType;
            dateTableField.Properties.FieldClass = FieldClass;
            dateTableField.Properties.InitValue = InitValue;
            dateTableField.Properties.MaxValue = MaxValue;
            dateTableField.Properties.MinValue = MinValue;
            dateTableField.Properties.NotBlank = NotBlank;
            dateTableField.Properties.SignDisplacement = SignDisplacement;
            dateTableField.Properties.TestTableRelation = TestTableRelation;
            dateTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            dateTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                dateTableField.AutoCaption();

            yield return dateTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public Nullable<Boolean> ClosingDates { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<DateTime> InitValue { get; set; }

        [Parameter()]
        public Nullable<DateTime> MaxValue { get; set; }

        [Parameter()]
        public Nullable<DateTime> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeDateTimeTableField")]
    [OutputType(typeof(DateTimeTableField))]
    [Alias("DateTimeField")]
    public class NewCBreezeDateTimeTableField : NewItemWithIDAndNameCmdlet<DateTimeTableField, int, Table>
    {
        protected override void AddItemToInputObject(DateTimeTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<DateTimeTableField> CreateItems()
        {
            var dateTimeTableField = new DateTimeTableField(ID, Name);
            dateTimeTableField.Enabled = Enabled;
            dateTimeTableField.Properties.Description = Description;

            dateTimeTableField.Properties.AltSearchField = AltSearchField;
            dateTimeTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            dateTimeTableField.Properties.AutoFormatType = AutoFormatType;
            dateTimeTableField.Properties.BlankNumbers = BlankNumbers;
            dateTimeTableField.Properties.CalcFormula.Set(CalcFormula);
            dateTimeTableField.Properties.CaptionClass = CaptionClass;
            dateTimeTableField.Properties.Description = Description;
            dateTimeTableField.Properties.Editable = Editable;
            dateTimeTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            dateTimeTableField.Properties.ExternalAccess = ExternalAccess;
            dateTimeTableField.Properties.ExternalName = ExternalName;
            dateTimeTableField.Properties.ExternalType = ExternalType;
            dateTimeTableField.Properties.FieldClass = FieldClass;
            dateTimeTableField.Properties.InitValue = InitValue;
            dateTimeTableField.Properties.MaxValue = MaxValue;
            dateTimeTableField.Properties.MinValue = MinValue;
            dateTimeTableField.Properties.NotBlank = NotBlank;
            dateTimeTableField.Properties.SignDisplacement = SignDisplacement;
            dateTimeTableField.Properties.TestTableRelation = TestTableRelation;
            dateTimeTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            dateTimeTableField.Properties.ValuesAllowed = ValuesAllowed;
            dateTimeTableField.Properties.Volatile = Volatile;

            if (AutoCaption)
                dateTimeTableField.AutoCaption();

            yield return dateTimeTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<DateTime> InitValue { get; set; }

        [Parameter()]
        public Nullable<DateTime> MaxValue { get; set; }

        [Parameter()]
        public Nullable<DateTime> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }

        [Parameter()]
        public Nullable<Boolean> Volatile { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeDecimalTableField")]
    [OutputType(typeof(DecimalTableField))]
    [Alias("DecimalField")]
    public class NewCBreezeDecimalTableField : NewItemWithIDAndNameCmdlet<DecimalTableField, int, Table>
    {
        protected override void AddItemToInputObject(DecimalTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<DecimalTableField> CreateItems()
        {
            var decimalTableField = new DecimalTableField(ID, Name);
            decimalTableField.Enabled = Enabled;
            decimalTableField.Properties.Description = Description;

            decimalTableField.Properties.AltSearchField = AltSearchField;
            decimalTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            decimalTableField.Properties.AutoFormatType = AutoFormatType;
            decimalTableField.Properties.BlankNumbers = BlankNumbers;
            decimalTableField.Properties.BlankZero = BlankZero;
            decimalTableField.Properties.CalcFormula.Set(CalcFormula);
            decimalTableField.Properties.CaptionClass = CaptionClass;
            decimalTableField.Properties.DecimalPlaces.AtLeast = DecimalPlacesAtLeast;
            decimalTableField.Properties.DecimalPlaces.AtMost = DecimalPlacesAtMost;
            decimalTableField.Properties.Description = Description;
            decimalTableField.Properties.Editable = Editable;
            decimalTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            decimalTableField.Properties.ExternalAccess = ExternalAccess;
            decimalTableField.Properties.ExternalName = ExternalName;
            decimalTableField.Properties.ExternalType = ExternalType;
            decimalTableField.Properties.FieldClass = FieldClass;
            decimalTableField.Properties.InitValue = InitValue;
            decimalTableField.Properties.MaxValue = MaxValue;
            decimalTableField.Properties.MinValue = MinValue;
            decimalTableField.Properties.NotBlank = NotBlank;
            decimalTableField.Properties.SignDisplacement = SignDisplacement;
            decimalTableField.Properties.TestTableRelation = TestTableRelation;
            decimalTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            decimalTableField.Properties.ValuesAllowed = ValuesAllowed;
            decimalTableField.Properties.Width = Width;

            if (AutoCaption)
                decimalTableField.AutoCaption();

            yield return decimalTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public Nullable<Boolean> BlankZero { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public Nullable<Int32> DecimalPlacesAtLeast { get; set; }

        [Parameter()]
        public Nullable<Int32> DecimalPlacesAtMost { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<Decimal> InitValue { get; set; }

        [Parameter()]
        public Nullable<Decimal> MaxValue { get; set; }

        [Parameter()]
        public Nullable<Decimal> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }

        [Parameter()]
        public Nullable<Int32> Width { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeDurationTableField")]
    [OutputType(typeof(DurationTableField))]
    [Alias("DurationField")]
    public class NewCBreezeDurationTableField : NewItemWithIDAndNameCmdlet<DurationTableField, int, Table>
    {
        protected override void AddItemToInputObject(DurationTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<DurationTableField> CreateItems()
        {
            var durationTableField = new DurationTableField(ID, Name);
            durationTableField.Enabled = Enabled;
            durationTableField.Properties.Description = Description;

            durationTableField.Properties.AltSearchField = AltSearchField;
            durationTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            durationTableField.Properties.AutoFormatType = AutoFormatType;
            durationTableField.Properties.BlankNumbers = BlankNumbers;
            durationTableField.Properties.BlankZero = BlankZero;
            durationTableField.Properties.CalcFormula.Set(CalcFormula);
            durationTableField.Properties.CaptionClass = CaptionClass;
            durationTableField.Properties.Description = Description;
            durationTableField.Properties.Editable = Editable;
            durationTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            durationTableField.Properties.ExternalAccess = ExternalAccess;
            durationTableField.Properties.ExternalName = ExternalName;
            durationTableField.Properties.ExternalType = ExternalType;
            durationTableField.Properties.FieldClass = FieldClass;
            durationTableField.Properties.InitValue = InitValue;
            durationTableField.Properties.MaxValue = MaxValue;
            durationTableField.Properties.MinValue = MinValue;
            durationTableField.Properties.NotBlank = NotBlank;
            durationTableField.Properties.SignDisplacement = SignDisplacement;
            durationTableField.Properties.StandardDayTimeUnit = StandardDayTimeUnit;
            durationTableField.Properties.TestTableRelation = TestTableRelation;
            durationTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            durationTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                durationTableField.AutoCaption();

            yield return durationTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public Nullable<Boolean> BlankZero { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<TimeSpan> InitValue { get; set; }

        [Parameter()]
        public Nullable<TimeSpan> MaxValue { get; set; }

        [Parameter()]
        public Nullable<TimeSpan> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<StandardDayTimeUnit> StandardDayTimeUnit { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeGuidTableField")]
    [OutputType(typeof(GuidTableField))]
    [Alias("GuidField")]
    public class NewCBreezeGuidTableField : NewItemWithIDAndNameCmdlet<GuidTableField, int, Table>
    {
        protected override void AddItemToInputObject(GuidTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<GuidTableField> CreateItems()
        {
            var guidTableField = new GuidTableField(ID, Name);
            guidTableField.Enabled = Enabled;
            guidTableField.Properties.Description = Description;

            guidTableField.Properties.AltSearchField = AltSearchField;
            guidTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            guidTableField.Properties.AutoFormatType = AutoFormatType;
            guidTableField.Properties.CalcFormula.Set(CalcFormula);
            guidTableField.Properties.CaptionClass = CaptionClass;
            guidTableField.Properties.Description = Description;
            guidTableField.Properties.Editable = Editable;
            guidTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            guidTableField.Properties.ExternalAccess = ExternalAccess;
            guidTableField.Properties.ExternalName = ExternalName;
            guidTableField.Properties.ExternalType = ExternalType;
            guidTableField.Properties.FieldClass = FieldClass;
            guidTableField.Properties.InitValue = InitValue;
            guidTableField.Properties.NotBlank = NotBlank;
            guidTableField.Properties.TestTableRelation = TestTableRelation;
            guidTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            guidTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                guidTableField.AutoCaption();

            yield return guidTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<Guid> InitValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeIntegerTableField")]
    [OutputType(typeof(IntegerTableField))]
    [Alias("IntegerField")]
    public class NewCBreezeIntegerTableField : NewItemWithIDAndNameCmdlet<IntegerTableField, int, Table>
    {
        protected override void AddItemToInputObject(IntegerTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<IntegerTableField> CreateItems()
        {
            var integerTableField = new IntegerTableField(ID, Name);
            integerTableField.Enabled = Enabled;
            integerTableField.Properties.Description = Description;

            integerTableField.Properties.AltSearchField = AltSearchField;
            integerTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            integerTableField.Properties.AutoFormatType = AutoFormatType;
            integerTableField.Properties.AutoIncrement = AutoIncrement;
            integerTableField.Properties.BlankNumbers = BlankNumbers;
            integerTableField.Properties.BlankZero = BlankZero;
            integerTableField.Properties.CalcFormula.Set(CalcFormula);
            integerTableField.Properties.CaptionClass = CaptionClass;
            integerTableField.Properties.Description = Description;
            integerTableField.Properties.Editable = Editable;
            integerTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            integerTableField.Properties.ExternalAccess = ExternalAccess;
            integerTableField.Properties.ExternalName = ExternalName;
            integerTableField.Properties.ExternalType = ExternalType;
            integerTableField.Properties.FieldClass = FieldClass;
            integerTableField.Properties.InitValue = InitValue;
            integerTableField.Properties.MaxValue = MaxValue;
            integerTableField.Properties.MinValue = MinValue;
            integerTableField.Properties.NotBlank = NotBlank;
            integerTableField.Properties.SignDisplacement = SignDisplacement;
            integerTableField.Properties.TestTableRelation = TestTableRelation;
            integerTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            integerTableField.Properties.ValuesAllowed = ValuesAllowed;
            integerTableField.Properties.Volatile = Volatile;
            integerTableField.Properties.Width = Width;

            if (AutoCaption)
                integerTableField.AutoCaption();

            yield return integerTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<Boolean> AutoIncrement { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public Nullable<Boolean> BlankZero { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<Int32> InitValue { get; set; }

        [Parameter()]
        public Nullable<Int32> MaxValue { get; set; }

        [Parameter()]
        public Nullable<Int32> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }

        [Parameter()]
        public Nullable<Boolean> Volatile { get; set; }

        [Parameter()]
        public Nullable<Int32> Width { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeOptionTableField")]
    [OutputType(typeof(OptionTableField))]
    [Alias("OptionField")]
    public class NewCBreezeOptionTableField : NewItemWithIDAndNameCmdlet<OptionTableField, int, Table>
    {
        protected override void AddItemToInputObject(OptionTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<OptionTableField> CreateItems()
        {
            var optionTableField = new OptionTableField(ID, Name);
            optionTableField.Enabled = Enabled;
            optionTableField.Properties.Description = Description;

            optionTableField.Properties.AltSearchField = AltSearchField;
            optionTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            optionTableField.Properties.AutoFormatType = AutoFormatType;
            optionTableField.Properties.BlankNumbers = BlankNumbers;
            optionTableField.Properties.BlankZero = BlankZero;
            optionTableField.Properties.CalcFormula.Set(CalcFormula);
            optionTableField.Properties.CaptionClass = CaptionClass;
            optionTableField.Properties.Description = Description;
            optionTableField.Properties.Editable = Editable;
            optionTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            optionTableField.Properties.ExternalAccess = ExternalAccess;
            optionTableField.Properties.ExternalName = ExternalName;
            optionTableField.Properties.ExternalType = ExternalType;
            optionTableField.Properties.FieldClass = FieldClass;
            optionTableField.Properties.InitValue = InitValue;
            optionTableField.Properties.MaxValue = MaxValue;
            optionTableField.Properties.MinValue = MinValue;
            optionTableField.Properties.NotBlank = NotBlank;
            optionTableField.Properties.OptionOrdinalValue = OptionOrdinalValue;
            optionTableField.Properties.OptionString = OptionString;
            optionTableField.Properties.SignDisplacement = SignDisplacement;
            optionTableField.Properties.TestTableRelation = TestTableRelation;
            optionTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            optionTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoOptionCaption)
                optionTableField.AutoOptionCaption();

            if (AutoCaption)
                optionTableField.AutoCaption();

            yield return optionTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public SwitchParameter AutoOptionCaption { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public Nullable<Boolean> BlankZero { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public String InitValue { get; set; }

        [Parameter()]
        public String MaxValue { get; set; }

        [Parameter()]
        public String MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public String OptionOrdinalValue { get; set; }

        [Parameter(Mandatory = true)]
        public String OptionString { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeRecordIDTableField")]
    [OutputType(typeof(RecordIDTableField))]
    [Alias("RecordIDField")]
    public class NewCBreezeRecordIDTableField : NewItemWithIDAndNameCmdlet<RecordIDTableField, int, Table>
    {
        protected override void AddItemToInputObject(RecordIDTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<RecordIDTableField> CreateItems()
        {
            var recordIDTableField = new RecordIDTableField(ID, Name);
            recordIDTableField.Enabled = Enabled;
            recordIDTableField.Properties.Description = Description;

            recordIDTableField.Properties.AltSearchField = AltSearchField;
            recordIDTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            recordIDTableField.Properties.AutoFormatType = AutoFormatType;
            recordIDTableField.Properties.CalcFormula.Set(CalcFormula);
            recordIDTableField.Properties.CaptionClass = CaptionClass;
            recordIDTableField.Properties.Description = Description;
            recordIDTableField.Properties.Editable = Editable;
            recordIDTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            recordIDTableField.Properties.ExternalAccess = ExternalAccess;
            recordIDTableField.Properties.ExternalName = ExternalName;
            recordIDTableField.Properties.ExternalType = ExternalType;
            recordIDTableField.Properties.FieldClass = FieldClass;
            recordIDTableField.Properties.InitValue = InitValue;
            recordIDTableField.Properties.NotBlank = NotBlank;
            recordIDTableField.Properties.TestTableRelation = TestTableRelation;
            recordIDTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            recordIDTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                recordIDTableField.AutoCaption();

            yield return recordIDTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public String InitValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeTableFilterTableField")]
    [OutputType(typeof(TableFilterTableField))]
    [Alias("FilterField")]
    public class NewCBreezeTableFilterTableField : NewItemWithIDAndNameCmdlet<TableFilterTableField, int, Table>
    {
        protected override void AddItemToInputObject(TableFilterTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<TableFilterTableField> CreateItems()
        {
            var tableFilterTableField = new TableFilterTableField(ID, Name);
            tableFilterTableField.Enabled = Enabled;
            tableFilterTableField.Properties.Description = Description;

            tableFilterTableField.Properties.Description = Description;
            tableFilterTableField.Properties.TableIDExpr = TableIDExpr;

            if (AutoCaption)
                tableFilterTableField.AutoCaption();

            yield return tableFilterTableField;
        }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public String TableIDExpr { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeTextTableField")]
    [OutputType(typeof(TextTableField))]
    [Alias("TextField")]
    public class NewCBreezeTextTableField : NewItemWithIDAndNameCmdlet<TextTableField, int, Table>
    {
        protected override void AddItemToInputObject(TextTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<TextTableField> CreateItems()
        {
            var textTableField = new TextTableField(ID, Name, DataLength ?? 30);
            textTableField.Enabled = Enabled;
            textTableField.Properties.Description = Description;

            textTableField.Properties.AltSearchField = AltSearchField;
            textTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            textTableField.Properties.AutoFormatType = AutoFormatType;
            textTableField.Properties.CalcFormula.Set(CalcFormula);
            textTableField.Properties.CaptionClass = CaptionClass;
            textTableField.Properties.CharAllowed = CharAllowed;
            textTableField.Properties.DateFormula = DateFormula;
            textTableField.Properties.Description = Description;
            textTableField.Properties.Editable = Editable;
            textTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            textTableField.Properties.ExternalAccess = ExternalAccess;
            textTableField.Properties.ExternalName = ExternalName;
            textTableField.Properties.ExternalType = ExternalType;
            textTableField.Properties.FieldClass = FieldClass;
            textTableField.Properties.InitValue = InitValue;
            textTableField.Properties.NotBlank = NotBlank;
            textTableField.Properties.Numeric = Numeric;
            textTableField.Properties.TestTableRelation = TestTableRelation;
            textTableField.Properties.Title = Title;
            textTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            textTableField.Properties.ValuesAllowed = ValuesAllowed;
            textTableField.Properties.Width = Width;

            if (AutoCaption)
                textTableField.AutoCaption();

            yield return textTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String CharAllowed { get; set; }

        [Parameter()]
        [ValidateRange(1, 250)]
        public int? DataLength { get; set; }

        [Parameter()]
        public Nullable<Boolean> DateFormula { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public String InitValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Boolean> Numeric { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> Title { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }

        [Parameter()]
        public Nullable<Int32> Width { get; set; }
    }

    [Cmdlet(VerbsCommon.New, "CBreezeTimeTableField")]
    [OutputType(typeof(TimeTableField))]
    [Alias("TimeField")]
    public class NewCBreezeTimeTableField : NewItemWithIDAndNameCmdlet<TimeTableField, int, Table>
    {
        protected override void AddItemToInputObject(TimeTableField item, Table inputObject)
        {
            inputObject.Fields.Add(item);
        }

        protected override IEnumerable<TimeTableField> CreateItems()
        {
            var timeTableField = new TimeTableField(ID, Name);
            timeTableField.Enabled = Enabled;
            timeTableField.Properties.Description = Description;

            timeTableField.Properties.AltSearchField = AltSearchField;
            timeTableField.Properties.AutoFormatExpr = AutoFormatExpr;
            timeTableField.Properties.AutoFormatType = AutoFormatType;
            timeTableField.Properties.BlankNumbers = BlankNumbers;
            timeTableField.Properties.CalcFormula.Set(CalcFormula);
            timeTableField.Properties.CaptionClass = CaptionClass;
            timeTableField.Properties.Description = Description;
            timeTableField.Properties.Editable = Editable;
            timeTableField.Properties.ExtendedDatatype = ExtendedDatatype;
            timeTableField.Properties.ExternalAccess = ExternalAccess;
            timeTableField.Properties.ExternalName = ExternalName;
            timeTableField.Properties.ExternalType = ExternalType;
            timeTableField.Properties.FieldClass = FieldClass;
            timeTableField.Properties.InitValue = InitValue;
            timeTableField.Properties.MaxValue = MaxValue;
            timeTableField.Properties.MinValue = MinValue;
            timeTableField.Properties.NotBlank = NotBlank;
            timeTableField.Properties.SignDisplacement = SignDisplacement;
            timeTableField.Properties.TestTableRelation = TestTableRelation;
            timeTableField.Properties.ValidateTableRelation = ValidateTableRelation;
            timeTableField.Properties.ValuesAllowed = ValuesAllowed;

            if (AutoCaption)
                timeTableField.AutoCaption();

            yield return timeTableField;
        }

        [Parameter()]
        public String AltSearchField { get; set; }

        [Parameter()]
        public SwitchParameter AutoCaption { get; set; }

        [Parameter()]
        public String AutoFormatExpr { get; set; }

        [Parameter()]
        public Nullable<AutoFormatType> AutoFormatType { get; set; }

        [Parameter()]
        public Nullable<BlankNumbers> BlankNumbers { get; set; }

        [Parameter()]
        public CalcFormula CalcFormula { get; set; }

        [Parameter()]
        public String CaptionClass { get; set; }

        [Parameter()]
        public String Description { get; set; }

        [Parameter()]
        public Nullable<Boolean> Editable { get; set; }

        [Parameter()]
        public bool? Enabled { get; set; }

        [Parameter()]
        public Nullable<ExtendedDataType> ExtendedDatatype { get; set; }

        [Parameter()]
        public Nullable<ExternalAccess> ExternalAccess { get; set; }

        [Parameter()]
        public String ExternalName { get; set; }

        [Parameter()]
        public String ExternalType { get; set; }

        [Parameter()]
        public Nullable<FieldClass> FieldClass { get; set; }

        [Parameter()]
        public Nullable<TimeSpan> InitValue { get; set; }

        [Parameter()]
        public Nullable<TimeSpan> MaxValue { get; set; }

        [Parameter()]
        public Nullable<TimeSpan> MinValue { get; set; }

        [Parameter()]
        public Nullable<Boolean> NotBlank { get; set; }

        [Parameter()]
        public Nullable<Int32> SignDisplacement { get; set; }

        [Parameter()]
        public Nullable<Boolean> TestTableRelation { get; set; }

        [Parameter()]
        public Nullable<Boolean> ValidateTableRelation { get; set; }

        [Parameter()]
        public String ValuesAllowed { get; set; }
    }
}