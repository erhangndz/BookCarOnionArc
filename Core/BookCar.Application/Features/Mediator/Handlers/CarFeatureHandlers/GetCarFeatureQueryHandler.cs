using AutoMapper;
using BookCar.Application.Features.Mediator.Queries.CarFeatureQueries;
using BookCar.Application.Features.Mediator.Results.CarFeatureResults;
using BookCar.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureQueryHandler(ICarFeatureRepository _repository,IMapper _mapper) : IRequestHandler<GetCarFeatureQuery, List<GetCarFeatureQueryResult>>
    {
        public async Task<List<GetCarFeatureQueryResult>> Handle(GetCarFeatureQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetCarFeatureQueryResult>>(await _repository.GetAllAsync());
        }
    }
}
