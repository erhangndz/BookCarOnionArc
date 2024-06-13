using AutoMapper;
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
    public class CreateCarDetailCommandHandler(IRepository<CarDetail> _repository, IMapper _mapper) : IRequestHandler<CreateCarDetailCommand>
    {
        public async Task Handle(CreateCarDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_mapper.Map<CarDetail>(request));
        }
    }
}
