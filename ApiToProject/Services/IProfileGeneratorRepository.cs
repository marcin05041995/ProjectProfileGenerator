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
        //Author GetAuthor(Guid authorId);
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        bool Save();
    }
}
