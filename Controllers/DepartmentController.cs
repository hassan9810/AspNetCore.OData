using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using ODataDemo.Context;
using ODataDemo.DTOs;
using ODataDemo.Models;

namespace ODataDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            var departments = _context.Departments.Include(emps => emps.Employees).Include(ins => ins.Instructors).ToList();
            return Ok(departments);
        }

        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment(DepartmentDTO departmentDto)
        {
            var department = new Department { Name = departmentDto.Name };
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDepartments), new { id = department.Id }, department);
        }
    }
}
