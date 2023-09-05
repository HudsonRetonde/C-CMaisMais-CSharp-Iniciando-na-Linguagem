using AutoMapper;
using FilmesApi.Controllers;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
	public CinemaProfile()
	{
		CreateMap<CreateFilmeDto, Filme>();
		CreateMap<Cinema, ReadCinemaDto>();
		CreateMap<UpdateCinemaDto, Cinema>();

	}
}
