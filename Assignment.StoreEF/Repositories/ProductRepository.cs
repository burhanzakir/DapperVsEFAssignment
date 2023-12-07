using Assignment.Domain.Interfaces;
using Assignment.Domain.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.StoreEF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextStore storeContext;
        private readonly IMapper mapper;

        public ProductRepository(DbContextStore storeContext, IMapper mapper)
        {
            this.storeContext = storeContext;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<Product>> GetAllProductWithCategory()
        {
            var data = from p in storeContext.TblProducts
                       join c in storeContext.TblCategories
                       on p.CategoryId equals c.CategoryId into prodCate
                       from m in prodCate.DefaultIfEmpty()
                       select new Assignment.Domain.Models.Product()
                       {
                           ProductId = p.ProductId,
                           CategoryId = p.CategoryId,
                           Name = p.Name,
                           Price = p.Price,
                           CategoryName = m.Name

                       };

            var result = await data.ToListAsync();
            return result;
        }
    }
}
