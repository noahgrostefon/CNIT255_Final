using Omdb.Net.Models;
using System.Collections.Specialized;

namespace Omdb.Net.Helpers
{
    internal static class OmdbQueryStringExtensions
    {
        private const string TITLE_KEY = "t";
        private const string IMDBID_KEY = "i";
        private const string SEARCH_KEY = "s";
        private const string YEAR_KEY = "y";
        private const string PLOT_LENGTH_KEY = "plot";
        private const string TOMATOES_KEY = "tomatoes";
        private const string DATA_TYPE_KEY = "r";
        private const string JSON_TYPE = "json";

        public static void AddTitle(this NameValueCollection queryBuilder, string title)
        {
            queryBuilder.Add(TITLE_KEY, title);
        }

        public static void AddImdbId(this NameValueCollection queryBuilder, string imdbId)
        {
            queryBuilder.Add(IMDBID_KEY, imdbId);
        }

        public static void AddSearchTerm(this NameValueCollection queryBuilder, string searchTerm)
        {
            queryBuilder.Add(SEARCH_KEY, searchTerm);
        }

        public static void AddYear(this NameValueCollection queryBuilder, int year)
        {
            queryBuilder.Add(YEAR_KEY, year.ToString());
        }

        public static void AddPlotLength(this NameValueCollection queryBuilder, PlotLenthType plotLength)
        {
            queryBuilder.Add(PLOT_LENGTH_KEY, plotLength.ToString());
        }

        public static void AddTomatoes(this NameValueCollection queryBuilder)
        {
            queryBuilder.Add(TOMATOES_KEY, "true");
        }

        public static void AddDataType(this NameValueCollection queryBuilder)
        {
            queryBuilder.Add(DATA_TYPE_KEY, JSON_TYPE);
        }
    }
}
