using BookCar.Application.Features.CQRS.Results.CarResults;
using BookCar.Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureCommand:IRequest
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        
        public int FeatureId { get; set; }
        

        public bool HasFeature { get; set; }
    }
}
