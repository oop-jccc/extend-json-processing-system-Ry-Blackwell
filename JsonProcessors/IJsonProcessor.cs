using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public interface IJsonProcessor
{
    bool CanProcess(JObject json);
    object? Process(JObject json);
}