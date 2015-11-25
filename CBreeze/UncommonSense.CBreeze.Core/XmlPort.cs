// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class XmlPort : Object, IHasCode
    {
        public XmlPort(Int32 id, String name)
            : base(id, name)
        {
            Properties = new XmlPortProperties();
            Nodes = new XmlPortNodes();
            RequestPage = new XmlPortRequestPage(this);
            Code = new Code();
        }

        public override ObjectType Type
        {
            get
            {
                return ObjectType.XmlPort;
            }
        }

        public XmlPortProperties Properties
        {
            get;
            protected set;
        }

        public XmlPortNodes Nodes
        {
            get;
            protected set;
        }

        public XmlPortRequestPage RequestPage
        {
            get;
            protected set;
        }

        public Code Code
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
