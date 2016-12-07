using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omdb.Net.Models;
using Omdb.Net.RequestBuilder;
using Omdb.Net.Tests.Helper;
using System.Threading.Tasks;

namespace Omdb.Net.Tests
{
    [TestClass]
    public class TitleRequestBuilderTests
    {
        [TestMethod]
        public void SearchWithJustTitleExpectResult()
        {
            var target = OmdbTitleRequestBuilder.Get("lord");
            var response = target.MakeRequest();

            var result = Task.Run(() => response).Result;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Title.ToLower().Contains("lord"));
            Assert.IsFalse(string.IsNullOrEmpty(result.Actors));
            MovieAssert.AssertMovieProperties(result);
            //Tomatoes should be null as option not chosen
            Assert.IsNull(result.Tomatoes);
        }

        [TestMethod]
        public void SearchWithYearExpectResult()
        {
            var target = OmdbTitleRequestBuilder.Get("lord");
            var response = target.WithYear(2001).MakeRequest();

            var result = Task.Run(() => response).Result;

            Assert.IsNotNull(result);
            Assert.AreEqual(2001, result.Year);
            MovieAssert.AssertMovieProperties(result);
            //Tomatoes should be null as option not chosen
            Assert.IsNull(result.Tomatoes);
        }

        [TestMethod]
        public void SearchWithTomatoesExpectPropertyNotNull()
        {
            var target = OmdbTitleRequestBuilder.Get("lord");
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
            var shortTarget = OmdbTitleRequestBuilder.Get("lord");
            var fullTarget = OmdbTitleRequestBuilder.Get("lord");

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
