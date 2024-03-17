using OnionArchitectureExample.Application.Interfaces.Repository;
using OnionArchitectureExample.Domain.Entities;
using OnionArchitectureExample.Persistence.Context;

namespace OnionArchitectureExample.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
