﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncommonSense.CBreeze.ObjectModelBuilder
{
	public abstract class Attribute
	{
		public Attribute(string typeName, string name)
		{
			TypeName = typeName;
			Name = name;
		}

		public string Name
		{
			get;
			internal set;
		}

        public string ParameterName
        {
            get
            {
                if (Name == "ID")
                    return "id";

                return Name.Substring(0, 1).ToLowerInvariant() + Name.Substring(1);
            }        
        }

		public string TypeName
		{
			get;
			internal set;
		}

		public bool IsChildNode
		{
			get;
			set;
		}

		public ObjectModelElement Type
		{
			get
			{
				return Item.ObjectModel.Elements.FirstOrDefault(e => e.Name == TypeName);
			}
		}

		public Item Item
		{
			get;
			internal set;
		}
	}
}
