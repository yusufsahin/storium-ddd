namespace Storium.Domain.ValueObjects
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }

        private Address() { } // EF Core için gerekli

        public Address(string street, string city, string state, string postalCode, string country)
        {
            if (string.IsNullOrWhiteSpace(street)) throw new ArgumentException("Street is required.");
            if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City is required.");
            if (string.IsNullOrWhiteSpace(state)) throw new ArgumentException("State is required.");
            if (string.IsNullOrWhiteSpace(postalCode)) throw new ArgumentException("Postal Code is required.");
            if (string.IsNullOrWhiteSpace(country)) throw new ArgumentException("Country is required.");

            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }
    }
}