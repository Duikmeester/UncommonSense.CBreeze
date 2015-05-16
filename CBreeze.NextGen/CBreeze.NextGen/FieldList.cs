﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace CBreeze.NextGen
{
	public class FieldList : List<int>
	{
        public FieldList()
        {
        }

        public FieldList(params int[] fieldNos)
        {
            this.AddRange(fieldNos);
        }

		public override string ToString()
		{
			return string.Join(",", this.Select(f => f.ToString()));
		}
	}
}

