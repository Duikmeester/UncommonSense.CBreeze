﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CBreeze.NextGen
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var application = new Application();
			var table = application.Tables.Add(new Table(50000, "Customer Group"));
			table.ObjectProperties.DateTime = DateTime.Now;
			table.ObjectProperties.Modified = true;
			table.ObjectProperties.VersionList = "NAVJH1.00";

			table.Properties.CaptionML.Add("ENU", table.Name);
			table.Properties.DataPerCompany = false;
			table.Properties.LookupPageID = 50001;

			var codeField = table.Fields.Add(new CodeTableField(1, "Code", 10));
			codeField.Properties.CaptionML.Add("ENU", codeField.Name);
			codeField.Properties.CaptionML.Add("NLD", "Klantgroep");
			codeField.Properties.NotBlank = true;
			table.Properties.DataCaptionFields.Add(codeField.No);

			var integerField = table.Fields.Add(new IntegerTableField(10, "No. of Customers"));
			integerField.Properties.AltSearchField = "Field20";
			table.Properties.DataCaptionFields.Add(integerField.No);

			var function = table.Code.Functions.Add(new Function(1000, "MyFunction"));
			function.Local = true;

			var variable = function.Variables.Add(new RecordVariable(1000, "MyVariable", 14));
			variable.Temporary = true;

			var cardPage = application.Pages.Add(new Page(50000, "Customer Group Card"));
			cardPage.ObjectProperties.Modified = true;
			var containerControl = cardPage.Controls.Add(new ContainerPageControl(1));
			containerControl.Properties.CaptionML.Add("ENU", "Foo");
			var groupControl = cardPage.Controls.Add(new GroupPageControl(2));
			groupControl.Properties.CaptionML.Add("ENU", "Baz");

			var listPage = application.Pages.Add(new Page(50001, "Customer Group List"));
			listPage.ObjectProperties.Modified = true;

			var codeunit = application.Codeunits.Add(new Codeunit(50000, "Customer Group Mgt."));
			codeunit.Properties.TableNo = 50000;

			var export = application.XmlPorts.Add(new XmlPort(50000, "Export Customer Groups"));
			export.ObjectProperties.DateTime = DateTime.Now;

			PrintNode(application, 0);
		}

		private static void PrintNode(INode node, int indentation)
		{
			Console.Write(new String(' ', indentation * 2));
			Console.Write(node);

			if (node is Property)
			{
				Console.Write(" [{0}]", (node as Property).HasValue);
			}

			Console.WriteLine();

			foreach (var childNode in node.ChildNodes)
			{
				PrintNode(childNode, indentation + 1);
			}
		}
	}
}
