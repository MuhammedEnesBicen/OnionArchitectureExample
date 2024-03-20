using AutoMapper;
using MediatR;
using OnionArchitectureExample.Application.Interfaces.Repository;
using OnionArchitectureExample.Application.Wrappers;

namespace OnionArchitectureExample.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var products = mapper.Map<Domain.Entities.Product>(request);
            await productRepository.AddAsync(products);

            return new ServiceResponse<Guid>(products.Id);

        }
    }
}
