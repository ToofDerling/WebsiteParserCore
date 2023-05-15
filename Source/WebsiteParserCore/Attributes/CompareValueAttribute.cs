﻿using System;
using System.Collections.Generic;
using System.Text;
using WebsiteParserCore.Attributes.Abstract;

namespace WebsiteParserCore.Attributes
{
    /// <summary>
    /// Compares if received value equals (or not) expected value
    /// </summary>
    public class CompareValueAttribute : Attribute, IParserAttribute
    {
        /// <summary>
        /// Default constructor of CompareValueAttribute
        /// </summary>
        /// <param name="expected">Expected result to compare</param>
        /// <param name="equals">should equals or not equals</param>
        public CompareValueAttribute(string expected, bool equals)
        {
            _expected = expected;
            _equals = equals;
        }

        readonly string _expected;
        readonly bool _equals;

        public object GetValue(object input)
        {
            return ((string)input).Equals(_expected) && _equals;
        }
    }
}
