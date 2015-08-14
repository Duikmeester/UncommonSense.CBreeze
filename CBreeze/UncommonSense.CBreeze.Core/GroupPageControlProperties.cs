using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class GroupPageControlProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private ActionListProperty actionList = new ActionListProperty("ActionList");
        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty description = new StringProperty("Description");
        private StringProperty editable = new StringProperty("Editable");
        private StringProperty enabled = new StringProperty("Enabled");
        private StringProperty freezeColumnID = new StringProperty("FreezeColumnID");
        private GroupTypeProperty groupType = new GroupTypeProperty("GroupType");
        private StringProperty indentationColumnName = new StringProperty("IndentationColumnName");
        private ControlListProperty indentationControls = new ControlListProperty("IndentationControls");
        private MultiLanguageProperty instructionalTextML = new MultiLanguageProperty("InstructionalTextML");
        private GroupPageControlLayoutProperty layout = new GroupPageControlLayoutProperty("Layout");
        private StringProperty name = new StringProperty("Name");
        private NullableBooleanProperty showAsTree = new NullableBooleanProperty("ShowAsTree");
        private StringProperty visible = new StringProperty("Visible");

        internal GroupPageControlProperties()
        {
            innerList.Add(name);
            innerList.Add(captionML);
            innerList.Add(description);
            innerList.Add(visible);
            innerList.Add(enabled);
            innerList.Add(editable);
            innerList.Add(indentationColumnName);
            innerList.Add(indentationControls);
            innerList.Add(showAsTree);
            innerList.Add(groupType);
            innerList.Add(instructionalTextML);
            innerList.Add(freezeColumnID);
            innerList.Add(layout);
            innerList.Add(actionList);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

        public ActionList ActionList
        {
            get
            {
                return this.actionList.Value;
            }
        }

        public MultiLanguageValue CaptionML
        {
            get
            {
                return this.captionML.Value;
            }
        }

      public System.String Description
        {
            get
            {
                return this.description.Value;
            }
            set
            {
                this.description.Value = value;
            }
        }

      public System.String Editable
        {
            get
            {
                return this.editable.Value;
            }
            set
            {
                this.editable.Value = value;
            }
        }

      public System.String Enabled
        {
            get
            {
                return this.enabled.Value;
            }
            set
            {
                this.enabled.Value = value;
            }
        }

      public System.String FreezeColumnID
        {
            get
            {
                return this.freezeColumnID.Value;
            }
            set
            {
                this.freezeColumnID.Value = value;
            }
        }

        public GroupType? GroupType
        {
            get
            {
                return this.groupType.Value;
            }
            set
            {
                this.groupType.Value = value;
            }
        }

      public System.String IndentationColumnName
        {
            get
            {
                return this.indentationColumnName.Value;
            }
            set
            {
                this.indentationColumnName.Value = value;
            }
        }

        public ControlList IndentationControls
        {
            get
            {
                return this.indentationControls.Value;
            }
        }

        public MultiLanguageValue InstructionalTextML
        {
            get
            {
                return this.instructionalTextML.Value;
            }
        }

        public GroupPageControlLayout? Layout
        {
            get
            {
                return this.layout.Value;
            }
            set
            {
                this.layout.Value = value;
            }
        }

      public System.String Name
        {
            get
            {
                return this.name.Value;
            }
            set
            {
                this.name.Value = value;
            }
        }

      public System.Boolean? ShowAsTree
        {
            get
            {
                return this.showAsTree.Value;
            }
            set
            {
                this.showAsTree.Value = value;
            }
        }

      public System.String Visible
        {
            get
            {
                return this.visible.Value;
            }
            set
            {
                this.visible.Value = value;
            }
        }

        public IEnumerator<Property> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

    }
}
