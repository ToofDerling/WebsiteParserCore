using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteParserCore.Converters.Abstract
{
    /// <summary>
    /// Used in <see cref="WebsiteParserCore.Attributes.ConverterAttribute"/> as a link in chain of converting value.
    /// It reveives value from attribute above and send it to the attribute below if any or sets value to a it's property
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Converts value
        /// </summary>
        /// <param name="input">Value from the attribute above</param>
        /// <returns>Converted value of any type</returns>
        object Convert(object input);
    }
}
