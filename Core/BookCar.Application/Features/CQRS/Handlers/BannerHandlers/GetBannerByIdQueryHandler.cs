using AutoMapper;
using BookCar.Application.Features.CQRS.Queries.BannerQueries;
using BookCar.Application.Features.CQRS.Results.BannerResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler(IRepository<Banner> repository,IMapper mapper)
    {


        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            return mapper.Map<GetBannerByIdQueryResult>(await repository.GetByIdAsync(query.Id));
        }

    }
}
