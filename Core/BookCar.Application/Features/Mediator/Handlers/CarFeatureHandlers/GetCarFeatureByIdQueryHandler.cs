using AutoMapper;
using BookCar.Application.Features.Mediator.Queries.CarFeatureQueries;
using BookCar.Application.Features.Mediator.Results.CarFeatureResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByIdQueryHandler(IRepository<CarFeature> _repository,IMapper _mapper) : IRequestHandler<GetCarFeatureByIdQuery, GetCarFeatureByIdQueryResult>
    {
        public async Task<GetCarFeatureByIdQueryResult> Handle(GetCarFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetCarFeatureByIdQueryResult>(await _repository.GetByIdAsync(request.Id));
        }
    }
}
