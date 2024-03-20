using MediatR;
using OnionArchitectureExample.Application.Dto;
using OnionArchitectureExample.Application.Wrappers;

namespace OnionArchitectureExample.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {
    }
}
