﻿using Employees.Models;

namespace TaskManagmentSystem.Models
{
    public class Department : UserActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

}
