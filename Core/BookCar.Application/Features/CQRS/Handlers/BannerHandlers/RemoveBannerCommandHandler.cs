using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.BannerCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;

namespace BookCar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler(IRepository<Banner> _repository,IMapper _mapper)
    {

        public async Task Handle(RemoveBannerCommand command)
        {
            await _repository.RemoveAsync(command.Id);
        }

    }
}
