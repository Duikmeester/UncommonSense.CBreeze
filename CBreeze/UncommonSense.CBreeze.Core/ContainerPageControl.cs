using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UncommonSense.CBreeze.Common;

namespace UncommonSense.CBreeze.Core
{
    public class ContainerPageControl : PageControl
    {
        public ContainerPageControl(int id, int? indentationLevel, ContainerType containerType) : this(id, indentationLevel)
        {
            Properties.ContainerType = containerType;
        }

        public ContainerPageControl(int id, int? indentationLevel)
            : base(id, indentationLevel)
        {
            Properties = new ContainerPageControlProperties(this);
        }

        public override IEnumerable<INode> ChildNodes
        {
            get
            {
                yield return Properties;
            }
        }

        public override PageControlType Type
        {
            get
            {
                return PageControlType.Container;
            }
        }

        public ContainerPageControlProperties Properties
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

        public GroupPageControl GetGroupByCaption(string caption, IEnumerable<int> range, Position position)
        {
            var groupPageControl = ChildPageControls.OfType<GroupPageControl>().FirstOrDefault(c => c.Properties.CaptionML["ENU"] == caption);

            if (groupPageControl == null)
            {
                groupPageControl = new GroupPageControl(range.GetNextPageControlOrActionID(Container.Page), 1);
                groupPageControl.Properties.CaptionML.Set("ENU", caption);
                this.AddChildPageControl(groupPageControl, position);
            }

            return groupPageControl;
        }

        public GroupPageControl GetGroupByType(GroupType type, IEnumerable<int> range, Position position)
        {
            var groupPageControl = ChildPageControls.OfType<GroupPageControl>().FirstOrDefault(g => g.Properties.GroupType == type);

            if (groupPageControl == null)
            {
                groupPageControl = new GroupPageControl(range.GetNextPageControlOrActionID(Container.Page), 1);
                groupPageControl.Properties.GroupType = type;
                AddChildPageControl(groupPageControl, position);
            }

            return groupPageControl;
        }
    }
}
