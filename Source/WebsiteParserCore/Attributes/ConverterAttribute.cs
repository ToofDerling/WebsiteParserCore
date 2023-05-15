﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebsiteParserCore.Attributes.Abstract;
using WebsiteParserCore.Converters.Abstract;

namespace WebsiteParserCore.Attributes
{
    /// <summary>
    /// Converts data from above's attribute using <see cref="IConverter"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ConverterAttribute : Attribute, IParserAttribute
    {
        public ConverterAttribute(Type converterType)
        {
            if (!typeof(IConverter).IsAssignableFrom(converterType))
                throw new NotSupportedException($"{converterType.Name} is not assignable from {typeof(IConverter).Name}");
            if (!converterType.GetConstructors().Any(c => c.GetParameters().Length == 0))
                throw new NotSupportedException($"Converter must have a parameterless constructor to use this constructor. You can use another constructor to pass IConverter instance");

            ConverterInstance = (IConverter)Activator.CreateInstance(converterType);
        }

        public IConverter ConverterInstance { get; set; }

        public object GetValue(object input)
        {
            return ConverterInstance.Convert(input);
        }

    }
}