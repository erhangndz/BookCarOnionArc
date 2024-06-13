using BookCar.Application.Features.CQRS.Results.CarResults;

namespace BookCar.Application.Features.Mediator.Results.CarDetailResults
{
    public class GetCarDetailQueryResult
    {
        public int CarDetailId { get; set; }
        public string Description { get; set; }
        public int CarId { get; set; }
        public GetCarQueryResult Car { get; set; }
    }
}
