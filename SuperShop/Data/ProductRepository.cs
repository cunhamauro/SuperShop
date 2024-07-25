using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository // ProductRepository implements IProductRepository and extends GenericRepository with T = Product (Pass Product to the GenericRepository)
    {
        public ProductRepository(DataContext context) : base(context)
        { 
        }
    }
}
