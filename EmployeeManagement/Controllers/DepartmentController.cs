using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly EmployeeProjectContext context;

        public DepartmentController(EmployeeProjectContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>(context.Departments).ToList();
            return View(departments);
        }
       

        public async Task<IActionResult> Details(int id)
        {
            var department = await context.Departments
                .Include(d => d.Employees) 
                .FirstOrDefaultAsync(d => d.DeptId == id);

            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }
    }
}
