using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UncommonSense.CBreeze.Core
{
        public class ReportRequestPage : IPage
    {
        internal ReportRequestPage(Report report)
        {
            Report = report;

            Properties = new ReportRequestPageProperties();
            Properties.ActionList.Page = this;

            Controls = new PageControls(this);
        }

        public PageControls Controls
        {
            get;
            protected set;
        }

        public ReportRequestPageProperties Properties
        {
            get;
            protected set;
        }

        public Report Report
        {
            get;
            protected set;
        }


        public ActionList Actions
        {
            get
            {
                return Properties.ActionList;
            }
        }

        public int ObjectID
        {
            get
            {
                return Report.ID;
            }
        }
    }
}
