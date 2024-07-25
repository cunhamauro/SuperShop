using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity // IEntity implements an ID in all items to allow generic CRUD by ID
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        // AsNoTracking allows a read-only operation that does not track the entities or data, saving memory
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await SaveAllAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        private async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().AnyAsync(e => e.Id == id);
        }

    }
}
