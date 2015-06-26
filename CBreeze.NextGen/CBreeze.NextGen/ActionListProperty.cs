﻿using System;
using System.Linq;

namespace CBreeze.NextGen
{
	public class ActionListProperty : ReferenceProperty<ActionList>
	{
		public ActionListProperty(string name)
			: base(name)
		{
		}

		public new Node ParentNode
		{
			get
			{
				return Value.ParentNode;
			}
			set
			{
				Value.ParentNode = value;
			}
		}

		public override bool HasValue
		{
			get
			{
				return Value.Any();
			}
		}

		public override System.Collections.Generic.IEnumerable<INode> ChildNodes
		{
			get
			{
				return Value.ChildNodes;
			}
		}
	}
}

