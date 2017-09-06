﻿using System;
using System.Management.Automation;
using UncommonSense.CBreeze.Core;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Automation 
{
	[Cmdlet(VerbsCommon.New, "CBreezeActionVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(ActionVariable))]
	[Alias("ActionVariable")]
	public class NewBreezeActionVariable : NewItemWithIDAndNameCmdlet<ActionVariable, int, PSObject>
	{
		protected override IEnumerable<ActionVariable> CreateItems()
		{
			var actionVariable = new ActionVariable(ID, Name);
			actionVariable.Dimensions = Dimensions;
			yield return actionVariable;
		}

		protected override void AddItemToInputObject(ActionVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeAutomationVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(AutomationVariable))]
	[Alias("AutomationVariable")]
	public class NewBreezeAutomationVariable : NewItemWithIDAndNameCmdlet<AutomationVariable, int, PSObject>
	{
		protected override IEnumerable<AutomationVariable> CreateItems()
		{
			var automationVariable = new AutomationVariable(ID, Name, SubType);
			automationVariable.Dimensions = Dimensions;
			automationVariable.WithEvents = WithEvents;
			yield return automationVariable;
		}

		protected override void AddItemToInputObject(AutomationVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public String SubType { get; set; }

		[Parameter()]
		public Nullable<Boolean> WithEvents { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeBigIntegerVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(BigIntegerVariable))]
	[Alias("BigIntegerVariable")]
	public class NewBreezeBigIntegerVariable : NewItemWithIDAndNameCmdlet<BigIntegerVariable, int, PSObject>
	{
		protected override IEnumerable<BigIntegerVariable> CreateItems()
		{
			var bigIntegerVariable = new BigIntegerVariable(ID, Name);
			bigIntegerVariable.Dimensions = Dimensions;
			yield return bigIntegerVariable;
		}

		protected override void AddItemToInputObject(BigIntegerVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeBigTextVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(BigTextVariable))]
	[Alias("BigTextVariable")]
	public class NewBreezeBigTextVariable : NewItemWithIDAndNameCmdlet<BigTextVariable, int, PSObject>
	{
		protected override IEnumerable<BigTextVariable> CreateItems()
		{
			var bigTextVariable = new BigTextVariable(ID, Name);
			bigTextVariable.Dimensions = Dimensions;
			yield return bigTextVariable;
		}

		protected override void AddItemToInputObject(BigTextVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeBinaryVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(BinaryVariable))]
	[Alias("BinaryVariable")]
	public class NewBreezeBinaryVariable : NewItemWithIDAndNameCmdlet<BinaryVariable, int, PSObject>
	{
		protected override IEnumerable<BinaryVariable> CreateItems()
		{
			var binaryVariable = new BinaryVariable(ID, Name, DataLength);
			binaryVariable.Dimensions = Dimensions;
			yield return binaryVariable;
		}

		protected override void AddItemToInputObject(BinaryVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter(Position=3, ParameterSetName="AddWithID")]
		[Parameter(Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Position=3, ParameterSetName="NewWithID")]
		[Parameter(Position=2, ParameterSetName="NewWithoutID")]
		public Int32 DataLength { get; set; }

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeBooleanVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(BooleanVariable))]
	[Alias("BooleanVariable")]
	public class NewBreezeBooleanVariable : NewItemWithIDAndNameCmdlet<BooleanVariable, int, PSObject>
	{
		protected override IEnumerable<BooleanVariable> CreateItems()
		{
			var booleanVariable = new BooleanVariable(ID, Name);
			booleanVariable.Dimensions = Dimensions;
			booleanVariable.IncludeInDataset = IncludeInDataset;
			yield return booleanVariable;
		}

		protected override void AddItemToInputObject(BooleanVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<Boolean> IncludeInDataset { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeByteVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(ByteVariable))]
	[Alias("ByteVariable")]
	public class NewBreezeByteVariable : NewItemWithIDAndNameCmdlet<ByteVariable, int, PSObject>
	{
		protected override IEnumerable<ByteVariable> CreateItems()
		{
			var byteVariable = new ByteVariable(ID, Name);
			byteVariable.Dimensions = Dimensions;
			yield return byteVariable;
		}

		protected override void AddItemToInputObject(ByteVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeCharVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(CharVariable))]
	[Alias("CharVariable")]
	public class NewBreezeCharVariable : NewItemWithIDAndNameCmdlet<CharVariable, int, PSObject>
	{
		protected override IEnumerable<CharVariable> CreateItems()
		{
			var charVariable = new CharVariable(ID, Name);
			charVariable.Dimensions = Dimensions;
			yield return charVariable;
		}

		protected override void AddItemToInputObject(CharVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeFilterPageBuilderVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(FilterPageBuilderVariable))]
	[Alias("FilterPageBuilderVariable")]
	public class NewBreezeFilterPageBuilderVariable : NewItemWithIDAndNameCmdlet<FilterPageBuilderVariable, int, PSObject>
	{
		protected override IEnumerable<FilterPageBuilderVariable> CreateItems()
		{
			var filterPageBuilderVariable = new FilterPageBuilderVariable(ID, Name);
			filterPageBuilderVariable.Dimensions = Dimensions;
			yield return filterPageBuilderVariable;
		}

		protected override void AddItemToInputObject(FilterPageBuilderVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeCodeunitVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(CodeunitVariable))]
	[Alias("CodeunitVariable")]
	public class NewBreezeCodeunitVariable : NewItemWithIDAndNameCmdlet<CodeunitVariable, int, PSObject>
	{
		protected override IEnumerable<CodeunitVariable> CreateItems()
		{
			var codeunitVariable = new CodeunitVariable(ID, Name, SubType);
			codeunitVariable.Dimensions = Dimensions;
			yield return codeunitVariable;
		}

		protected override void AddItemToInputObject(CodeunitVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeCodeVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(CodeVariable))]
	[Alias("CodeVariable")]
	public class NewBreezeCodeVariable : NewItemWithIDAndNameCmdlet<CodeVariable, int, PSObject>
	{
		protected override IEnumerable<CodeVariable> CreateItems()
		{
			var codeVariable = new CodeVariable(ID, Name, DataLength);
			codeVariable.Dimensions = Dimensions;
			codeVariable.IncludeInDataset = IncludeInDataset;
			yield return codeVariable;
		}

		protected override void AddItemToInputObject(CodeVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter(Position=3, ParameterSetName="AddWithID")]
		[Parameter(Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Position=3, ParameterSetName="NewWithID")]
		[Parameter(Position=2, ParameterSetName="NewWithoutID")]
		public Int32 DataLength { get; set; }

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<Boolean> IncludeInDataset { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDateFormulaVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DateFormulaVariable))]
	[Alias("DateFormulaVariable")]
	public class NewBreezeDateFormulaVariable : NewItemWithIDAndNameCmdlet<DateFormulaVariable, int, PSObject>
	{
		protected override IEnumerable<DateFormulaVariable> CreateItems()
		{
			var dateFormulaVariable = new DateFormulaVariable(ID, Name);
			dateFormulaVariable.Dimensions = Dimensions;
			yield return dateFormulaVariable;
		}

		protected override void AddItemToInputObject(DateFormulaVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDateTimeVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DateTimeVariable))]
	[Alias("DateTimeVariable")]
	public class NewBreezeDateTimeVariable : NewItemWithIDAndNameCmdlet<DateTimeVariable, int, PSObject>
	{
		protected override IEnumerable<DateTimeVariable> CreateItems()
		{
			var dateTimeVariable = new DateTimeVariable(ID, Name);
			dateTimeVariable.Dimensions = Dimensions;
			yield return dateTimeVariable;
		}

		protected override void AddItemToInputObject(DateTimeVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDateVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DateVariable))]
	[Alias("DateVariable")]
	public class NewBreezeDateVariable : NewItemWithIDAndNameCmdlet<DateVariable, int, PSObject>
	{
		protected override IEnumerable<DateVariable> CreateItems()
		{
			var dateVariable = new DateVariable(ID, Name);
			dateVariable.Dimensions = Dimensions;
			yield return dateVariable;
		}

		protected override void AddItemToInputObject(DateVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDecimalVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DecimalVariable))]
	[Alias("DecimalVariable")]
	public class NewBreezeDecimalVariable : NewItemWithIDAndNameCmdlet<DecimalVariable, int, PSObject>
	{
		protected override IEnumerable<DecimalVariable> CreateItems()
		{
			var decimalVariable = new DecimalVariable(ID, Name);
			decimalVariable.Dimensions = Dimensions;
			yield return decimalVariable;
		}

		protected override void AddItemToInputObject(DecimalVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDialogVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DialogVariable))]
	[Alias("DialogVariable")]
	public class NewBreezeDialogVariable : NewItemWithIDAndNameCmdlet<DialogVariable, int, PSObject>
	{
		protected override IEnumerable<DialogVariable> CreateItems()
		{
			var dialogVariable = new DialogVariable(ID, Name);
			dialogVariable.Dimensions = Dimensions;
			yield return dialogVariable;
		}

		protected override void AddItemToInputObject(DialogVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDotNetVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DotNetVariable))]
	[Alias("DotNetVariable")]
	public class NewBreezeDotNetVariable : NewItemWithIDAndNameCmdlet<DotNetVariable, int, PSObject>
	{
		protected override IEnumerable<DotNetVariable> CreateItems()
		{
			var dotNetVariable = new DotNetVariable(ID, Name, SubType);
			dotNetVariable.Dimensions = Dimensions;
			dotNetVariable.RunOnClient = RunOnClient;
			dotNetVariable.WithEvents = WithEvents;
			yield return dotNetVariable;
		}

		protected override void AddItemToInputObject(DotNetVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<Boolean> RunOnClient { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public String SubType { get; set; }

		[Parameter()]
		public Nullable<Boolean> WithEvents { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeDurationVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(DurationVariable))]
	[Alias("DurationVariable")]
	public class NewBreezeDurationVariable : NewItemWithIDAndNameCmdlet<DurationVariable, int, PSObject>
	{
		protected override IEnumerable<DurationVariable> CreateItems()
		{
			var durationVariable = new DurationVariable(ID, Name);
			durationVariable.Dimensions = Dimensions;
			yield return durationVariable;
		}

		protected override void AddItemToInputObject(DurationVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeExecutionModeVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(ExecutionModeVariable))]
	[Alias("ExecutionModeVariable")]
	public class NewBreezeExecutionModeVariable : NewItemWithIDAndNameCmdlet<ExecutionModeVariable, int, PSObject>
	{
		protected override IEnumerable<ExecutionModeVariable> CreateItems()
		{
			var executionModeVariable = new ExecutionModeVariable(ID, Name);
			executionModeVariable.Dimensions = Dimensions;
			yield return executionModeVariable;
		}

		protected override void AddItemToInputObject(ExecutionModeVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeFieldRefVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(FieldRefVariable))]
	[Alias("FieldRefVariable")]
	public class NewBreezeFieldRefVariable : NewItemWithIDAndNameCmdlet<FieldRefVariable, int, PSObject>
	{
		protected override IEnumerable<FieldRefVariable> CreateItems()
		{
			var fieldRefVariable = new FieldRefVariable(ID, Name);
			fieldRefVariable.Dimensions = Dimensions;
			yield return fieldRefVariable;
		}

		protected override void AddItemToInputObject(FieldRefVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeFileVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(FileVariable))]
	[Alias("FileVariable")]
	public class NewBreezeFileVariable : NewItemWithIDAndNameCmdlet<FileVariable, int, PSObject>
	{
		protected override IEnumerable<FileVariable> CreateItems()
		{
			var fileVariable = new FileVariable(ID, Name);
			fileVariable.Dimensions = Dimensions;
			yield return fileVariable;
		}

		protected override void AddItemToInputObject(FileVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeReportFormatVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(ReportFormatVariable))]
	[Alias("ReportFormatVariable")]
	public class NewBreezeReportFormatVariable : NewItemWithIDAndNameCmdlet<ReportFormatVariable, int, PSObject>
	{
		protected override IEnumerable<ReportFormatVariable> CreateItems()
		{
			var reportFormatVariable = new ReportFormatVariable(ID, Name);
			reportFormatVariable.Dimensions = Dimensions;
			yield return reportFormatVariable;
		}

		protected override void AddItemToInputObject(ReportFormatVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTableConnectionTypeVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TableConnectionTypeVariable))]
	[Alias("TableConnectionTypeVariable")]
	public class NewBreezeTableConnectionTypeVariable : NewItemWithIDAndNameCmdlet<TableConnectionTypeVariable, int, PSObject>
	{
		protected override IEnumerable<TableConnectionTypeVariable> CreateItems()
		{
			var tableConnectionTypeVariable = new TableConnectionTypeVariable(ID, Name);
			tableConnectionTypeVariable.Dimensions = Dimensions;
			yield return tableConnectionTypeVariable;
		}

		protected override void AddItemToInputObject(TableConnectionTypeVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeGuidVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(GuidVariable))]
	[Alias("GuidVariable")]
	public class NewBreezeGuidVariable : NewItemWithIDAndNameCmdlet<GuidVariable, int, PSObject>
	{
		protected override IEnumerable<GuidVariable> CreateItems()
		{
			var guidVariable = new GuidVariable(ID, Name);
			guidVariable.Dimensions = Dimensions;
			yield return guidVariable;
		}

		protected override void AddItemToInputObject(GuidVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeInStreamVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(InStreamVariable))]
	[Alias("InStreamVariable")]
	public class NewBreezeInStreamVariable : NewItemWithIDAndNameCmdlet<InStreamVariable, int, PSObject>
	{
		protected override IEnumerable<InStreamVariable> CreateItems()
		{
			var inStreamVariable = new InStreamVariable(ID, Name);
			inStreamVariable.Dimensions = Dimensions;
			yield return inStreamVariable;
		}

		protected override void AddItemToInputObject(InStreamVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeIntegerVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(IntegerVariable))]
	[Alias("IntegerVariable")]
	public class NewBreezeIntegerVariable : NewItemWithIDAndNameCmdlet<IntegerVariable, int, PSObject>
	{
		protected override IEnumerable<IntegerVariable> CreateItems()
		{
			var integerVariable = new IntegerVariable(ID, Name);
			integerVariable.Dimensions = Dimensions;
			integerVariable.IncludeInDataset = IncludeInDataset;
			yield return integerVariable;
		}

		protected override void AddItemToInputObject(IntegerVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<Boolean> IncludeInDataset { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeKeyRefVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(KeyRefVariable))]
	[Alias("KeyRefVariable")]
	public class NewBreezeKeyRefVariable : NewItemWithIDAndNameCmdlet<KeyRefVariable, int, PSObject>
	{
		protected override IEnumerable<KeyRefVariable> CreateItems()
		{
			var keyRefVariable = new KeyRefVariable(ID, Name);
			keyRefVariable.Dimensions = Dimensions;
			yield return keyRefVariable;
		}

		protected override void AddItemToInputObject(KeyRefVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeOcxVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(OcxVariable))]
	[Alias("OcxVariable")]
	public class NewBreezeOcxVariable : NewItemWithIDAndNameCmdlet<OcxVariable, int, PSObject>
	{
		protected override IEnumerable<OcxVariable> CreateItems()
		{
			var ocxVariable = new OcxVariable(ID, Name, SubType);
			ocxVariable.Dimensions = Dimensions;
			yield return ocxVariable;
		}

		protected override void AddItemToInputObject(OcxVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public String SubType { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeOptionVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(OptionVariable))]
	[Alias("OptionVariable")]
	public class NewBreezeOptionVariable : NewItemWithIDAndNameCmdlet<OptionVariable, int, PSObject>
	{
		protected override IEnumerable<OptionVariable> CreateItems()
		{
			var optionVariable = new OptionVariable(ID, Name);
			optionVariable.Dimensions = Dimensions;
			optionVariable.OptionString = OptionString;
			yield return optionVariable;
		}

		protected override void AddItemToInputObject(OptionVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Position=3, ParameterSetName="AddWithID")]
		[Parameter(Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Position=3, ParameterSetName="NewWithID")]
		[Parameter(Position=2, ParameterSetName="NewWithoutID")]
		public String OptionString { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeOutStreamVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(OutStreamVariable))]
	[Alias("OutStreamVariable")]
	public class NewBreezeOutStreamVariable : NewItemWithIDAndNameCmdlet<OutStreamVariable, int, PSObject>
	{
		protected override IEnumerable<OutStreamVariable> CreateItems()
		{
			var outStreamVariable = new OutStreamVariable(ID, Name);
			outStreamVariable.Dimensions = Dimensions;
			yield return outStreamVariable;
		}

		protected override void AddItemToInputObject(OutStreamVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezePageVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(PageVariable))]
	[Alias("PageVariable")]
	public class NewBreezePageVariable : NewItemWithIDAndNameCmdlet<PageVariable, int, PSObject>
	{
		protected override IEnumerable<PageVariable> CreateItems()
		{
			var pageVariable = new PageVariable(ID, Name, SubType);
			pageVariable.Dimensions = Dimensions;
			yield return pageVariable;
		}

		protected override void AddItemToInputObject(PageVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeQueryVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(QueryVariable))]
	[Alias("QueryVariable")]
	public class NewBreezeQueryVariable : NewItemWithIDAndNameCmdlet<QueryVariable, int, PSObject>
	{
		protected override IEnumerable<QueryVariable> CreateItems()
		{
			var queryVariable = new QueryVariable(ID, Name, SubType);
			queryVariable.Dimensions = Dimensions;
			queryVariable.SecurityFiltering = SecurityFiltering;
			yield return queryVariable;
		}

		protected override void AddItemToInputObject(QueryVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<QuerySecurityFiltering> SecurityFiltering { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeRecordIDVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(RecordIDVariable))]
	[Alias("RecordIDVariable")]
	public class NewBreezeRecordIDVariable : NewItemWithIDAndNameCmdlet<RecordIDVariable, int, PSObject>
	{
		protected override IEnumerable<RecordIDVariable> CreateItems()
		{
			var recordIDVariable = new RecordIDVariable(ID, Name);
			recordIDVariable.Dimensions = Dimensions;
			yield return recordIDVariable;
		}

		protected override void AddItemToInputObject(RecordIDVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeRecordRefVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(RecordRefVariable))]
	[Alias("RecordRefVariable")]
	public class NewBreezeRecordRefVariable : NewItemWithIDAndNameCmdlet<RecordRefVariable, int, PSObject>
	{
		protected override IEnumerable<RecordRefVariable> CreateItems()
		{
			var recordRefVariable = new RecordRefVariable(ID, Name);
			recordRefVariable.Dimensions = Dimensions;
			recordRefVariable.SecurityFiltering = SecurityFiltering;
			yield return recordRefVariable;
		}

		protected override void AddItemToInputObject(RecordRefVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<RecordSecurityFiltering> SecurityFiltering { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeRecordVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(RecordVariable))]
	[Alias("RecordVariable")]
	public class NewBreezeRecordVariable : NewItemWithIDAndNameCmdlet<RecordVariable, int, PSObject>
	{
		protected override IEnumerable<RecordVariable> CreateItems()
		{
			var recordVariable = new RecordVariable(ID, Name, SubType);
			recordVariable.Dimensions = Dimensions;
			recordVariable.SecurityFiltering = SecurityFiltering;
			recordVariable.Temporary = Temporary;
			yield return recordVariable;
		}

		protected override void AddItemToInputObject(RecordVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<RecordSecurityFiltering> SecurityFiltering { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

		[Parameter()]
		public Nullable<Boolean> Temporary { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeReportVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(ReportVariable))]
	[Alias("ReportVariable")]
	public class NewBreezeReportVariable : NewItemWithIDAndNameCmdlet<ReportVariable, int, PSObject>
	{
		protected override IEnumerable<ReportVariable> CreateItems()
		{
			var reportVariable = new ReportVariable(ID, Name, SubType);
			reportVariable.Dimensions = Dimensions;
			yield return reportVariable;
		}

		protected override void AddItemToInputObject(ReportVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTestPageVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TestPageVariable))]
	[Alias("TestPageVariable")]
	public class NewBreezeTestPageVariable : NewItemWithIDAndNameCmdlet<TestPageVariable, int, PSObject>
	{
		protected override IEnumerable<TestPageVariable> CreateItems()
		{
			var testPageVariable = new TestPageVariable(ID, Name, SubType);
			testPageVariable.Dimensions = Dimensions;
			yield return testPageVariable;
		}

		protected override void AddItemToInputObject(TestPageVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTextConstant", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TextConstant))]
	[Alias("TextConstant")]
	public class NewBreezeTextConstant : NewItemWithIDAndNameCmdlet<TextConstant, int, PSObject>
	{
		protected override IEnumerable<TextConstant> CreateItems()
		{
			var textConstant = new TextConstant(ID, Name);
			textConstant.Values.Set(Values);
			yield return textConstant;
		}

		protected override void AddItemToInputObject(TextConstant item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Hashtable Values { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTextEncodingVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TextEncodingVariable))]
	[Alias("TextEncodingVariable")]
	public class NewBreezeTextEncodingVariable : NewItemWithIDAndNameCmdlet<TextEncodingVariable, int, PSObject>
	{
		protected override IEnumerable<TextEncodingVariable> CreateItems()
		{
			var textEncodingVariable = new TextEncodingVariable(ID, Name);
			textEncodingVariable.Dimensions = Dimensions;
			yield return textEncodingVariable;
		}

		protected override void AddItemToInputObject(TextEncodingVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTextVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TextVariable))]
	[Alias("TextVariable")]
	public class NewBreezeTextVariable : NewItemWithIDAndNameCmdlet<TextVariable, int, PSObject>
	{
		protected override IEnumerable<TextVariable> CreateItems()
		{
			var textVariable = new TextVariable(ID, Name, DataLength);
			textVariable.Dimensions = Dimensions;
			textVariable.IncludeInDataset = IncludeInDataset;
			yield return textVariable;
		}

		protected override void AddItemToInputObject(TextVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter(Position=3, ParameterSetName="AddWithID")]
		[Parameter(Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Position=3, ParameterSetName="NewWithID")]
		[Parameter(Position=2, ParameterSetName="NewWithoutID")]
		public Nullable<Int32> DataLength { get; set; }

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter()]
		public Nullable<Boolean> IncludeInDataset { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTimeVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TimeVariable))]
	[Alias("TimeVariable")]
	public class NewBreezeTimeVariable : NewItemWithIDAndNameCmdlet<TimeVariable, int, PSObject>
	{
		protected override IEnumerable<TimeVariable> CreateItems()
		{
			var timeVariable = new TimeVariable(ID, Name);
			timeVariable.Dimensions = Dimensions;
			yield return timeVariable;
		}

		protected override void AddItemToInputObject(TimeVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeTransactionTypeVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(TransactionTypeVariable))]
	[Alias("TransactionTypeVariable")]
	public class NewBreezeTransactionTypeVariable : NewItemWithIDAndNameCmdlet<TransactionTypeVariable, int, PSObject>
	{
		protected override IEnumerable<TransactionTypeVariable> CreateItems()
		{
			var transactionTypeVariable = new TransactionTypeVariable(ID, Name);
			transactionTypeVariable.Dimensions = Dimensions;
			yield return transactionTypeVariable;
		}

		protected override void AddItemToInputObject(TransactionTypeVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeVariantVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(VariantVariable))]
	[Alias("VariantVariable")]
	public class NewBreezeVariantVariable : NewItemWithIDAndNameCmdlet<VariantVariable, int, PSObject>
	{
		protected override IEnumerable<VariantVariable> CreateItems()
		{
			var variantVariable = new VariantVariable(ID, Name);
			variantVariable.Dimensions = Dimensions;
			yield return variantVariable;
		}

		protected override void AddItemToInputObject(VariantVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

	}

	[Cmdlet(VerbsCommon.New, "CBreezeXmlPortVariable", DefaultParameterSetName="NewWithoutID")]
	[OutputType(typeof(XmlPortVariable))]
	[Alias("XmlPortVariable")]
	public class NewBreezeXmlPortVariable : NewItemWithIDAndNameCmdlet<XmlPortVariable, int, PSObject>
	{
		protected override IEnumerable<XmlPortVariable> CreateItems()
		{
			var xmlPortVariable = new XmlPortVariable(ID, Name, SubType);
			xmlPortVariable.Dimensions = Dimensions;
			yield return xmlPortVariable;
		}

		protected override void AddItemToInputObject(XmlPortVariable item, PSObject inputObject)
		{
			inputObject.GetVariables().Add(item);
		}

		[Parameter()]
		public String Dimensions { get; set; }

		[Parameter(Mandatory=true, Position=3, ParameterSetName="AddWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="AddWithoutID")]
		[Parameter(Mandatory=true, Position=3, ParameterSetName="NewWithID")]
		[Parameter(Mandatory=true, Position=2, ParameterSetName="NewWithoutID")]
		public Int32 SubType { get; set; }

	}

}

