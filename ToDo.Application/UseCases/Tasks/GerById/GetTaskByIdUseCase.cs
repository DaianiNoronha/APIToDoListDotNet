using ToDo.Communication.Responses;

namespace ToDo.Application.UseCases.Tasks.GerById;
public class GetTaskByIdUseCase
{
    public ResponseToDoJson Execute(int id)
    {
        return new ResponseToDoJson
        {
            id = id,
            Name = "Lavar o cabelo (reconstrução)",
            TaskType = Communication.Enuns.TaskType.Baixa,
            TaskStatus = (TaskStatus)Communication.Enuns.TaskStatus.ToDo,
            Deadline = new DateTime(year: 2024, month: 10, day: 21),
        };
    }
}
