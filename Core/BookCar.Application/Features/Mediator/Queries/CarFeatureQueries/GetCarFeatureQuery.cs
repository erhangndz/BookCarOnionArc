using BookCar.Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarFeatureQuery: IRequest<List<GetCarFeatureQueryResult>>
    {
    }
}
