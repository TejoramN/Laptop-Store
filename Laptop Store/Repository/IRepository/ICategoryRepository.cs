using Laptop_Store.Models;

namespace Laptop_Store.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
