using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.BannerCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler(IRepository<Banner> repository,IMapper mapper)
    {

        public async Task Handle(UpdateBannerCommand command)
        {
            await repository.UpdateAsync(mapper.Map<Banner>(command));
        }

    }
}
