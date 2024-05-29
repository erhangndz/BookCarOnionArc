using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.AboutCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler(IRepository<About> repository,IMapper mapper)
    {

        public async Task Handle(CreateAboutCommand command)
        {
           
            await repository.CreateAsync(mapper.Map<About>(command));
        }
    }
}
