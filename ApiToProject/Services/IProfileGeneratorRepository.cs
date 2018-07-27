using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToProject.Entities;

namespace ApiToProject.Services
{
    public interface IProfileGeneratorRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployees(Guid employeeId);
        IEnumerable<Employee> GetEmployees(IEnumerable<Guid> employeeIds);
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        void EditEmployee(Guid id);
        void EditEmployee(Guid id, Employee e);
        bool Save();
    }
}
