namespace EmployeeAdminPortal.Models.Entities
{
    public class Employees
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Salary { get; set; }


    }
}