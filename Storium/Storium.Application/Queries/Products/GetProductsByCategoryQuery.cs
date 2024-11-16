using System;
using System.Collections.Generic;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Products
{
    public class GetProductsByCategoryQuery : IRequest<IEnumerable<ProductDto>>
    {
        public Guid CategoryId { get; set; }
    }
}