using BookCar.Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery: IRequest<List<GetFeatureQueryResult>>
    {
    }
}
