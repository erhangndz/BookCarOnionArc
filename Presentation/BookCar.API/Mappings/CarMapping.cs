using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.CarCommands;
using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class CarMapping: Profile
    {

        public CarMapping()
        {
            CreateMap<CreateCarCommand, Car>().ReverseMap();
            CreateMap<UpdateCarCommand, Car>().ReverseMap();
            CreateMap<GetCarQueryResult, Car>().ReverseMap();
            CreateMap<GetCarByIdQueryResult, Car>().ReverseMap();
        }
    }
}
