using System.Collections.Generic;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Categories
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryDto>>
    {
    }
}