using BookCar.Application.Features.Mediator.Commands.FeatureCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler(IRepository<Feature> _repository) : IRequestHandler<RemoveFeatureCommand>
    {
        public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
        }
    }
}
