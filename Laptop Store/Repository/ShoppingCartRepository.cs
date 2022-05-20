using Laptop_Store.Data;
using Laptop_Store.Models;
using Laptop_Store.Repository.IRepository;

namespace Laptop_Store.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {

            _db = db;
        } 
    }
}
