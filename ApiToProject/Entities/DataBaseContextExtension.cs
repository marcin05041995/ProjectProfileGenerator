using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataBaseContext>();
            context.Database.EnsureCreated();
            if (!context.Employees.Any())
            {

                try
                {
                    var employees = new List<Employee>()
                {
                new Employee(){ FirstName ="Jan", LastName ="Kowalski", Specialization =".Net Developer",Rating =3,YearsOfWork =2 },
                new Employee(){FirstName="Sebastian",LastName="Nowak",Specialization=".Net Developer", Rating=2, YearsOfWork=1},
                new Employee(){FirstName="Wojtek",LastName="Sarski",Specialization=".Net Developer", Rating=4, YearsOfWork=3}
                };

                    var projects = new List<Project>()
                {
                    new Project(){Title="Linora-Application for managing animal transport",ClientSector="Transport animal",Technologies=".Net/C#, MVC 5, MS SQL",StartDate=new DateTime(2017,11,21),EndDate=new DateTime(2017,12,14)},
                    new Project(){Title="Be-there- Appliacation for managing events and ticket brokering",ClientSector="Services",Technologies=".Net/C#, ASP.NET Core, AngularJS 2,TypeScript,Web API",StartDate=new DateTime(2018,01,10),EndDate=new DateTime(2018,02,04)},
                    new Project(){Title="Ecologistics",ClientSector="Spedition",Technologies=".Net/C#, MS SQL, MVC 5",StartDate=new DateTime(2018,02,10),EndDate=new DateTime(2018,03,15)}
                };



                    context.Projects.AddRange(projects);
                    context.Employees.AddRange(employees);
                    context.SaveChanges();

                    var employeeproject = new List<EmployeeProject>() {
                 new EmployeeProject { EmployeeId=employees[0].Id,ProjectId=projects[0].Id},
                 new EmployeeProject { EmployeeId=employees[0].Id,ProjectId=projects[1].Id}
                };

                    context.EmployeeProjects.AddRange(employeeproject);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                }

            }
        }
    }
}
