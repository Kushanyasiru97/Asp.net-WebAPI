using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        //get Todos
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get Books for School",
                Description = "Get Some Books for School Subjects",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };

            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Foods",
                Description = "Get Some Foods for Cook",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Get Bike",
                Description = "Get Bike for Travel",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(10),
                Status = TodoStatus.Inprogress
            };

            todos.Add(todo3);

            return todos;
        }

    }
}
