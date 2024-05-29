using AutoMapper;
using BookCar.Application.Features.CQRS.Commands.BrandCommands;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler(IRepository<Brand> _repository, IMapper _mapper)
    {

        public async Task Handle(RemoveBrandCommand command)
        {
            await _repository.RemoveAsync(command.Id);
        }
    }
}
