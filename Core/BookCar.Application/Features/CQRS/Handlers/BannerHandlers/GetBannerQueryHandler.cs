using AutoMapper;
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
    public class GetBannerQueryHandler(IRepository<Banner> repository,IMapper mapper)
    {

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await repository.GetAllAsync();
            return mapper.Map<List<GetBannerQueryResult>>(values);  
        }
    }
}
