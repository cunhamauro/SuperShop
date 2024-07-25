using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericRepository<Product> // IProductRepository will implement IGenericRepository specifically for T = Product
    {
    }
}
