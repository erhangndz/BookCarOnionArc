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
    public class UpdateAboutCommandHandler(IRepository<About> repository,IMapper mapper)
    {

        public async Task Handle(UpdateAboutCommand command)
        {
            await repository.UpdateAsync(mapper.Map<About>(command));
        }
    }
}
