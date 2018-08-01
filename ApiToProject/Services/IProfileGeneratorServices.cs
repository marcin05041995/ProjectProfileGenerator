using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToProject.Entities;


namespace ApiToProject.Services
{
    public interface IProfileGeneratorServices
    {
        /*------------Employee--------------*/
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(Guid employeeId);
        IEnumerable<Employee> GetEmployees(IEnumerable<Guid> employeeIds);
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        void UpdateAuthor(Employee employee);

        /*------------Project--------------*/
        //IEnumerable<EmployeeProject> GetProjectsForEmployee(Guid employeeId);
        //EmployeeProject GetProjectForEmployee(Guid employeeId, Guid projectId);
        Project GetProject(Guid projectId);
        IEnumerable<Project> GetProjects(Guid employeeId);
        void AddProjectForEmployee(Guid employeeId, EmployeeProject project);
        void UpdateProjectForEmployee(Project project);

        bool Save();
    }
}
