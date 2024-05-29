using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.AboutCommands;
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
    public class CreateBannerCommandHandler(IRepository<Banner> _repository,IMapper _mapper)
    {
        public async Task Handle(CreateBannerCommand command)
        {
            await _repository.CreateAsync(_mapper.Map<Banner>(command));
        }

    }
}
