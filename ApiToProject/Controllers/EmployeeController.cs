using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiToProject.Entities;
using ApiToProject.Services;

namespace ApiToProject.Controllers
{
    [Route("api/employees")]
    public class EmployeeController : Controller
    {
        private IProfileGeneratorRepository _pgRepository;

        public EmployeeController(IProfileGeneratorRepository pgRepository)
        {
            _pgRepository = pgRepository;
        }

        //[HttpGet()]
        //public IActionResult GetEmployees() { }

        //[HttpGet("{{id}}")]
        //public IActionResult GetEmployee() { }



        //private readonly DataBaseContext _context;

        //public EmployeeController(DataBaseContext context)
        //{
        //    _context = context;

        //    if (_context.Employees.Count() == 0)
        //    {
        //        _context.Employees.Add(new Employee { Id=new System.Guid(), Name="Jan" , LastName="Kowalski"  , Specialization=".NET Developer" ,YearsOfWork=2});
        //        _context.SaveChanges();
        //    }
        //}
    }
}