using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToProject.Entities;
using ApiToProject.Models;
using Microsoft.AspNetCore.Mvc;

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
            //employee.Id = Guid.NewGuid();
            _context.Employees.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }


        //Edit Efekty nieznane :)
        //[HttpGet]
        //public void EditEmployee(Guid id)
        //{
        //    Employee e = new Employee();

        //    if(id != null)
        //    {
        //        Employee employee = new Employee();
        //        if(employee != null)
        //        {
        //            e.Id = employee.Id;
        //            e.FirstName = employee.FirstName;
        //            e.LastName = employee.LastName;
        //            e.Specialization = employee.Specialization;
        //            e.Rating = employee.Rating;
        //            e.YearsOfWork = employee.YearsOfWork;
        //        }
        //    }
        //}

        //[HttpPost]
        //public void EditEmployee(int id, Employee e)
        //{
        //    bool IsNew = id != null; 
        //    Employee employee= IsNew ? new Employee { }: 
        //    _context.Set<Employee>().SingleOrDefault(s => s.Id == id);

        //    employee.FirstName = e.FirstName;
        //    employee.LastName = e.LastName;
        //    employee.Specialization = e.Specialization;
        //    employee.Rating = e.Rating;
        //    employee.YearsOfWork = e.YearsOfWork;

        //    _context.SaveChanges();
        //}

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        //public Employee GetEmployee(Guid employeeId){ }
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .ToList();
        }

        public IEnumerable<Employee> GetEmployees(IEnumerable<int> employeeIds)
        {
            return _context.Employees.Where(a => employeeIds.Contains(a.Id))
                .OrderBy(a => a.FirstName)
                .OrderBy(a => a.LastName)
                .ToList();
        }

        public Employee GetEmployee(int employeeId)
        {
            return _context.Employees.FirstOrDefault(a => a.Id == employeeId);
        }
    }
}
