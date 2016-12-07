
using AutoMapper;
namespace Omdb.Net.Models
{
    public class FlatMovie
    {
        public string Title;
        public int Year;
        public string Released;
        public string Genre;
        public string Director;
        public string Writer;
        public string Actors;
        public string Language;
        public string Country;
        public string Plot;
        public string Awards;
        public string Poster;
        public string Metascore;
        public string ImdbRating;
        public string ImdbVotes;
        public string ImdbId;
        public string Type;
        public string tomatoMeter { get; set; }
        public string tomatoImage { get; set; }
        public string tomatoRating { get; set; }
        public string tomatoReviews { get; set; }
        public string tomatoFresh { get; set; }
        public string tomatoRotten { get; set; }
        public string tomatoConsensus { get; set; }
        public string tomatoUserMeter { get; set; }
        public string tomatoUserRating { get; set; }
        public string tomatoUserReviews { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response { get; set; }

        internal Tomatoes ReturnShiz()
        {
            if (tomatoMeter == null && tomatoImage == null && tomatoRating == null &&
               tomatoReviews == null && tomatoFresh == null && tomatoRotten == null)
            { return null; }
            return Mapper.Map<Tomatoes>(this);
        }
    }
}
