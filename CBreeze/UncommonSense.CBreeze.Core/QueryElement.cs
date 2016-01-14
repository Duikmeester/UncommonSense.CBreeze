using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
	[Serializable]
	public abstract partial class QueryElement : KeyedItem<int>, IHasName, IHasProperties
	{
		public QueryElement(int id, string name, int? indentationLevel)
		{
			ID = id;
			IndentationLevel = indentationLevel;
			Name = name;
		}

		public abstract QueryElementType Type
		{
			get;
		}

		public string Name
		{
			get;
			protected set;
		}

		public int? IndentationLevel
		{
			get;
			protected set;
		}

		public QueryElements Container
		{
			get;
			internal set;
		}

		public string GetName()
		{
			return Name;
		}

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

		public IEnumerable<QueryElement> DescendantElements
		{
			get
			{
				return Container.Skip(Index + 1).TakeWhile(e => e.IndentationLevel.GetValueOrDefault(0) > IndentationLevel.GetValueOrDefault(0));
			}
		}

		public T AddChildNode<T>(T child, Position position) where T : QueryElement
		{
			switch (position)
			{
				case Position.FirstWithinContainer:
					Container.Insert(Index + 1, child);
					break;
				case Position.LastWithinContainer:
					var descendantElements = DescendantElements;
					var lastIndex = descendantElements.Any() ? descendantElements.Last().Index : Index;
					Container.Insert(lastIndex + 1, child);
					break;
			}

			return child;
		}
	}
}
