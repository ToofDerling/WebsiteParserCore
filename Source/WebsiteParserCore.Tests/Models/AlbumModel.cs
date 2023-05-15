using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteParserCore.Attributes.StartAttributes;

namespace WebsiteParserCore.Tests.Models
{
    class AlbumModel
    {
        [WebsiteParserList]
        public IEnumerable<SongModel> Songs { get; set; }

        [WebsiteParserModel]
        public MetadataModel MetaData { get; set; }
    }
}
