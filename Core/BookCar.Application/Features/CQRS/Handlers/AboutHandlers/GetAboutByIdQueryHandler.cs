using AutoMapper;
using BookCar.Application.Features.CQRS.Queries.AboutQueries;
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
    public class GetAboutByIdQueryHandler(IRepository<About> repository,IMapper mapper)
    {

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            
            return mapper.Map<GetAboutByIdQueryResult>(await repository.GetByIdAsync(query.Id));
        }
    }
}
