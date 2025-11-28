using Microsoft.EntityFrameworkCore;
using MyFirtsProyAPIServer.Models;

namespace MyFirtsProyAPIServer.Data
{
    public class MyAppContext:DbContext
    {
        public MyAppContext(DbContextOptions options):base(options) { 
        
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
