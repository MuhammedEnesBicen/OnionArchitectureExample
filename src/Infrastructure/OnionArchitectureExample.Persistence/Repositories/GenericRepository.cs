using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Application.Interfaces.Repository;
using OnionArchitectureExample.Domain.Common;
using OnionArchitectureExample.Persistence.Context;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;
        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }



        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;

        }

        public async Task<List<T>> GetAllAsync()
        {
            dbContext.Database.EnsureCreated();
            return await dbContext.Set<T>().AsNoTracking().ToListAsync();

        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
    }
}
