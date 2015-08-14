using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public class PageActionGroupProperties : IEnumerable<Property>
    {
        private List<Property> innerList = new List<Property>();

        private ActionContainerTypeProperty actionContainerType = new ActionContainerTypeProperty("ActionContainerType");
        private MultiLanguageProperty captionML = new MultiLanguageProperty("CaptionML");
        private StringProperty description = new StringProperty("Description");
        private StringProperty enabled = new StringProperty("Enabled");
        private StringProperty image = new StringProperty("Image");
        private StringProperty name = new StringProperty("Name");
        private StringProperty visible = new StringProperty("Visible");

        internal PageActionGroupProperties()
        {
            innerList.Add(name);
            innerList.Add(captionML);
            innerList.Add(description);
            innerList.Add(visible);
            innerList.Add(enabled);
            innerList.Add(actionContainerType);
            innerList.Add(image);
        }

        public Property this[string name]
        {
            get
            {
                return innerList.FirstOrDefault(p => p.Name == name);
            }
        }

        public ActionContainerType? ActionContainerType
        {
            get
            {
                return this.actionContainerType.Value;
            }
            set
            {
                this.actionContainerType.Value = value;
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

      public System.String Image
        {
            get
            {
                return this.image.Value;
            }
            set
            {
                this.image.Value = value;
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
