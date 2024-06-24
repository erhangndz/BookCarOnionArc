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
    public class CreateCarFeatureCommandHandler(IRepository<CarFeature> _repository,IMapper _mapper) : IRequestHandler<CreateCarFeatureCommand>
    {
        public async Task Handle(CreateCarFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_mapper.Map<CarFeature>(request));
        }
    }
}
