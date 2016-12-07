using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omdb.Net.Helpers;
using System;
using System.Linq;
using System.Web;

namespace Omdb.Net.Tests
{
    [TestClass]
    public class QueryStringExtensionTests
    {
        [TestMethod]
        public void AddTitleExpectAddedToQuery()
        {
            var target = HttpUtility.ParseQueryString(string.Empty);
            target.AddTitle("value");
            Assert.IsTrue(target.AllKeys.Contains("t", StringComparer.InvariantCultureIgnoreCase));
            Assert.AreEqual(target.Get("t"), "value");
            Assert.IsTrue(target.ToString().Contains("t=value"));
        }

        [TestMethod]
        public void AddYearExpectAddedToQuery()
        {
            var target = HttpUtility.ParseQueryString(string.Empty);
            target.AddYear(1990);
            Assert.IsTrue(target.AllKeys.Contains("y", StringComparer.InvariantCultureIgnoreCase));
            Assert.AreEqual(target.Get("y"), "1990");
        }

        [TestMethod]
        public void AddPlotTypeExpectAddedToQuery()
        {
            var target = HttpUtility.ParseQueryString(string.Empty);
            target.AddYear(1990);
            Assert.IsTrue(target.AllKeys.Contains("y", StringComparer.InvariantCultureIgnoreCase));
            Assert.AreEqual(target.Get("y"), "1990");
        }
    }
}
