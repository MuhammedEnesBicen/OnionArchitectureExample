using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureExample.Application.Interfaces.Repository;
using OnionArchitectureExample.Persistence.Context;
using OnionArchitectureExample.Persistence.Repositories;

namespace OnionArchitectureExample.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
