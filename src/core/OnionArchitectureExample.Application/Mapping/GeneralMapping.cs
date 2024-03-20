using AutoMapper;
using OnionArchitectureExample.Application.Features.Commands.CreateProduct;
using OnionArchitectureExample.Application.Features.Queries.GetProductById;

namespace OnionArchitectureExample.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, Dto.ProductViewDto>().ReverseMap();

            CreateMap<Domain.Entities.Product, CreateProductCommand>().ReverseMap();

            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>().ReverseMap();

        }
    }
}
