using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.AboutCommands;
using BookCar.Application.Features.CQRS.Results.AboutResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class AboutMapping: Profile
    {
        public AboutMapping()
        {
            CreateMap<GetAboutQueryResult, About>().ReverseMap();
            CreateMap<GetAboutByIdQueryResult, About>().ReverseMap();
            CreateMap<CreateAboutCommand, About>().ReverseMap();
            CreateMap<UpdateAboutCommand, About>().ReverseMap();
        }
    }
}
