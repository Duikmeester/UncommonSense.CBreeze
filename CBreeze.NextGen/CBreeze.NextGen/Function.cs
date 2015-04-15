﻿using System;
using System.Collections.Generic;

namespace CBreeze.NextGen
{
	public class Function : Node, IKeyedValue<string>, IEquatable<Function>
	{
		public Function(int uid, string name)
		{
			UID = uid;
			Name = name;
			Parameters = new Parameters(this);
			Variables = new Variables(this);
		}

		public override string ToString()
		{
			return string.Format("{2}{0}@{1}", Name, UID, Local ? "LOCAL " : "");
		}

		public int UID
		{
			get;
			internal set;
		}

		public string Name
		{
			get;
			internal set;
		}

		public bool Local
		{
			get;
			set;
		}

		public Parameters Parameters
		{
			get;
			internal set;
		}

		public Variables Variables
		{
			get;
			internal set;
		}

		public override IEnumerable<INode> ChildNodes
		{
			get
			{
				yield return Parameters;
				yield return Variables;
			}
		}

		public string GetKey()
		{
			return Name;
		}

		public bool Equals(Function other)
		{
			if (other == null)
				return false;

			if (other.UID == UID)
				return true;

			if (other.Name == Name)
				return true;

			return false;
		}
	}
}

