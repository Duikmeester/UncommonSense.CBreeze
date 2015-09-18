﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Utils
{
    public enum Position
    {
        FirstWithinContainer,
        LastWithinContainer
    }

    public static class PageControlExtensionMethods
    {
        /// <summary>
        /// Returns an IEnumerable of PageControls indented exactly one level relative to <paramref name="parent"/>.
        /// </summary>
        public static IEnumerable<PageControl> GetChildPageControls(this PageControl parent)
        {
            return parent.GetDescendantPageControls().Where(c => c.IndentationLevel == parent.IndentationLevel + 1);
        }

        public static IEnumerable<PageActionBase> GetChildPageActions(this PageActionBase parent)
        {
            return parent.GetDescendantPageActions().Where(a => a.IndentationLevel == parent.IndentationLevel + 1);
        }

        public static IEnumerable<PageControl> GetDescendantPageControls(this PageControl parent)
        {
            var controls = parent.Container;

            return controls.
                Skip(parent.Index() + 1).
                TakeWhile(c => c.IndentationLevel > parent.IndentationLevel);
        }

        public static IEnumerable<PageActionBase> GetDescendantPageActions(this PageActionBase parent)
        {
            var actions = parent.Container;

            return actions.
                Skip(parent.Index() + 1).
                TakeWhile(a => a.IndentationLevel > parent.IndentationLevel);
        }

        /// <summary>
        /// Returns the index of PageControl <paramref name="pageControl"/> within the PageControls collection.
        /// </summary>
        public static int Index(this PageControl pageControl)
        {
            return pageControl.Container.IndexOf(pageControl);
        }

        public static int Index(this PageActionBase pageAction)
        {
            return pageAction.Container.IndexOf(pageAction);
        }

        /// <summary>
        /// Inserts PageControl <paramref name="child"/> directly after PageControl <paramref name="parent"/>.
        /// </summary>
        public static T AddChildPageControl<T>(this PageControl parent, T child, Position position) where T : PageControl
        {
            var controls = parent.Container;

            switch (position)
            {
                case Position.FirstWithinContainer:
                    controls.Insert(parent.Index() + 1, child);
                    break;
                case Position.LastWithinContainer:
                    var childControls = parent.GetDescendantPageControls();
                    var lastIndex = childControls.Any() ? childControls.Last().Index() : parent.Index();
                    controls.Insert(lastIndex + 1, child);
                    break;
            }

            return child;
        }

        // FIXME: Use this method in more places, instead of AddChildPageControl<T>
        public static FieldPageControl AddFieldPageControl(this PageControl parent, int id, Position position, string sourceExpr)
        {
            var childPageControl = AddChildPageControl(parent, new FieldPageControl(id, parent.IndentationLevel + 1), position);
            childPageControl.Properties.SourceExpr = sourceExpr.Quoted();
            return childPageControl;
        }

        public static PartPageControl AddSystemPartPageControl(this PageControl parent, int id, Position position, SystemPartID systemPartID, bool hide = true )
        {
            var partPageControl = AddChildPageControl(parent, new PartPageControl(id, parent.IndentationLevel + 1), position);
            partPageControl.Properties.PartType = PartType.System;
            partPageControl.Properties.SystemPartID = systemPartID;

            if (hide)
            {
                partPageControl.Properties.Visible = false.ToString();
            }

            return partPageControl;
        }

        private static GroupPageControl GetGroupByCaption(this ContainerPageControl container, string caption)
        {
            return container.GetChildPageControls().OfType<GroupPageControl>().FirstOrDefault(c => c.Properties.CaptionML["ENU"] == caption);
        }

        public static GroupPageControl GetGroupByCaption(this ContainerPageControl container, string caption, IEnumerable<int> range, Position position)
        {
            var groupPageControl = container.GetGroupByCaption(caption);

            if (groupPageControl == null)
            {
                groupPageControl = new GroupPageControl(range.GetNextPageControlID(container.Container.Page), 1);
                groupPageControl.Properties.CaptionML.Set("ENU", caption);
                container.AddChildPageControl(groupPageControl, position);
            }

            return groupPageControl;
        }

        private static GroupPageControl GetGroupByType(this ContainerPageControl container, GroupType type)
        {
            return container.GetChildPageControls().OfType<GroupPageControl>().FirstOrDefault(g => g.Properties.GroupType == type);
        }

        public static GroupPageControl GetGroupByType(this ContainerPageControl container, GroupType type, IEnumerable<int> range, Position position)
        {
            var groupPageControl = container.GetGroupByType(type);

            if (groupPageControl == null)
            {
                groupPageControl = new GroupPageControl(range.GetNextPageControlID(container.Container.Page), 1);
                groupPageControl.Properties.GroupType = type;
                container.AddChildPageControl(groupPageControl, position);
            }

            return groupPageControl;
        }

        private static PageActionGroup GetGroupByCaption(this PageActionContainer container, string caption)
        {
            return container.GetChildPageActions().OfType<PageActionGroup>().FirstOrDefault(a => a.Properties.CaptionML["ENU"] == caption);
        }

        public static PageActionGroup GetGroupByCaption(this PageActionContainer container, Page page, string caption, IEnumerable<int> range, Position position)
        {
            var pageActionGroup = container.GetGroupByCaption(caption);

            if (pageActionGroup == null)
            {
                pageActionGroup = new PageActionGroup(range.GetNextPageControlID(page), 1);
                pageActionGroup.Properties.CaptionML.Set("ENU", caption);
                // FIXME: container.AddChildAction(pageActionGroup, position);
            }

            return pageActionGroup;
        }
    }
}
