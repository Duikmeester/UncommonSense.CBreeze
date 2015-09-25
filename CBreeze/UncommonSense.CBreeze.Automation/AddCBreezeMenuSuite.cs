﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.Utils;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.Add, "CBreezeMenuSuite")]
    public class AddCBreezeMenuSuite : AddCBreezeObject
    {
        protected override System.Collections.IEnumerable AddedObjects
        {
            get
            {
                var menuSuite = Application.MenuSuites.Add(new MenuSuite(GetID(), Name));

                menuSuite.ObjectProperties.DateTime = DateTime;
                menuSuite.ObjectProperties.Modified = Modified;
                menuSuite.ObjectProperties.VersionList = VersionList;

                yield return menuSuite;
            }
        }

        protected override IEnumerable<int> GetExistingIDs()
        {
            return Application.MenuSuites.Select(m => m.ID);
        }
    }
}
