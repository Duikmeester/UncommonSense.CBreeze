﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncommonSense.CBreeze.ObjectModelBuilder;

namespace UncommonSense.CBreeze
{
    public static partial class ExtensionMethods
    {
        public static UncommonSense.CBreeze.ObjectModelBuilder.Attribute AddAttribute(this Item item, string typeName, string name = null)
        {
            // FIXME: Now that we have ChildNode and Identifier, should we make Attribute abstract?
            var attribute = new UncommonSense.CBreeze.ObjectModelBuilder.Attribute(typeName, name ?? typeName);
            return item.Attributes.Add(attribute);
        }
    }
}
