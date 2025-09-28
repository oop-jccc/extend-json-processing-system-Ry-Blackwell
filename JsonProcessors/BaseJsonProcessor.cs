using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public abstract class BaseJsonProcessor<T> : IJsonProcessor
{
    public object? Process(JObject json)
    {
        return !CanProcess(json) ? null : ProcessInternal(json);
    }

    public abstract bool CanProcess(JObject json);
    protected abstract T? ProcessInternal(JObject json);
}