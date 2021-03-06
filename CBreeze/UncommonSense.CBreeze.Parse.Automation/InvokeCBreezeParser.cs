﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.Parse.Automation
{
#pragma warning disable CS1734
    /// <summary>
    /// <para type="synopsis">Parses a Microsoft Dynamics NAV text export and enumerates the objects and subobjects found.</para> 
    /// <para type="description">Uses the UncommonSense.CBreeze.Parser library to parse the objects in the file named <paramref name="LiteralPath">LiteralPath</paramref>. Provide scriptblock parameters to respond to the events that are triggered as (sub)objects are found.</para> 
    /// </summary>
#pragma warning restore CS1734
    [Cmdlet(VerbsLifecycle.Invoke, "CBreezeParser")]
    public partial class InvokeCBreezeParser : PSCmdlet
    {
        /// <Exclude/>
        protected Parser Parser
        {
            get;
            private set;
        }

        /// <Exclude/>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Parser = new Parser() { Listener = new Listener(this) };
        }

        /// <Exclude/>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            Parser.ParseFiles(LiteralPath.Select(p => GetUnresolvedProviderPathFromPSPath(p)));
        }
    }
}
