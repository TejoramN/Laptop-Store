using Laptop_Store.Data;
using Laptop_Store.Models;
using Laptop_Store.Repository.IRepository;

namespace Laptop_Store.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {

            _db = db;
        } 
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
          
        }
    }
}
