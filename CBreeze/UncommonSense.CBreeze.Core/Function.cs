using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class Function
    {
        private Int32 id;
        private String name;
        private CodeLines codeLines = new CodeLines();
        private Parameters parameters = new Parameters();
        private FunctionProperties properties = new FunctionProperties();
        private FunctionReturnValue returnValue = new FunctionReturnValue();
        private Variables variables = new Variables();

        internal Function(Int32 id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public Int32 ID
        {
            get
            {
                return this.id;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }

        public CodeLines CodeLines
        {
            get
            {
                return this.codeLines;
            }
        }

        public Parameters Parameters
        {
            get
            {
                return this.parameters;
            }
        }

        public FunctionProperties Properties
        {
            get
            {
                return this.properties;
            }
        }

        public FunctionReturnValue ReturnValue
        {
            get
            {
                return this.returnValue;
            }
        }

        public Variables Variables
        {
            get
            {
                return this.variables;
            }
        }

    }
}
