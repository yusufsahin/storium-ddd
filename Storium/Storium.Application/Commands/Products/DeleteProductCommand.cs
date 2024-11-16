using System;
using MediatR;

namespace Storium.Application.Commands.Products
{
    public class DeleteProductCommand : IRequest
    {
        public Guid ProductId { get; set; }
    }
}