using AutoMapper;
using BookCar.Application.Features.Mediator.Commands.CarDetailCommands;
using BookCar.Application.Features.Mediator.Results.CarDetailResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class CarDetailMapping: Profile
    {
        public CarDetailMapping()
        {
            CreateMap<GetCarDetailQueryResult, CarDetail>().ReverseMap();
            CreateMap<GetCarDetailByIdQueryResult, CarDetail>().ReverseMap();
            CreateMap<CreateCarDetailCommand, CarDetail>().ReverseMap();
            CreateMap<UpdateCarDetailCommand, CarDetail>().ReverseMap();
        }

    }
}
