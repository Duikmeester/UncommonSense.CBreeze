using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
	[Serializable]
	public abstract partial class Variable : KeyedItem<int>, IHasName
	{
		internal Variable(int id, string name)
		{
			ID = id;
			Name = name;
		}

		public abstract VariableType Type
		{
			get;
		}

		public string Name
		{
			get;
			protected set;
		}

		public string GetName()
		{
			return Name;
		}
	}
}
