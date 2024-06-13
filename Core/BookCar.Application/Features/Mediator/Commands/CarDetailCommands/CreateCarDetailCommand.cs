using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Commands.CarDetailCommands
{
    public class CreateCarDetailCommand: IRequest
    {
        public string Description { get; set; }
        public int CarId { get; set; }
    }
}
