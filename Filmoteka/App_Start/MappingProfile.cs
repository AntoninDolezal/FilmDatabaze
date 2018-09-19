using AutoMapper;
using Filmoteka.Dtos;
using Filmoteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmoteka.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}