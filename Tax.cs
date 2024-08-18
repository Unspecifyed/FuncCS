namespace FuncCS
{
    // Define your classes and records here
    public record Product(string Name, decimal Price, bool IsFood);
    public record Address(string Country);

    public record Order(Product Product, int Quantity)
    {
        public decimal NetPrice => Product.Price * Quantity;
    }

    public static class TaxCalculator
    {
        public static decimal Vat(Address address, Order order)
            => Vat(RateByCountry(address.Country), order);

        public static decimal RateByCountry(string country)
            => country switch
            {
                "US" => 0.05m,
                "UK" => 0.2m,
                _ => throw new ArgumentException($"Unknown country: {country}")
            };

        public static decimal Vat(decimal rate, Order order)
            => order.NetPrice * rate;
    }
}
