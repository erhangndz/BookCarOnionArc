using BookCar.Application.Features.Mediator.Commands.CarDetailCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.CarDetailHandlers
{
    public class RemoveCarDetailCommandHandler(IRepository<CarDetail> _repository) : IRequestHandler<RemoveCarDetailCommand>
    {
        public async Task Handle(RemoveCarDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
