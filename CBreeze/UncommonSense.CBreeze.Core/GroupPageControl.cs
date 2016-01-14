using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
	[Serializable]
	public class GroupPageControl : PageControl
	{
		public GroupPageControl(int id, int? indentationLevel)
			: base(id, indentationLevel)
		{
			Properties = new GroupPageControlProperties();
		}

		public override PageControlType Type
		{
			get
			{
				return PageControlType.Group;
			}
		}

		public GroupPageControlProperties Properties
		{
			get;
			protected set;
		}

		public override Properties AllProperties
		{
			get
			{
				return Properties;
			}
		}

		public override string GetName()
		{
			return Properties.Name;
		}
	}
}
