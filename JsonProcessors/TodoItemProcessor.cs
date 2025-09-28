using dynamic_json.Models;
using Newtonsoft.Json.Linq;

namespace dynamic_json.JsonProcessors;

public class TodoItemProcessor : BaseJsonProcessor<TodoItem>
{
    // Example JSON: "{\"Title\":\"Buy Milk\",\"IsCompleted\":false}"
    public override bool CanProcess(JObject json)
    {
        return json.ContainsKey(nameof(TodoItem.Title)) &&
               json.ContainsKey(nameof(TodoItem.IsCompleted));
    }

    protected override TodoItem? ProcessInternal(JObject json)
    {
        var todoItem = json.ToObject<TodoItem>();

        return todoItem! with
        {
            IsCompleted = true
        };
    }
}