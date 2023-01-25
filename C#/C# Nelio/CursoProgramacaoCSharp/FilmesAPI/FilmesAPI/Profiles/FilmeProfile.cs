using AutoMapper;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;
public class FilmeProfile : Profile
{
    public FilmeProfile() 
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}
