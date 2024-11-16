using System;
using MediatR;

namespace Storium.Application.Commands.Categories
{
    public class UpdateCategoryCommand : IRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}