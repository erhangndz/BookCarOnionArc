using AutoMapper;
using BookCar.Application.Features.CQRS.Queries.CarQueries;
using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler(IRepository<Car> _repository, IMapper _mapper)
    {
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            return _mapper.Map<GetCarByIdQueryResult>(await _repository.GetByIdAsync(query.Id));
        }

    }
}
