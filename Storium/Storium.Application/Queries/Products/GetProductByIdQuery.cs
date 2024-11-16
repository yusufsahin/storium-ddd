using System;
using MediatR;

using Storium.Application.DTOs;
namespace Storium.Application.Queries.Products
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public Guid ProductId { get; set; }
    }
}