using Laptop_Store.Data;
using Laptop_Store.Models;
using Laptop_Store.Repository.IRepository;

namespace Laptop_Store.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {

            _db = db;
        } 
        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
          
        }
    }
}
