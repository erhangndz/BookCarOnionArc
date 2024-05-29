using AutoMapper;
using BookCar.Application.Features.CQRS.Results.AboutResults;
using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler(IRepository<About> _repository,IMapper _mapper)
    {
        public async Task<List<GetAboutQueryResult>> Handle()
        {
            
            return _mapper.Map<List<GetAboutQueryResult>>(await _repository.GetAllAsync());
        }

    }
}
