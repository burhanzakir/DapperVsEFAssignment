using Assignment.Domain.Interfaces;
using Assignment.Domain.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.StoreDapper.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextStore storeContext;
        public ProductRepository(DbContextStore storeContext)
        {
            this.storeContext = storeContext;
        }

        public async Task<IEnumerable<Product>> GetAllProductWithCategory()
        {

            var query = "SELECT p.Name, p.Price , cat.Name as CategoryName FROM tblProducts p Left Join tblCategories cat on p.CategoryId = cat.CategoryId ";
            using (var connection = storeContext.CreateConnection())
            {
                var companies = await connection.QueryAsync<Product>(query);
                return companies.ToList();
            }

        }
    }
}
