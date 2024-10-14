using ToDo.Communication.Enuns;

namespace ToDo.Communication.Requests;
public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;

    public TaskType Type { get; set; }

    public System.Threading.Tasks.TaskStatus Status { get; set; }
}

