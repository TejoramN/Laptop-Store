namespace Laptop_Store.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

        IShoppingCartRepository ShoppingCart { get; }


        void Save();

    }
}
