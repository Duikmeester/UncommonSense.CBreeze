﻿using System;

namespace CBreeze.NextGen
{
    public class Pages : Container<int, Page>
    {
        internal Pages(Node parentNode)
            : base(parentNode)
        {
        }

        public override string ToString()
        {
            return "Pages";
        }
    }
}

