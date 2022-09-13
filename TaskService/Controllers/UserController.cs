using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskModels;
using TaskService.DataLayer;

namespace TaskService.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class UserController
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserData _userData;

        public UserController(ILogger<UserController> logger, IUserData userData)
        {
            _logger = logger;
            _userData = userData;
        }
            
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return from user in _userData.FindAllUsers()
                select new User
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Email = user.Email
                };
        }
    }
}