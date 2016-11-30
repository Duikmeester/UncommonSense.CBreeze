﻿using System;
using System.Management.Automation;
using UncommonSense.CBreeze.Core;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsCommon.New, "CBreezeXmlPort")]
    public class NewCBreezeXmlPort : NewCBreezeObject
    {
        [Parameter()]
        public bool? DefaultFieldsValidation
        {
            get;
            set;
        }

        [Parameter()]
        public string DefaultNamespace
        {
            get;
            set;
        }

        [Parameter()]
        public Direction? Direction
        {
            get;
            set;
        }

        [Parameter()]
        public XmlPortEncoding? Encoding
        {
            get;
            set;
        }

        [Parameter()]
        public string FieldDelimiter
        {
            get;
            set;
        }

        [Parameter()]
        public string FieldSeparator
        {
            get;
            set;
        }

        [Parameter()]
        public string FileName
        {
            get;
            set;
        }

        [Parameter()]
        public XmlPortFormat? Format
        {
            get;
            set;
        }

        [Parameter()]
        public FormatEvaluate? FormatEvaluate
        {
            get;
            set;
        }

        [Parameter()]
        public bool? InlineSchema
        {
            get;
            set;
        }

        [Parameter()]
        public bool? PreserveWhitespace
        {
            get;
            set;
        }

        [Parameter()]
        public string RecordSeparator
        {
            get;
            set;
        }

        [Parameter()]
        public string TableSeparator
        {
            get;
            set;
        }

        [Parameter()]
        public TextEncoding? TextEncoding
        {
            get;
            set;
        }

        [Parameter()]
        public TransactionType? TransactionType
        {
            get;
            set;
        }

        [Parameter()]
        public bool? UseDefaultNamespace
        {
            get;
            set;
        }

        [Parameter()]
        public bool? UseLax
        {
            get;
            set;
        }

        [Parameter()]
        public bool? UseRequestPage
        {
            get;
            set;
        }

        [Parameter()]
        public XmlVersionNo? XmlVersionNo
        {
            get;
            set;
        }

        protected XmlPort CreateXmlPort()
        {
            var xmlPort = new XmlPort(ID, Name);
            SetObjectProperties(xmlPort);

            xmlPort.Properties.DefaultFieldsValidation = DefaultFieldsValidation;
            xmlPort.Properties.DefaultNamespace = DefaultNamespace;
            xmlPort.Properties.Direction = Direction;
            xmlPort.Properties.Encoding = Encoding;
            xmlPort.Properties.FieldDelimiter = FieldDelimiter;
            xmlPort.Properties.FieldSeparator = FieldSeparator;
            xmlPort.Properties.FileName = FileName;
            xmlPort.Properties.Format = Format;
            xmlPort.Properties.FormatEvaluate = FormatEvaluate;
            xmlPort.Properties.InlineSchema = InlineSchema;
            xmlPort.Properties.PreserveWhiteSpace = PreserveWhitespace;
            xmlPort.Properties.RecordSeparator = RecordSeparator;
            xmlPort.Properties.TableSeparator = TableSeparator;
            xmlPort.Properties.TextEncoding = TextEncoding;
            xmlPort.Properties.TransactionType = TransactionType;
            xmlPort.Properties.UseDefaultNamespace = UseDefaultNamespace;
            xmlPort.Properties.UseLax = UseLax;
            xmlPort.Properties.UseRequestPage = UseRequestPage;
            xmlPort.Properties.XmlVersionNo = XmlVersionNo;

            if (AutoCaption)
                xmlPort.AutoCaption();

            return xmlPort;
        }

        protected override void ProcessRecord()
        {
            WriteObject(CreateXmlPort());
        }
    }
}
