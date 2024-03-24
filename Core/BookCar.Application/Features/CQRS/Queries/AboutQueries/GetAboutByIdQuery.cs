using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery(int id)
    {
        public int Id { get; set; } = id;
    }
}
