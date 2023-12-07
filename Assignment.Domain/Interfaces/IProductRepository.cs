using Assignment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductWithCategory();

        //Task<IEnumerable<Car>> GetAllAsync();
        //Task<Car> GetByIdAsync(int id);
        //Task<int> AddAsync(Car car);
        //Task UpdateAsync(Car car);
        //Task DeleteAsync(int id);
    }
}
