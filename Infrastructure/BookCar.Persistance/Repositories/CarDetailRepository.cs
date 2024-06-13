using BookCar.Application.Interfaces;
using BookCar.Domain.Entities;
using BookCar.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Persistance.Repositories
{
    public class CarDetailRepository(BookCarContext _context) : ICarDetailRepository
    {
       
        public Task CreateAsync(CarDetail entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarDetail>> GetAllAsync()
        {
            return await _context.CarDetails.Include(x => x.Car).ToListAsync();
        }

        public Task<CarDetail> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CarDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
