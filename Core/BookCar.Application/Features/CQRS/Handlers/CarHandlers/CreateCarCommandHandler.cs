using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.CarCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler(IRepository<Car> _repository, IMapper _mapper)
    {

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(_mapper.Map<Car>(command));
        }
    }
}
