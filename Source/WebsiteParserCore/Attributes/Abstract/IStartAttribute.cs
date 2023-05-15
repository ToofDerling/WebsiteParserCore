using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteParserCore.Attributes.Abstract
{
    public interface IStartAttribute
    {
        object GetValue(HtmlNode rootNode, out bool canParse);
    }
}
