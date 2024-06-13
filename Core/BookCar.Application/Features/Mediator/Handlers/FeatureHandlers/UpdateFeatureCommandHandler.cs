using AutoMapper;
using BookCar.Application.Features.Mediator.Commands.FeatureCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using MediatR;

namespace BookCar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler(IRepository<Feature> _repository, IMapper _mapper) : IRequestHandler<UpdateFeatureCommand>
    {
        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
           await _repository.UpdateAsync(_mapper.Map<Feature>(request));
        }
    }
}
