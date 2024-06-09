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
    public class RemoveCarCommandHandler(IRepository<Car> _repository)
    {

        public async Task Handle(RemoveCarCommand command)
        {
            await _repository.RemoveAsync(command.Id);
        }
    }
}
