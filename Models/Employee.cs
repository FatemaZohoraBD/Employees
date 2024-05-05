using Employees.Models;

namespace TaskManagmentSystem.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }
        public int EmpNo { get; set; }
        public string FirstName { get; set; } = "null";
        public string MiddleName { get; set; } = "null";
        public string LastName { get; set; } = "null";
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public int PhoneNumber { get; set; }
        public string Emailaddress { get; set; } = "null";
        public string Country { get; set; } = "null";
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = "null";
        public string Department { get; set; } = "null";
        public string Designation { get; set; } = "null";


    }

}
