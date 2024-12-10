using CafeManager.DAL.Models;
using CafeManager.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CafeManager.DAL.Repositories.FoodRepository;

namespace CafeManager.BLL.Services
{
    public class ProductService
    {
        private ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Food> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Food? GetProductById(int id)
        {
            return _repository.GetById(id);
        }

        public bool AddProduct(Food food)
        {
            if (string.IsNullOrEmpty(food.Name) || food.Price <= 0)
            {
                return false; // Validation failed
            }

            _repository.Add(food);
            return true;
        }

        public bool UpdateProduct(Food food)
        {
            if (string.IsNullOrEmpty(food.Name) || food.Price <= 0)
            {
                return false; // Validation failed
            }

            _repository.Update(food);
            return true;
        }

        public bool DeleteProduct(int id)
        {
            var existingProduct = _repository.GetById(id);
            if (existingProduct == null)
            {
                return false; // Product not found
            }

            _repository.Delete(id);
            return true;
        }
    }
}
