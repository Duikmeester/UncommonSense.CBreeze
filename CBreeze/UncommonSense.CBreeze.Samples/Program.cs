﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.Read;
using UncommonSense.CBreeze.Utils;
using UncommonSense.CBreeze.Write;

namespace UncommonSense.CBreeze.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            CBreezeWriteDemo(@"c:\users\jhoek\desktop\sample.txt");
            //CBreezeReaderDemo(@"c:\users\jhoek\desktop\sample.txt", @"c:\users\jhoek\desktop\sample.txt");
        }

        static void CBreezeWriteDemo(string outputFileName)
        {
            var application = new Application();
            var table = application.Tables.Add(new Table(50000, "Demo"));
            table.ObjectProperties.DateTime = DateTime.Now;
            table.ObjectProperties.Modified = true;

            var codeField = table.Fields.Add(new CodeTableField(1, "Code", 11)).AutoCaption();
            codeField.Properties.NotBlank = true;

            var descriptionField = table.Fields.Add(new TextTableField(0, "Description", 35)).AutoCaption();

            table.Properties.PasteIsValid = true;
            table.Properties.Permissions.Set(50000, true, false, false, false);
            table.Properties.OnInsert.Variables.Add(new IntegerVariable(1000, "Foo"));
            table.Properties.OnInsert.Variables.Add(new RecordVariable(0, "Baz", BaseApp.TableIDs.Customer));
            table.Properties.DataCaptionFields.AddRange(codeField.Name, descriptionField.Name);

            table.AddAddressFields();

            var page = application.Pages.Add(new Page(50000, "Demo"));
            page.Controls.Add(new ContainerPageControl(0, 0)).Properties.ContainerType = ContainerType.ContentArea;
            page.Controls.Add(new GroupPageControl(0, 1)).Properties.GroupType = GroupType.Group;
            page.Controls.Add(new FieldPageControl(0, 2)).Properties.SourceExpr = "Foo";
            page.Controls.Insert(2, new FieldPageControl(0, 2)).Properties.SourceExpr = "First";

            var xmlport = application.XmlPorts.Add(new XmlPort(50000, "Demo"));
            xmlport.Nodes.Add(new XmlPortTextElement(Guid.Empty, "Foo", 0));
            xmlport.Nodes.Add(new XmlPortTextElement(Guid.Empty, "Baz", 1));

            application.Write(outputFileName);
        }

        static void CBreezeReaderDemo(string inputFileName, string outputFileName)
        {
            var application = ApplicationBuilder.FromFile(inputFileName);

            foreach (var table in application.Tables)
            {
                table.Properties.CaptionML["ENU"] = table.Name;
                table.Properties.CaptionML["NLD"] = table.Name.ToUpperInvariant();
                table.Properties.CaptionML["ENU"] = null;

                foreach (var field in table.Fields)
                {
                    field.AllProperties.ByName<MultiLanguageProperty>("CaptionML").Value["ENU"] = field.Name;
                    field.AllProperties.ByName<MultiLanguageProperty>("CaptionML").Value["NLD"] = field.Name.ToUpperInvariant();
                }
            }

            application.Write(outputFileName);
        }
    }
}
