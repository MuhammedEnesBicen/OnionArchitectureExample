using MediatR;
using OnionArchitectureExample.Application.Wrappers;

namespace OnionArchitectureExample.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
