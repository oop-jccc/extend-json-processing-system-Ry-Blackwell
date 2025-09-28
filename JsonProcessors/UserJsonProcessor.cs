using dynamic_json.Models;
using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public class UserJsonProcessor : BaseJsonProcessor<User>
{
    // "{\"Name\":\"John Doe\",\"Email\":\"john.doe@example.com\"}"
    public override bool CanProcess(JObject json)
    {
        return json.ContainsKey(nameof(User.Name)) && json.ContainsKey(nameof(User.Email));
    }

    protected override User? ProcessInternal(JObject json)
    {
        var user = json.ToObject<User>();

        // update user
        return user! with { Name = "John Doe 2" };
    }
}