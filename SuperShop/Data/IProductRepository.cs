using SuperShop.Data.Entities;
using System.Linq;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericRepository<Product> // IProductRepository will implement IGenericRepository specifically for T = Product
    {
        public IQueryable GetAllWithUsers();
    }
}
