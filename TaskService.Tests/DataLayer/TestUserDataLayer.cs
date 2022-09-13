using System.Linq;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TaskService.DataLayer;
using TaskService.DataLayer.Entity;

namespace TaskService.Tests.DataLayer
{
    public class TestUserDataLayer
    {
        private UserDataLayer TestModel
        {
            get
            {
                var mockLogger = new Mock<ILogger<UserDataLayer>>();
                return new UserDataLayer(mockLogger.Object);
            }
        }
        
        [Test]
        public void Test_UserDataLayer_ReturnsListOfUsers()
        {
            var expectedUser = new UserEntity
            {
                UserId = 1,
                Name = "User 1",
                Email = "test+1@test.com"
            };
            
            var output = TestModel.FindAllUsers();
            var actualUser = (from x in output
                where x.UserId == expectedUser.UserId
                select x).First();

            actualUser.Should().BeEquivalentTo(expectedUser);
        }
    }
}