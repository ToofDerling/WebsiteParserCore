using System;
using System.Text.RegularExpressions;
using WebsiteParserCore.Attributes.Abstract;
using WebsiteParserCore.Exceptions;
using RegexParseException = WebsiteParserCore.Exceptions.RegexParseException;

namespace WebsiteParserCore.Attributes
{
    /// <summary>
    /// Extracts value of first group of regex match.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RegexAttribute : Attribute, IParserAttribute
    {
        public RegexAttribute(string regex)
        {
            _regex = regex;
        }

        readonly string _regex;

        public object GetValue(object input)
        {
            var match = Regex.Match((string)input, _regex);

            if (!match.Success)
                throw new RegexParseException(_regex);

            return match.Groups[1].Value.Trim();
        }

    }
}
