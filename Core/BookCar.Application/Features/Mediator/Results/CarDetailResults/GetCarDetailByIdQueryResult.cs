using BookCar.Application.Features.CQRS.Results.CarResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Results.CarDetailResults
{
    public class GetCarDetailByIdQueryResult
    {
        public int CarDetailId { get; set; }
        public string Description { get; set; }
        public int CarId { get; set; }
        public GetCarQueryResult Car { get; set; }
    }
}
