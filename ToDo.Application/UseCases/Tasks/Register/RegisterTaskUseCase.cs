using ToDo.Communication.Responses;
using ToDo.Communication.Requests;

namespace ToDo.Application.UseCases.Tasks.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            Id = 7,
            Name = request.Name,
        };
    }
}
