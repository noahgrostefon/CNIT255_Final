using Omdb.Net.Models;
using System.Threading.Tasks;
using Omdb.Net.Helpers;

namespace Omdb.Net.RequestBuilder
{
    public class OmdbIdRequestBuilder : OmdbRequestBase
    {
        private static OmdbIdRequestBuilder _builder;

        public static OmdbIdRequestBuilder Get(string id)
        {
            _builder = new OmdbIdRequestBuilder();
            _builder.WithImdbId(id);
            return _builder;
        }

        public async Task<Movie> MakeRequest()
        {
            var response = await RetrieveMovieData<FlatMovie>();
            return response.ToMovie();
        }

        public OmdbIdRequestBuilder WithPlotLength(PlotLenthType plotLength)
        {
            _queryString.AddPlotLength(plotLength);
            return this;
        }

        private OmdbIdRequestBuilder WithImdbId(string id)
        {
            _queryString.AddImdbId(id);
            return this;
        }

        public OmdbIdRequestBuilder WithTomatoes()
        {
            _queryString.AddTomatoes();
            return this; 
        }
    }
}
