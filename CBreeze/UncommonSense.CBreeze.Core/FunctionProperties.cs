using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class FunctionProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private FunctionTypeProperty functionType = new FunctionTypeProperty("FunctionType");
        private StringProperty handlerFunctions = new StringProperty("HandlerFunctions");
        private NullableBooleanProperty local = new NullableBooleanProperty("Local");
        private TransactionModelProperty transactionModel = new TransactionModelProperty("TransactionModel");

        internal FunctionProperties()
        {
            innerList.Add(functionType);
            innerList.Add(handlerFunctions);
            innerList.Add(local);
            innerList.Add(transactionModel);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

        public FunctionType? FunctionType
        {
            get
            {
                return this.functionType.Value;
            }
            set
            {
                this.functionType.Value = value;
            }
        }

      public System.String HandlerFunctions
        {
            get
            {
                return this.handlerFunctions.Value;
            }
            set
            {
                this.handlerFunctions.Value = value;
            }
        }

      public System.Boolean? Local
        {
            get
            {
                return this.local.Value;
            }
            set
            {
                this.local.Value = value;
            }
        }

        public TransactionModel? TransactionModel
        {
            get
            {
                return this.transactionModel.Value;
            }
            set
            {
                this.transactionModel.Value = value;
            }
        }

        public IEnumerator<Property> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

    }
}
