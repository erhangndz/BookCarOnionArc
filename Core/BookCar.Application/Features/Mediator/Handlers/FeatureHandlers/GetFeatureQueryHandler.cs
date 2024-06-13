using AutoMapper;
using BookCar.Application.Features.Mediator.Queries.FeatureQueries;
using BookCar.Application.Features.Mediator.Results.FeatureResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler(IRepository<Feature> _repository, IMapper _mapper) : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
           return _mapper.Map<List<GetFeatureQueryResult>>(await _repository.GetAllAsync());
        }
    }
}
