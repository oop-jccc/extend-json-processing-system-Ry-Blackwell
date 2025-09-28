using dynamic_json.JsonProcessors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace dynamic_json.Controllers;

[ApiController]
[Route("[controller]")]
public class JsonController : ControllerBase
{
    private readonly IEnumerable<IJsonProcessor> _processors;

    public JsonController(IEnumerable<IJsonProcessor> processors)
    {
        _processors = processors;
    }

    [HttpPost()]
    public ActionResult Post([FromBody] string jsonString)
    {
        return Ok(ProcessJsonString(jsonString));
    }

    private object? ProcessJsonString(string jsonString)
    {
        var json = JObject.Parse(jsonString);

        var result = _processors
            .Select(processor => processor.Process(json))
            .FirstOrDefault(res => res != null);

        return result;

    }
}