﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.New, "CBreezeReport", DefaultParameterSetName = ParameterSetNames.NewWithoutID)]
    [OutputType(typeof(Report))]
    [Alias("Report")]
    public class NewCBreezeReport : NewCBreezeObject<Report>
    {
#if NAV2015
        [Parameter()] public DefaultLayout? DefaultLayout { get; set; }
#endif

        [Parameter()] public string Description { get; set; }
        [Parameter()] public SwitchParameter EnableExternalAssemblies { get; set; }
        [Parameter()] public SwitchParameter EnableExternalImages { get; set; }
        [Parameter()] public SwitchParameter EnableHyperlinks { get; set; }
        [Parameter()] public PaperSource? PaperSourceDefaultPage { get; set; }
        [Parameter()] public PaperSource? PaperSourceFirstPage { get; set; }
        [Parameter()] public PaperSource? PaperSourceLastPage { get; set; }
        [Parameter()] public Permission[] Permissions { get; set; }
#if NAV2015
        [Parameter()] public PreviewMode? PreviewMode { get; set; }
#endif
        [Parameter()] public SwitchParameter ProcessingOnly { get; set; } 
        [Parameter()] public SwitchParameter ShowPrintStatus { get; set; } 
        [Parameter()] public TransactionType? TransactionType { get; set; } 
        [Parameter()] public SwitchParameter UseRequestPage { get; set; } 
        [Parameter()] public SwitchParameter UseSystemPrinter { get; set; } 
#if NAV2015
        [Parameter()] public string WordMergeDataItem { get; set; } 
#endif

        protected override void AddItemToInputObject(Report item, Application inputObject)
        {
            inputObject.Reports.Add(item);
        }

        protected override IEnumerable<Report> CreateItems()
        {
            var report = new Report(ID, Name);
            SetObjectProperties(report);

#if NAV2015
            report.Properties.DefaultLayout = DefaultLayout;
#endif
            report.Properties.Description = Description;
            report.Properties.EnableExternalAssemblies = InterpretSwitch(nameof(EnableExternalAssemblies));
            report.Properties.EnableExternalImages = InterpretSwitch(nameof(EnableExternalImages));
            report.Properties.EnableHyperlinks = InterpretSwitch(nameof(EnableHyperlinks));
            report.Properties.PaperSourceDefaultPage = PaperSourceDefaultPage;
            report.Properties.PaperSourceFirstPage = PaperSourceFirstPage;
            report.Properties.PaperSourceLastPage = PaperSourceLastPage;
            report.Properties.Permissions.Set(Permissions);
#if NAV2015
            report.Properties.PreviewMode = PreviewMode;
#endif
            report.Properties.ProcessingOnly = InterpretSwitch(nameof(ProcessingOnly));
            report.Properties.ShowPrintStatus = InterpretSwitch(nameof(ShowPrintStatus));
            report.Properties.TransactionType = TransactionType;
            report.Properties.UseRequestPage = InterpretSwitch(nameof(UseRequestPage));
            report.Properties.UseSystemPrinter = InterpretSwitch(nameof(UseSystemPrinter));
#if NAV2015
            report.Properties.WordMergeDataItem = WordMergeDataItem;
#endif

            if (AutoCaption)
                report.AutoCaption();

            if (SubObjects != null)
            {
                // FIXME: How to define the request page?

                var subObjects = SubObjects.Invoke().Select(o => o.BaseObject);
                report.Code.Documentation.CodeLines.AddRange(subObjects.OfType<string>());
                report.Labels.AddRange(subObjects.OfType<ReportLabel>());
                report.Elements.AddRange(subObjects.OfType<ReportElement>());
                report.Code.Functions.AddRange(subObjects.OfType<Function>());
                report.Code.Variables.AddRange(subObjects.OfType<Variable>());
                report.Code.Events.AddRange(subObjects.OfType<Event>());
            }

            yield return report;
        }
    }
}