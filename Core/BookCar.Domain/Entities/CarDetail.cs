using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Domain.Entities
{
    public class CarDetail
    {
        public int CarDetailId { get; set; }

        public string Description { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
