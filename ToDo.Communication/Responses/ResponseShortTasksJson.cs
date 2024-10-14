using ToDo.Communication.Enuns;

namespace ToDo.Communication.Responses;
public class ResponseShortTasksJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public TaskType Type { get; set; }
}
