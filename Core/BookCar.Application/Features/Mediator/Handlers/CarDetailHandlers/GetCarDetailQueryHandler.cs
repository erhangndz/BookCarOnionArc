using AutoMapper;
using BookCar.Application.Features.Mediator.Queries.CarDetailQueries;
using BookCar.Application.Features.Mediator.Results.CarDetailResults;
using BookCar.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.CarDetailHandlers
{
    public class GetCarDetailQueryHandler(ICarDetailRepository _repository,IMapper _mapper) : IRequestHandler<GetCarDetailQuery, List<GetCarDetailQueryResult>>
    {
        public async Task<List<GetCarDetailQueryResult>> Handle(GetCarDetailQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetCarDetailQueryResult>>(await _repository.GetAllAsync());
        }
    }
}
