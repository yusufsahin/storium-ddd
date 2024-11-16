using System;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Categories
{
    public class GetCategoryByIdQuery : IRequest<CategoryDto>
    {
        public Guid CategoryId { get; set; }
    }
}