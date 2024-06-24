using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class CreateCarFeatureCommand: IRequest
    {
       
        public int CarId { get; set; }

        public int FeatureId { get; set; }

        public bool HasFeature { get; set; }
    }
}
