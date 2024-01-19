using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoesController : ControllerBase
    {
        private TodoService _todoService;

        public TodoesController() ///ctor (Constructor)
        {
            _todoService = new TodoService();
        }

        [HttpGet("{Id?}")]
        public IActionResult GetTodos(int? Id)
        {
            var myTodos = _todoService.AllTodos();

            if(Id is null) 
                return Ok(myTodos);

            myTodos = _todoService.AllTodos().Where(t => t.Id == Id).ToList();

            return Ok(myTodos);
        }

    }
}
