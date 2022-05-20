using Laptop_Store.Data;
using Laptop_Store.Models;
using Laptop_Store.Repository.IRepository;

namespace Laptop_Store.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {

            _db = db;
        } 
        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u=>u.Id==obj.Id);
            if (objFromDb != null) {

                objFromDb.Name = obj.Name;
                objFromDb.Price = obj.Price;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Brand = obj.Brand;
                objFromDb.CoverTypeId = obj.CoverTypeId;
                if (obj.ImageUrl != null) { 
                
                    objFromDb.ImageUrl= obj.ImageUrl;

                }

            }
          
        }
    }
}
