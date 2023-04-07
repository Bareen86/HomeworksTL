using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using WebApi.Domain;
using WebApi.Dto;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        
        private static readonly List<Todo> _todos = new(); 
        private static int intIncrement = 0;
        /// <summary>
        /// Возвращает все Todo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Анонимный тип
            var result = _todos.Select(t => new { t.Id, t.Title, plannedDay = t.PlannedDay.ToString("yyyy-MM-dd hh:mm:ss") }).ToList();
            return Ok(result);
        }

        /// <summary>
        /// Возвращает Todo по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _todos.Where(t => t.Id == id).ToList();
            return Ok(result);
        }
        /// <summary>
        /// Создает Todo
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] CreateTodoDto createDto)
        {
            intIncrement++;
            Todo todo = new(intIncrement, createDto.Title);
            _todos.Add(todo);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _todos.RemoveAt(id - 1);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult InsertById(int id, [FromBody] InsertTodoDto insertDto)
        {
            _todos[id - 1] = new Todo(id, insertDto.Title);
            return Ok();
        }
    }
}
