using Newtonsoft.Json;
using Omdb.Net.Helpers;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Omdb.Net.RequestBuilder
{
    public class OmdbRequestBase
    {
        protected readonly HttpClient _httpClient;
        protected readonly UriBuilder _uriBuilder;
        protected readonly NameValueCollection _queryString;

        protected OmdbRequestBase()
        {
            _httpClient = new HttpClient();
            _uriBuilder = new UriBuilder("http://www.omdbapi.com/?");
            _queryString = HttpUtility.ParseQueryString(_uriBuilder.Query);
            _queryString.AddDataType();
        }

        protected async Task<T> RetrieveMovieData<T>()
        {
            _uriBuilder.Query = _queryString.ToString();
            using (HttpResponseMessage response = await _httpClient.GetAsync(_uriBuilder.ToString()))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
    }
}
