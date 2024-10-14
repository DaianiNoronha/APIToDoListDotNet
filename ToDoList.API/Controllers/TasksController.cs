using Microsoft.AspNetCore.Mvc;
using ToDo.Application.UseCases.Tasks.Delete;
using ToDo.Application.UseCases.Tasks.GerById;
using ToDo.Application.UseCases.Tasks.GetAll;
using ToDo.Application.UseCases.Tasks.Register;
using ToDo.Application.UseCases.Tasks.Update;
using ToDo.Communication.Requests;
using ToDo.Communication.Responses;

namespace ToDoList.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    [HttpPost] 
    [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var responde = useCase.Execute(request);
        return Created(string.Empty, responde);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]

    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetAll() 
    {
        var useCase = new GetAllTaskUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseToDoJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

    public IActionResult Get(int id)
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("id")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskByIdUseCase();
        useCase.Execute(id);
        return NoContent();
    }
}
