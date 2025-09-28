namespace dynamic_json.Models;

public record Product
{
    public string? ProductName { get; init; }
    public decimal Price { get; init; }
}