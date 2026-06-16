namespace CleanApi.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Product() { }

    public static Product Create(string name, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty");

        if (price <= 0)
            throw new ArgumentException("Price must be greater than zero");

        return new Product
        {
            Id = Guid.NewGuid(),
            Name = name,
            Price = price,
            CreatedAt = DateTime.UtcNow
        };
    }

    public static Product Reconstitute(Guid id, string name, decimal price, DateTime createdAt)
    {
        return new Product
        {
            Id = id,
            Name = name,
            Price = price,
            CreatedAt = createdAt
        };
    }
}