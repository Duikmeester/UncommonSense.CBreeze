using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
	[Serializable]
	public abstract partial class MenuSuiteNode : KeyedItem<Guid>, IHasName, IHasProperties
	{
		internal MenuSuiteNode(Guid id)
		{
			ID = id;
		}

		public abstract MenuSuiteNodeType Type
		{
			get;
		}

		public MenuSuiteNodes Container
		{
			get;
			internal set;
		}

		public abstract string GetName();

		public abstract Properties AllProperties
		{
			get;
		}

		public int Index
		{
			get
			{
				return Container.IndexOf(this);
			}
		}
	}
}
