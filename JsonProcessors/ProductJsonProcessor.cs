using dynamic_json.Models;
using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public class ProductJsonProcessor : BaseJsonProcessor<Product>
{
    public override bool CanProcess(JObject json)
    {
        return json.ContainsKey(nameof(Product.ProductName)) && json.ContainsKey(nameof(Product.Price));
    }

    protected override Product? ProcessInternal(JObject json)
    {
        return json.ToObject<Product>();
    }
}