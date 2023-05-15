using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteParserCore.Exceptions
{
    public class TooManyStartAtributesException : Exception
    {
        public TooManyStartAtributesException() : base("There can only be one IStartAttribute")
        {

        }
    }
}
