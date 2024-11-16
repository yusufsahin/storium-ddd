using System;
using MediatR;

namespace Storium.Application.Commands.Categories
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}