using AutoMapper;
using BookCar.Application.Features.Mediator.Commands.CarFeatureCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class RemoveCarFeatureCommandHandler(IRepository<CarFeature> _repository) : IRequestHandler<RemoveCarFeatureCommand>
    {
        public async Task Handle(RemoveCarFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
