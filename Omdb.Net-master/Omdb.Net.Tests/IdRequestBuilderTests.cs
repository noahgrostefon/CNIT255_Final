using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omdb.Net.Models;
using Omdb.Net.RequestBuilder;
using Omdb.Net.Tests.Helper;
using System.Threading.Tasks;

namespace Omdb.Net.Tests
{
    [TestClass]
    public class IdRequestBuilderTests
    {
        [TestMethod]
        public void SearchWithJustIdExpectResult()
        {
            var target = OmdbIdRequestBuilder.Get("tt0120737");
            var response = target.MakeRequest();

            var result = Task.Run(() => response).Result;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Title.ToLower().Contains("lord"));
            MovieAssert.AssertMovieProperties(result);
            //when "Tomatoes" option is no used then the property is null
            Assert.IsNull(result.Tomatoes);
        }

        [TestMethod]
        public void SearchWithTomatoesExpectPropertyNotNull()
        {
            var target = OmdbIdRequestBuilder.Get("tt0120737");
            var response = target.WithTomatoes().MakeRequest();

            var result = Task.Run(() => response).Result;
            Assert.IsNotNull(result); 
            Assert.IsNotNull(result.Tomatoes);
            MovieAssert.AssertMovieProperties(result);
            MovieAssert.AssertTomoatoesProperties(result.Tomatoes);
        }

        [TestMethod]
        public void FullPlotShouldContainMoreContentThanShort()
        {
            var shortTarget = OmdbIdRequestBuilder.Get("tt0120737");
            var fullTarget = OmdbIdRequestBuilder.Get("tt0120737");

            var shortResponse = shortTarget.WithPlotLength(PlotLenthType.Short).MakeRequest();
            var fullResponse = fullTarget.WithPlotLength(PlotLenthType.Full).MakeRequest();

            var shortResult = Task.Run(() => shortResponse).Result;
            var fullResult = Task.Run(() => fullResponse).Result;

            Assert.IsNotNull(fullResult);
            Assert.IsNotNull(shortResult);
            Assert.IsTrue(shortResult.Plot.Length < fullResult.Plot.Length);
        }
    }
}
