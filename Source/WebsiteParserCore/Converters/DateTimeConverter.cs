﻿using System;
using System.Collections.Generic;
using System.Text;
using WebsiteParserCore.Converters.Abstract;

namespace WebsiteParserCore.Converters
{
    /// <summary>
    /// Default converter. It converts <see cref="string"/> into <see cref="DateTime"/>. It has additional attribute format that allows you to declare date foramt.
    /// </summary>
    public class DateTimeConverter : IConverter
    {
        /// <summary>
        /// Format of date. For example: yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string Format { get; set; }

        public object Convert(object input)
        {
            if (!(input is string))
                throw new Exception("Input value have to be string");

            if (string.IsNullOrEmpty(Format))
                return DateTime.Parse((string)input);
            else
                return DateTime.ParseExact((string)input, Format, null);
        }

    }
}
