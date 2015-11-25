﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace UncommonSense.CBreeze.Automation
{
    public class DynamicParameter<T>
    {
        public DynamicParameter(string name, bool mandatory = false, bool valueFromPipeline = false, T defaultValue = default(T), int? minRange = null, int? maxRange = null, string[] parameterSetNames = null)
        {
            var attributes = new Collection<Attribute>();

            if (parameterSetNames == null)
                parameterSetNames = new string[] { null };
            if (parameterSetNames.Length == 0)
                parameterSetNames = new string[] { null };

            foreach (var parameterSetName in parameterSetNames)
            {
                var parameterAttribute = new ParameterAttribute();
                parameterAttribute.Mandatory = mandatory;
                parameterAttribute.ValueFromPipeline = valueFromPipeline;
                parameterAttribute.ParameterSetName = parameterSetName;
                attributes.Add(parameterAttribute);
            }

            if (minRange.HasValue && maxRange.HasValue)
            {
                var validateRangeAttribute = new ValidateRangeAttribute(minRange.Value, maxRange.Value);
                attributes.Add(validateRangeAttribute);
            }

            RuntimeDefinedParameter = new RuntimeDefinedParameter(name, typeof(T), attributes);
            RuntimeDefinedParameter.Value = defaultValue;
        }

        public RuntimeDefinedParameter RuntimeDefinedParameter
        {
            get;
            protected set;
        }

        public T Value
        {
            get
            {
                if (RuntimeDefinedParameter.Value == null)
                    return default(T);

                return (T)RuntimeDefinedParameter.Value;
            }
        }
    }
}
