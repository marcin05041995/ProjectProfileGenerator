using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToProject.Entities;

namespace ApiToProject.Services
{
    public class ProfileGeneratorRepository
    {
        private DataBaseContext _context;

        public ProfileGeneratorRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            _context.Employees.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        //public Employee GetEmployee(Guid employeeId){ }
        //public IEnumerable<Employee> GetEmployees() { }
    }
}
