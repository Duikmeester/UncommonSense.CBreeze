﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.New, "CBreezePageAction", DefaultParameterSetName = ParameterSetNames.NewWithoutID)]
    [OutputType(typeof(PageAction))]
    [Alias("Action")]
    public class NewCBreezePageAction : NewItemWithIDCmdlet<PageAction, int, PSObject>
    {
#if NAV2015
        [Parameter()]
        public AccessByPermission AccessByPermission
        {
            get; set;
        }
#endif

#if NAV2017
        [Parameter()]
        public string[] ApplicationArea { get; set; }
#endif

        [Parameter(Position = 1, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 1, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithID)]
        public Hashtable CaptionML
        {
            get; set;
        }

        [Parameter()]
        public string Description
        {
            get; set;
        }

        [Parameter()]
        public bool? Ellipsis
        {
            get; set;
        }

        [Parameter()]
        public string Enabled
        {
            get; set;
        }

        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.NewWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.NewWithID)]
        [Parameter(Position = 2, ParameterSetName = ParameterSetNames.AddWithoutID)]
        [Parameter(Position = 3, ParameterSetName = ParameterSetNames.AddWithID)]
        public string Image
        {
            get; set;
        }

        [Parameter()]
        public bool? InFooterBar
        {
            get; set;
        }

        [Parameter()]
        public string Name
        {
            get; set;
        }

        [Parameter()]
        public Position? Position
        {
            get;
            set;
        }

        [Parameter()]
        public bool? Promoted
        {
            get; set;
        }

        [Parameter()]
        public PromotedCategory? PromotedCategory
        {
            get; set;
        }

        [Parameter()]
        public bool? PromotedIsBig
        {
            get; set;
        }

        [Parameter()]
        public bool? PromotedOnly
        {
            get; set;
        }

        [Parameter()]
        public RunObjectType? RunObjectType
        {
            get; set;
        }

        [Parameter()]
        public int? RunObjectID
        {
            get; set;
        }

        [Parameter()]
        public RunPageMode? RunPageMode
        {
            get; set;
        }

        [Parameter()]
        public bool? RunPageOnRec
        {
            get; set;
        }

        [Parameter()]
        public string RunPageViewKey
        {
            get; set;
        }

        [Parameter()]
        public Order? RunPageViewOrder
        {
            get; set;
        }

#if NAV2015

        [Parameter()]
        public PageActionScope? Scope
        {
            get; set;
        }

#endif

        [Parameter()]
        public string ShortcutKey
        {
            get; set;
        }

        [Parameter()]
        public Hashtable ToolTipML { get; set; }

        [Parameter()]
        public string Visible
        {
            get; set;
        }

        [Parameter()]
        public ScriptBlock SubObjects { get; set; }

        protected override IEnumerable<PageAction> CreateItems()
        {
            var pageAction = new PageAction(ID, GetIndentation());
#if NAV2015
            pageAction.Properties.AccessByPermission.Set(AccessByPermission);
#endif
#if NAV2017
            pageAction.Properties.ApplicationArea.Set(ApplicationArea);
#endif
            pageAction.Properties.CaptionML.Set(CaptionML);
            pageAction.Properties.Description = Description;
            pageAction.Properties.Ellipsis = Ellipsis;
            pageAction.Properties.Enabled = Enabled;
            pageAction.Properties.Image = Image;
            pageAction.Properties.InFooterBar = InFooterBar;
            pageAction.Properties.Name = Name;
            pageAction.Properties.Promoted = Promoted;
            pageAction.Properties.PromotedCategory = PromotedCategory;
            pageAction.Properties.PromotedIsBig = PromotedIsBig;
#if NAV2017
            pageAction.Properties.PromotedOnly = PromotedOnly;
#endif
            pageAction.Properties.RunObject.Type = RunObjectType;
            pageAction.Properties.RunObject.ID = RunObjectID;
            pageAction.Properties.RunPageMode = RunPageMode;
            pageAction.Properties.RunPageOnRec = RunPageOnRec;
            pageAction.Properties.RunPageView.Key = RunPageViewKey;
            pageAction.Properties.RunPageView.Order = RunPageViewOrder;
#if NAV2015
            pageAction.Properties.Scope = Scope;
#endif
            pageAction.Properties.ShortCutKey = ShortcutKey;
            pageAction.Properties.ToolTipML.Set(ToolTipML);
            pageAction.Properties.Visible = Visible;

            pageAction.Properties.RunPageView.TableFilter.AddRange(
                SubObjects?
                    .Invoke()
                    .Select(o => o.BaseObject)
                    .Cast<TableFilterLine>()
                    ?? Enumerable.Empty<TableFilterLine>()
                );

            yield return pageAction;
        }

        protected override void AddItemToInputObject(PageAction item, PSObject inputObject)
        {
            var position = Position.GetValueOrDefault(Core.Position.LastWithinContainer);

            switch (InputObject.BaseObject)
            {
                case PageActionContainer c:
                    c.AddChildPageAction(item, position);
                    break;

                case PageActionGroup g:
                    g.AddChildPageAction(item, position);
                    break;

                case ActionList a:
                    a.AddPageActionAtPosition(item, position);
                    break;

                case IPage p:
                    p.AddPageActionAtPosition(item, position);
                    break;

                default:
                    base.AddItemToInputObject(item, inputObject);
                    break;
            }
        }

        protected int GetIndentation()
        {
            return ParameterSetNames.IsNew(ParameterSetName)
                ? (int)GetVariableValue("Indentation", 0)
                : GetParentIndentationLevel() + 1;
        }

        protected int GetParentIndentationLevel()
        {
            switch (InputObject.BaseObject)
            {
                case PageActionContainer c:
                    return c.IndentationLevel.GetValueOrDefault(0);
                case PageActionGroup g:
                    return g.IndentationLevel.GetValueOrDefault(0);
                default:
                    return 0;
            }
        }
    }
}