﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.DomBuilder
{
    public abstract class PropertyType : ObjectModelElement
    {
        public PropertyType(string name)
            : base(name)
        {
        }
    }
}
