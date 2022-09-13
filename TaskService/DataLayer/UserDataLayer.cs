using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using TaskService.DataLayer.Entity;

namespace TaskService.DataLayer
{
    public interface IUserData
    {
        IEnumerable<UserEntity> FindAllUsers();
    }
    
    public class UserDataLayer : IUserData
    {
        private readonly ILogger<UserDataLayer> _logger;

        public UserDataLayer(ILogger<UserDataLayer> logger)
        {
            _logger = logger;
        }
        
        public IEnumerable<UserEntity> FindAllUsers()
        {
            _logger.LogDebug("Request to get all users");
            return new List<UserEntity>
            {
                new UserEntity {UserId = 1, Name = "User 1", Email = "test+1@test.com"},
                new UserEntity {UserId = 2, Name = "User 2", Email = "test+2@test.com"},
                new UserEntity {UserId = 3, Name = "User 3", Email = "test+3@test.com"},
            };
        }
    }
}