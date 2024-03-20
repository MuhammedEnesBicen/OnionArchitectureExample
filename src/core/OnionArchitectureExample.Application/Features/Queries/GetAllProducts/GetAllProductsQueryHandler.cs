using AutoMapper;
using MediatR;
using OnionArchitectureExample.Application.Dto;
using OnionArchitectureExample.Application.Interfaces.Repository;
using OnionArchitectureExample.Application.Wrappers;

namespace OnionArchitectureExample.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductRepository repository;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IProductRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await repository.GetAllAsync();

            var viewModel = mapper.Map<List<ProductViewDto>>(products);

            // manuel mapping ->
            //var dto =  products.Select(p => new ProductViewDto
            //{
            //    Id = p.Id,
            //    Name = p.Name
            //}).ToList();

            return new ServiceResponse<List<ProductViewDto>>(viewModel);
        }
    }
}
