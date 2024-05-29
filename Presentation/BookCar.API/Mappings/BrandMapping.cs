using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.BrandCommands;
using BookCar.Application.Features.CQRS.Results.BrandResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class BrandMapping:Profile
    {
        public BrandMapping()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<UpdateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandQueryResult, Brand>().ReverseMap();
            CreateMap<GetBrandByIdQueryResult, Brand>().ReverseMap();
           
        }
    }
}
