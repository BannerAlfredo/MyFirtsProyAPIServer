namespace MyFirtsProyAPIServer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public required string Email { get; set; }
        public decimal Salary { get; set; }

    }
}
