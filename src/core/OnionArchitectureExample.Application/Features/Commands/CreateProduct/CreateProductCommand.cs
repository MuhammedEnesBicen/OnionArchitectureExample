using MediatR;
using OnionArchitectureExample.Application.Wrappers;

namespace OnionArchitectureExample.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
