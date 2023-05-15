using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteParserCore.Attributes;
using WebsiteParserCore.Attributes.StartAttributes;

namespace WebsiteParserCore.Tests.Models
{
    [ListSelector(".table_lyrics tbody", ChildSelector = ".even, .odd")]
    class SongModel
    {
        [Selector(".wrapWords")]
        [Debug]
        public string Name { get; set; }
    }
}
