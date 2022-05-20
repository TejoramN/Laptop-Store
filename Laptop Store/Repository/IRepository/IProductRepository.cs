using Laptop_Store.Models;

namespace Laptop_Store.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
