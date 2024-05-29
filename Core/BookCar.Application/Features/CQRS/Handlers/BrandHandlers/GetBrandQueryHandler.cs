using AutoMapper;
using BookCar.Application.Features.CQRS.Results.BrandResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler(IRepository<Brand> _repository,IMapper _mapper)
    {

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            return _mapper.Map<List<GetBrandQueryResult>>(await _repository.GetAllAsync());
        }
    }
}
