using AutoMapper;
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
    public class GetCarQueryHandler(ICarRepository _repository, IMapper _mapper)
    {


        public async Task<List<GetCarQueryResult>> Handle()
        {
           return _mapper.Map<List<GetCarQueryResult>>(await _repository.GetAllAsync());
        }

    }
}
