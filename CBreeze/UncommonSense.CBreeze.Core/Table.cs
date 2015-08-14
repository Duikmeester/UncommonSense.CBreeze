using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class Table : Object
    {
        private TableFields fields = new TableFields();
        private TableProperties properties = new TableProperties();
        private TableFieldGroups fieldGroups = new TableFieldGroups();
        private TableKeys keys = new TableKeys();
        private Code code = new Code();

        internal Table(Int32 id, String name) : base(id, name)
        {
        }

        public override ObjectType Type
        {
            get
            {
                return ObjectType.Table;
            }
        }

        public TableFields Fields
        {
            get
            {
                return this.fields;
            }
        }

        public TableProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

        public TableFieldGroups FieldGroups
        {
            get
            {
                return this.fieldGroups;
            }
        }

        public TableKeys Keys
        {
            get
            {
                return this.keys;
            }
        }

        public Code Code
        {
            get
            {
                return this.code;
            }
        }

    }
}
