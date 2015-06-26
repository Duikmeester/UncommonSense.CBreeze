﻿using System;
using System.Collections.Generic;

namespace CBreeze.NextGen
{
	public class CodeunitProperties : Properties
	{
		private NullableValueProperty<int> tableNo = new NullableValueProperty<int>("TableNo");

		internal CodeunitProperties(Node parentNode)
			: base(parentNode)
		{
		}

		public int? TableNo
		{
			get
			{
				return this.tableNo.Value;
			}set
			{
				this.tableNo.Value = value;
			}
		}

		public override IEnumerable<INode> ChildNodes
		{
			get
			{
				yield return this.tableNo;
			}
		}
	}
}

