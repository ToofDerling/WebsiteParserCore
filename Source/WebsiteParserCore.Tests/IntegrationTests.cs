using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebsiteParserCore.Tests.Models;

namespace WebsiteParserCore.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void WebsiteParserList()
        {
            string html = WebsiteParserCore.Tests.Properties.Resources.SongContent;

            var result = WebContentParser.ParseList(typeof(SongModel), html);

            Assert.AreEqual(8, result.Cast<SongModel>().Count());
        }

        [TestMethod]
        public void WebsiteParserListGeneric()
        {
            string html = WebsiteParserCore.Tests.Properties.Resources.SongContent;

            var result = WebContentParser.ParseList<SongModel>(html);

            Assert.AreEqual(8, result.Count());
        }

        [TestMethod]
        public void WebsiteParserModel()
        {
            string html = WebsiteParserCore.Tests.Properties.Resources.SongContent;

            AlbumModel result = (AlbumModel)WebContentParser.Parse(typeof(AlbumModel), html);

            Assert.AreEqual(8, result.Songs.Count());
        }

        [TestMethod]
        public void WebsiteParserModelGeneric()
        {
            string html = WebsiteParserCore.Tests.Properties.Resources.SongContent;

            var result = WebContentParser.Parse<AlbumModel>(html);

            Assert.AreEqual(8, result.Songs.Count());
        }

    }
}
