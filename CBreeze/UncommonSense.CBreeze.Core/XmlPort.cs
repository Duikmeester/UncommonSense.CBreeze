using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class XmlPort : Object
    {
        private Code code = new Code();
        private XmlPortNodes nodes = new XmlPortNodes();
        private XmlPortProperties properties = new XmlPortProperties();
        private XmlPortRequestPage requestPage = new XmlPortRequestPage();

        internal XmlPort(Int32 id, String name) : base(id, name)
        {
        }

        public override ObjectType Type
        {
            get
            {
                return ObjectType.XmlPort;
            }
        }

        public Code Code
        {
            get
            {
                return this.code;
            }
        }

        public XmlPortNodes Nodes
        {
            get
            {
                return this.nodes;
            }
        }

        public XmlPortProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

        public XmlPortRequestPage RequestPage
        {
            get
            {
                return this.requestPage;
            }
        }

    }
}
