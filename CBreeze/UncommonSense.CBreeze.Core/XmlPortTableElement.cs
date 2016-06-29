using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
        public class XmlPortTableElement : XmlPortNode
    {
        public XmlPortTableElement(Guid id, string nodeName, int? indentationLevel)
            : base(id, nodeName, indentationLevel)
        {
            Properties = new XmlPortTableElementProperties();
        }

        public override XmlPortNodeAndSourceType Type
        {
            get
            {
                return XmlPortNodeAndSourceType.XmlPortTableElement;
            }
        }

        public XmlPortTableElementProperties Properties
        {
            get;
            protected set;
        }

        public override Properties AllProperties
        {
            get
            {
                return Properties;
            }
        }
    }
}
