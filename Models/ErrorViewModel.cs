using Employees.Models;

namespace TaskManagmentSystem.Models
{
    public class LeaveType : UserActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

    }

}