using BookCar.Application.Features.Mediator.Results.CarDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.Mediator.Queries.CarDetailQueries
{
    public class GetCarDetailByIdQuery(int id): IRequest<GetCarDetailByIdQueryResult>
    {
        public int Id { get; set; } = id;
    }
}
