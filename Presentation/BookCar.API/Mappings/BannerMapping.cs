﻿using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.BannerCommands;
using BookCar.Application.Features.CQRS.Results.BannerResults;
using BookCar.Domain.Entities;

namespace BookCar.API.Mappings
{
    public class BannerMapping: Profile
    {
        public BannerMapping()
        {
            CreateMap<GetBannerQueryResult, Banner>().ReverseMap();
            CreateMap<GetBannerByIdQueryResult, Banner>().ReverseMap();
            CreateMap<CreateBannerCommand, Banner>().ReverseMap();
            CreateMap<UpdateBannerCommand, Banner>().ReverseMap();
        }
    }
}
