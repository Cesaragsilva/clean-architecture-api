using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitecture.Infraestructure.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : BaseEntity
    {
        protected readonly CleanArchitectureDbContext _cleanArcDbContext;
        public BaseRepository(CleanArchitectureDbContext rocsContext)
        {
            _cleanArcDbContext = rocsContext;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _cleanArcDbContext.Set<T>().AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _cleanArcDbContext.Set<T>();

            foreach (Expression<Func<T, object>> include in includes)
                query = query.Include(include);

            return await query.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _cleanArcDbContext.Set<T>();

            foreach (Expression<Func<T, object>> include in includes)
                query = query.Include(include);

            return await query.AsNoTracking().Where(filter).ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            entity.Created();
            await _cleanArcDbContext.Set<T>().AddAsync(entity);
            await _cleanArcDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            entity.Updated();
            _cleanArcDbContext.Entry(entity).State = EntityState.Modified;
            await _cleanArcDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _cleanArcDbContext.Set<T>().Remove(entity);
            await _cleanArcDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _cleanArcDbContext.Dispose();
        }
    }
}
