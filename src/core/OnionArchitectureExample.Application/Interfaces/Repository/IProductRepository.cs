using OnionArchitectureExample.Domain.Entities;

namespace OnionArchitectureExample.Application.Interfaces.Repository
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {
    }
}
