// --------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
//
//      Changes to this file may cause incorrect behaviour and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
    [Serializable]
    public partial class MultiLanguageEntry
    {
        private String languageID;
        private String value;

        internal MultiLanguageEntry(String languageID, String value)
        {
            this.languageID = languageID;
            this.value = value;
        }

        public String LanguageID
        {
            get
            {
                return this.languageID;
            }
        }

        public String Value
        {
            get
            {
                return this.value;
            }
        }

    }
}