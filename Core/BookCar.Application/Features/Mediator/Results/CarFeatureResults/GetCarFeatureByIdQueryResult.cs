using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Features.Mediator.Results.FeatureResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Results.CarFeatureResults
{
    public class GetCarFeatureByIdQueryResult
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public GetCarQueryResult Car { get; set; }
        public int FeatureId { get; set; }
        public GetFeatureQueryResult Feature { get; set; }

        public bool HasFeature { get; set; }
    }
}
