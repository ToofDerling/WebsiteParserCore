using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteParserCore.Tests.Models.Enums
{
    enum Country
    {
        Default,
        [Description("United Kingdom")]
        UnitedKingdom
    }
}
