using AutoMapper;
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
    public class CreateFeatureCommandHandler(IRepository<Feature> _repository,IMapper _mapper) : IRequestHandler<CreateFeatureCommand>
    {
        public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
          await _repository.CreateAsync(_mapper.Map<Feature>(request));
        }
    }
}
