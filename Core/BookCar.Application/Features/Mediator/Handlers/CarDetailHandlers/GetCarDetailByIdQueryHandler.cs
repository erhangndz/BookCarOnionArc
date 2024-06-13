using AutoMapper;
using BookCar.Application.Features.Mediator.Queries.CarDetailQueries;
using BookCar.Application.Features.Mediator.Results.CarDetailResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.CarDetailHandlers
{
    public class GetCarDetailByIdQueryHandler(IRepository<CarDetail> _repository,IMapper _mapper) : IRequestHandler<GetCarDetailByIdQuery, GetCarDetailByIdQueryResult>
    {
        public async Task<GetCarDetailByIdQueryResult> Handle(GetCarDetailByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetCarDetailByIdQueryResult>(await _repository.GetByIdAsync(request.Id));
        }
    }
}
