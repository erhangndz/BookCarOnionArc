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
    public class CarRepository(BookCarContext _context) : ICarRepository
    {
        public async Task CreateAsync(Car entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Car>> GetAllAsync()
        {
           return await _context.Cars.Include(x=>x.Brand).ToListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
           return await _context.Cars.FindAsync(id);
        }

        public async Task RemoveAsync(int id)
        {
           var car = await GetByIdAsync(id);
            _context.Remove(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Car entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
