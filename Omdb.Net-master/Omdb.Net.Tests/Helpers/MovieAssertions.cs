using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omdb.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omdb.Net.Tests.Helper
{
    public class MovieAssert
    {
        public static void AssertMovieProperties(Movie movieToTest)
        {
            Assert.IsNotNull(movieToTest.Actors);
            Assert.IsNotNull(movieToTest.Title);
            Assert.IsNotNull(movieToTest.Actors);
            Assert.IsNotNull(movieToTest.Awards);
            Assert.IsNotNull(movieToTest.Country);
            Assert.IsNotNull(movieToTest.Director);
            Assert.IsNotNull(movieToTest.Genre);
            Assert.IsNotNull(movieToTest.ImdbId);
            Assert.IsNotNull(movieToTest.ImdbRating);
            Assert.IsNotNull(movieToTest.ImdbVotes);
            Assert.IsNotNull(movieToTest.Language);
            Assert.IsNotNull(movieToTest.Metascore);
            Assert.IsNotNull(movieToTest.Plot);
            Assert.IsNotNull(movieToTest.Poster);
            Assert.IsNotNull(movieToTest.Released);
            Assert.IsNotNull(movieToTest.Response);
            Assert.IsNotNull(movieToTest.Type);
            Assert.IsNotNull(movieToTest.Writer);
            Assert.IsNotNull(movieToTest.Year);
        }

        public static void AssertTomoatoesProperties(Tomatoes tomatoes)
        {
            Assert.IsNotNull(tomatoes.BoxOffice);
            Assert.IsNotNull(tomatoes.DVD);
            Assert.IsNotNull(tomatoes.Production);
            Assert.IsNotNull(tomatoes.tomatoConsensus);
            Assert.IsNotNull(tomatoes.tomatoFresh);
            Assert.IsNotNull(tomatoes.tomatoImage);
            Assert.IsNotNull(tomatoes.tomatoMeter);
            Assert.IsNotNull(tomatoes.tomatoRating);
            Assert.IsNotNull(tomatoes.tomatoReviews);
            Assert.IsNotNull(tomatoes.tomatoRotten);
            Assert.IsNotNull(tomatoes.tomatoUserMeter);
            Assert.IsNotNull(tomatoes.tomatoUserRating);
            Assert.IsNotNull(tomatoes.tomatoUserReviews);
            Assert.IsNotNull(tomatoes.Website);
        }
    }
}
