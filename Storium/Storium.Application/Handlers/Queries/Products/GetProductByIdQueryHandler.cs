using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Storium.Application.DTOs;
using Storium.Application.Queries.Products;
using Storium.Infrastructure.Repositories.Interfaces;

namespace Storium.Application.Handlers.Queries.Products
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.ProductId);
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }
    }
}