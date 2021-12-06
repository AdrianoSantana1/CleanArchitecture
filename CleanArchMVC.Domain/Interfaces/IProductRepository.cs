using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchMVC.Domain.Entities;

namespace CleanArchMVC.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetCategoriesAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<Product> RemoveProductAsync(Product product);
        Task<Product> GetProductCategoryAsync(int? id);
    }
}