using AutoMapper;
using Omdb.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Omdb.Net.Helpers
{
    public static class MovieModelExtensions
    {
        public static Movie ToMovie(this FlatMovie movie)
        {
            Mapper.CreateMap<FlatMovie, Tomatoes>();
            Mapper.CreateMap<FlatMovie, Movie>()
                .ForMember(dest => dest.Tomatoes, opt => opt.MapFrom(src => src.ReturnShiz()));

            return Mapper.Map<Movie>(movie);
        }
    }
}
