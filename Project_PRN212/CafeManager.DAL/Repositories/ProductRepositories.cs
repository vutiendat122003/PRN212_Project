using CafeManager.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.DAL.Repositories
{
    public class FoodRepository
    {
        public class ProductRepository
        {
            private readonly CoffeeDbContext _context;

            public ProductRepository(CoffeeDbContext context)
            {
                _context = context;
            }

            public IEnumerable<Food> GetAll()
            {
                return _context.Foods.ToList();
            }

            public Food? GetById(int id)
            {
                return _context.Foods.FirstOrDefault(f => f.Id == id);
            }

            public void Add(Food food)
            {
                _context.Foods.Add(food);
                _context.SaveChanges();
            }

            public void Update(Food food)
            {
                var existingFood = _context.Foods.FirstOrDefault(f => f.Id == food.Id);
                if (existingFood != null)
                {
                    existingFood.Name = food.Name;
                    existingFood.ImageLink = food.ImageLink;
                    existingFood.IdCategory = food.IdCategory;
                    existingFood.Price = food.Price;
                    _context.SaveChanges();
                }
            }

            public void Delete(int id)
            {
                var food = _context.Foods.FirstOrDefault(f => f.Id == id);
                if (food != null)
                {
                    _context.Foods.Remove(food);
                    _context.SaveChanges();
                }
            }
        }
    }
}
