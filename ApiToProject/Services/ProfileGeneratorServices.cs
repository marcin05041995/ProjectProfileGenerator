using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToProject.Entities;
using ApiToProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiToProject.Services
{
    public class ProfileGeneratorServices : IProfileGeneratorServices
    {
        private DataBaseContext _context;

        public ProfileGeneratorServices(DataBaseContext context)
        {
            _context = context;
        }

        //CRUD pracownika

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployees(IEnumerable<Guid> employeeIds)
        {
            return _context.Employees.Where(a => employeeIds.Contains(a.Id))
                .OrderBy(a => a.FirstName)
                .OrderBy(a => a.LastName)
                .ToList();
        }

        public Employee GetEmployee(Guid employeeId)
        {
            return _context.Employees.FirstOrDefault(a => a.Id == employeeId);
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

        public void UpdateAuthor(Employee employee)
        {
            // no code in this implementation
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        /*----------------------------------------------------------*/


        public Project GetProject(Guid projectId)
        {
            return _context.Projects.FirstOrDefault(b => b.Id == projectId);
        }


        public IEnumerable<Project> GetProjects(Guid employeeId)
        {
            return _context.Projects.Include(x => x.EmployeeProjects).ThenInclude(z => z.Employee)
                        .Where(b => b.EmployeeProjects.Any(x => x.EmployeeId == employeeId)).OrderBy(b => b.Title).ToList();
        }

        public void AddProjectForEmployee(Guid employeeId, EmployeeProject project)
        {
            var employee = GetEmployee(employeeId);
            if (employee != null)
            {
                if (employee.Id == Guid.Empty)
                {
                    employee.Id = Guid.NewGuid();
                }
                employee.EmployeeProjects.Add(project);
            }
        }

        public void UpdateProjectForEmployee(Project project) { }

    }
}
