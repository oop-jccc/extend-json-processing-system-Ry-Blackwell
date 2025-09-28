using dynamic_json.Models;
using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public class ProductJsonProcessor : IJsonProcessor
{
    public bool CanProcess(JObject json)
    {
        return json.ContainsKey(nameof(Product.ProductName)) && json.ContainsKey(nameof(Product.Price));
    }

    public object? Process(JObject json)
    {
        if (!CanProcess(json)) return null;

        // Do something with product

        return json.ToObject<Product>();
    }
}