﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Core
{
    public static class IPageExtensionMethods
    {
        public static PageActionContainer GetPageActionContainer(this IPage page, IEnumerable<int> range, ActionContainerType type)
        {
            var result = page.Actions.OfType<PageActionContainer>().FirstOrDefault(c => c.Properties.ActionContainerType == type) ?? page.Actions.Insert(0, new PageActionContainer(range.GetNextPageControlID(page), 0));
            result.Properties.ActionContainerType = type;
            return result;
        }

        public static ContainerPageControl GetPageControlContainer(this IPage page, IEnumerable<int> range, ContainerType type)
        {
            var result = page.Controls.OfType<ContainerPageControl>().FirstOrDefault(c => c.Properties.ContainerType == type) ?? page.Controls.Insert(0, new ContainerPageControl(range.GetNextPageControlID(page), 0));
            result.Properties.ContainerType = type;
            return result;
        }
    }
}