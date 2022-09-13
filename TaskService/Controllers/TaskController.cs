using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskModels;

namespace TaskService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController
    {
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return new List<Task>
            {
                new Task { TaskId = 1, TaskName = "Task 1", Description = "Test Description", IsComplete = true },
                new Task { TaskId = 2, TaskName = "Task 2", Description = "Test Description", IsComplete = false },
                new Task { TaskId = 3, TaskName = "Task 3", Description = "Test Description", IsComplete = false },
                new Task { TaskId = 4, TaskName = "Task 4", Description = "Test Description", IsComplete = true },
            };
        }
    }
}