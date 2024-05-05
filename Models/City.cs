using Employees.Models;

namespace TaskManagmentSystem.Models
{
    public class City : UserActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

}
