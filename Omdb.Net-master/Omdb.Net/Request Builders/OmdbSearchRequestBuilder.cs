using Omdb.Net.Helpers;
using Omdb.Net.Models;
using System.Threading.Tasks;

namespace Omdb.Net.RequestBuilder
{
    public class OmdbSearchRequestBuilder : OmdbRequestBase
    {
        private static OmdbSearchRequestBuilder _builder;

        public static OmdbSearchRequestBuilder SearchTitle(string title)
        {
            _builder = new OmdbSearchRequestBuilder();
            _builder.WithSearchTerm(title);
            return _builder;
        }

        private OmdbSearchRequestBuilder WithSearchTerm(string search)
        {
            _queryString.AddSearchTerm(search);
            return this;
        }

        public Task<MovieSearch> MakeRequest()
        {
            return RetrieveMovieData<MovieSearch>();
        }
    }
}
