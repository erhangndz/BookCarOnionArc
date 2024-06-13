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
    public class UpdateCarDetailCommandHandler(IRepository<CarDetail> _repository,IMapper _mapper) : IRequestHandler<UpdateCarDetailCommand>
    {
        public async Task Handle(UpdateCarDetailCommand request, CancellationToken cancellationToken)
        {
           await _repository.UpdateAsync(_mapper.Map<CarDetail>(request));
        }
    }
}
