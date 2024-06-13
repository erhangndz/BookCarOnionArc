using BookCar.Application.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace BookCar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery(int id): IRequest<GetFeatureByIdQueryResult>
    {
        public int Id { get; set; } = id;

    }
}
