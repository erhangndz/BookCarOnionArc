using AutoMapper;
using BookCar.Application.Features.Mediator.Commands.CarFeatureCommands;
using BookCar.Application.Features.Mediator.Results.CarFeatureResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class CarFeatureMapping: Profile
    {
        public CarFeatureMapping()
        {
            CreateMap<CreateCarFeatureCommand,CarFeature>().ReverseMap();
            CreateMap<UpdateCarFeatureCommand,CarFeature>().ReverseMap();
            CreateMap<GetCarFeatureQueryResult,CarFeature>().ReverseMap();
            CreateMap<GetCarFeatureByIdQueryResult,CarFeature>().ReverseMap();
        }
    }
}
