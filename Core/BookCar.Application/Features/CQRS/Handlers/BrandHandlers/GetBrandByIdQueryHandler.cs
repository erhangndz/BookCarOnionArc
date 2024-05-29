using AutoMapper;
using BookCar.Application.Features.CQRS.Queries.BrandQueries;
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
    public class GetBrandByIdQueryHandler(IRepository<Brand> _repository, IMapper _mapper)
    {

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            return _mapper.Map<GetBrandByIdQueryResult>(await _repository.GetByIdAsync(query.Id));
        }
    }
}
