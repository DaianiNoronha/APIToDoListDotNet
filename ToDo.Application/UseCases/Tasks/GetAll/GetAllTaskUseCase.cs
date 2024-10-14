using ToDo.Communication.Responses;

namespace ToDo.Application.UseCases.Tasks.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTasksJson>
            {
                new ResponseShortTasksJson
                {
                    Id = 1,
                    Name = "Estudar .NET",
                    Type = Communication.Enuns.TaskType.Alta
                },

                new ResponseShortTasksJson 
                {
                    Id= 2,
                    Name = "Ir para academia",
                    Type = Communication.Enuns.TaskType.Media
                }
            }
        };
    }
}
