using Storium.Domain.ValueObjects;

namespace Storium.Domain.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; private set; } // Value Object
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public Customer(string firstName, string lastName, string email, Address address)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("First Name is required.");
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Last Name is required.");
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email is required.");
            Address = address ?? throw new ArgumentNullException(nameof(address));

            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void UpdateAddress(Address newAddress)
        {
            Address = newAddress ?? throw new ArgumentNullException(nameof(newAddress));
        }
    }
}
