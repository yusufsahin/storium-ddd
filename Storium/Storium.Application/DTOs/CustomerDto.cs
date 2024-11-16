using System;

namespace Storium.Application.DTOs
{
    public class CustomerDto
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public AddressDto Address { get; set; }
    }
}