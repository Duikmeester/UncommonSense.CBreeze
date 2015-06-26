﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBreeze.NextGen
{
	public class TableKeyProperties : Properties
	{
		private NullableValueProperty<bool> clustered = new NullableValueProperty<bool>("Clustered");

		internal TableKeyProperties(Node parentNode)
			: base(parentNode)
		{

		}

		public bool? Clustered
		{
			get
			{
				return this.clustered.Value;
			}
			set
			{
				this.clustered.Value = value;
			}
		}

		public override IEnumerable<INode> ChildNodes
		{
			get
			{
				yield return clustered;
			}
		}
	}
}
