using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirtsProyAPIServer.Data;
using MyFirtsProyAPIServer.Models;

namespace MyFirtsProyAPIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly MyAppContext _myAppContext;
        public EmployeeController(MyAppContext myAppContext)
        {
            _myAppContext= myAppContext;
        }
        
        [HttpGet]
        public IActionResult GetAllEmpleados()
        {
            var allEmployees = _myAppContext.Employees.ToList();
            return Ok(allEmployees);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeDTO employeeDTO)
        {
            var employeeEntity = new Employee()
            {
                Name = employeeDTO.Name,
                Phone = employeeDTO.Phone,
                Email = employeeDTO.Email,
                Salary = employeeDTO.Salary,
            };
            _myAppContext.Employees.Add(employeeEntity);
            _myAppContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employeeEntity = _myAppContext.Employees.Find(id);
            if(employeeEntity is null)
            {
                return NotFound();
            }
            _myAppContext.Employees.Remove(employeeEntity);
            _myAppContext.SaveChanges();

            return Ok();
        }

    }
}
