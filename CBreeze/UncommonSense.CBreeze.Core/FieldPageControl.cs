using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
	[Serializable]
	public partial class FieldPageControl : PageControl
	{
		public FieldPageControl(int id, int? indentationLevel)
			: base(id, indentationLevel)
		{
			Properties = new FieldPageControlProperties();
		}

		public override PageControlType Type
		{
			get
			{
				return PageControlType.Field;
			}
		}

		public FieldPageControlProperties Properties
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
