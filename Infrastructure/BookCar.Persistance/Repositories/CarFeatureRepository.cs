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
    public class CarFeatureRepository(BookCarContext _context) : ICarFeatureRepository
    {
        public Task CreateAsync(CarFeature entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarFeature>> GetAllAsync()
        {
            return await _context.CarFeatures.Include(x => x.Car).Include(x => x.Feature).ToListAsync();
        }

        public Task<CarFeature> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CarFeature entity)
        {
            throw new NotImplementedException();
        }
    }
}
