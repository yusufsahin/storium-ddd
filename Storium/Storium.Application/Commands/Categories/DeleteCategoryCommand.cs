using System;
using MediatR;

namespace Storium.Application.Commands.Categories
{
    public class DeleteCategoryCommand : IRequest
    {
        public Guid CategoryId { get; set; }
    }
}