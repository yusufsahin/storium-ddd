namespace Storium.Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }

        public Money(decimal amount, Currency currency)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
            Amount = amount;
            Currency = currency;
        }

        public Money Add(Money other)
        {
            EnsureSameCurrency(other);
            return new Money(Amount + other.Amount, Currency);
        }

        public Money Multiply(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        private void EnsureSameCurrency(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Currencies must match.");
        }

        public override string ToString()
        {
            return $"{Amount:F2} {Currency}";
        }
    }
}