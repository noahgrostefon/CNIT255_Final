using Omdb.Net.Models;
using System.Threading.Tasks;
using Omdb.Net.Helpers;

namespace Omdb.Net.RequestBuilder
{
    public class OmdbTitleRequestBuilder : OmdbRequestBase
    {
        private static OmdbTitleRequestBuilder _builder;

        public static OmdbTitleRequestBuilder Get(string title)
        {
            _builder = new OmdbTitleRequestBuilder();
            _builder.WithTitle(title);
            return _builder;
        }

        public async Task<Movie> MakeRequest()
        {
            var response = await RetrieveMovieData<FlatMovie>();
            return response.ToMovie();
        }

        public OmdbTitleRequestBuilder WithYear(int year)
        {
            _queryString.AddYear(year);
            return this;
        }

        public OmdbTitleRequestBuilder WithPlotLength(PlotLenthType plotLength)
        {
            _queryString.AddPlotLength(plotLength);
            return this;
        }

        public OmdbTitleRequestBuilder WithTomatoes()
        {
            _queryString.AddTomatoes();
            return this;
        }

        private OmdbTitleRequestBuilder WithTitle(string title)
        {
            _queryString.AddTitle(title);
            return this;
        }
    }
}
