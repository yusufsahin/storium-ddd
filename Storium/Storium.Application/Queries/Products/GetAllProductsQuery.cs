using System.Collections.Generic;
using MediatR;

using Storium.Application.DTOs;
namespace Storium.Application.Queries.Products
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
    {
    }
}