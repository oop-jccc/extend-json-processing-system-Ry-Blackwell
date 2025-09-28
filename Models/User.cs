namespace dynamic_json.Models;

public record User 
{
    public string? Name { get; init; }
    public string? Email { get; init; }
}