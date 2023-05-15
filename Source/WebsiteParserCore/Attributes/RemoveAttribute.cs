using System;
using System.Text.RegularExpressions;
using WebsiteParserCore.Attributes.Abstract;
using WebsiteParserCore.Attributes.Enums;

namespace WebsiteParserCore.Attributes
{
    public class RemoveAttribute : Attribute, IParserAttribute
    {
        public RemoveAttribute(string value, RemoverValueType type)
        {
            _value = value;
            _type = type;
        }

        string _value;
        RemoverValueType _type;

        public object GetValue(object input)
        {
            string output = (string)input;

            switch (_type)
            {
                case RemoverValueType.Text:
                    output = output.Replace(_value, "");
                    break;
                case RemoverValueType.Regex:
                    output = Regex.Replace(output, _value, "");
                    break;
            }

            return output.Trim();
        }

    }
}
