using System;
using System.Collections.Generic;

namespace TaskService.DataLayer.Entity
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}