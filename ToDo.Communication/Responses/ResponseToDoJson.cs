using ToDo.Communication.Enuns;

namespace ToDo.Communication.Responses;
public class ResponseToDoJson
{
    public int id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TaskType TaskType { get; set; }

    public DateTime Deadline { get; set; }

    public System.Threading.Tasks.TaskStatus TaskStatus { get; set; }
}

