using AutoMapper;
using BookCar.Application.Features.Mediator.Commands.FeatureCommands;
using BookCar.Application.Features.Mediator.Results.FeatureResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class FeatureMapping: Profile
    {
        public FeatureMapping()
        {
            CreateMap<GetFeatureQueryResult, Feature>().ReverseMap();
            CreateMap<GetFeatureByIdQueryResult, Feature>().ReverseMap();
            CreateMap<CreateFeatureCommand, Feature>().ReverseMap();
            CreateMap<UpdateFeatureCommand, Feature>().ReverseMap();
           
        }
    }
}
