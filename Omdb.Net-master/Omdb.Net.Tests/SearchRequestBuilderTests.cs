using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omdb.Net.RequestBuilder;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Omdb.Net.Tests
{
    [TestClass]
    public class SearchRequestBuilderTests
    {
        [TestMethod]
        public void SearchWithJustTitleExpectResult()
        {
            var target = OmdbSearchRequestBuilder.SearchTitle("The lord of the");
            var response = target.MakeRequest();

            var result = Task.Run(() => response).Result;

            Assert.IsTrue(result.Search.Count > 0);
            Assert.IsNotNull(result.Search.First().Title);
            Assert.IsTrue(result.Search.Where(r => r.Title.ToLower().Contains("the lord of the")).Count() > 0);
            Assert.IsNotNull(result.Search.First().ImdbId);
            Assert.IsNotNull(result.Search.First().Type);
            Assert.IsNotNull(result.Search.First().Year);
        }
    }
}
