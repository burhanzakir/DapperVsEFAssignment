using Assignment.Application.Interfaces;
using Assignment.Domain.Interfaces;
using Assignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository dbRepository)
        {
            this.productRepository = dbRepository;
        }

        public  async Task<IEnumerable<Product>> GetAllProductsWithCategory()
        {
            return await productRepository.GetAllProductWithCategory();
        }
    }
}
