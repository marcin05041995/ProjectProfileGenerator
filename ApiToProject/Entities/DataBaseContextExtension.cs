using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public static class DataBaseContextExtension
    {
        public static void SeedDataForContext(this DataBaseContext context)
        {
            context.Employees.RemoveRange(context.Employees);
            context.SaveChanges();

            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id =new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                    FirstName ="Jan",
                    LastName ="Kowalski",
                    Specialization =".Net Developer",
                    Rating =3,
                    YearsOfWork =2 // ,
                        //EmployeeProjects = new List<EmployeeProject>()
                        //{
                        //    new EmployeeProject()
                        //    {
                        //        Id=new Guid(),
                        //        Title="",
                        //        ClientSector="",
                        //        StartDate=new DateTimeOffset(new DateTime(2017,10,23)),
                        //        EndDate=new DateTimeOffset(new DateTime(2017,11,28))
                        //    }
                        //}
                },
                new Employee(){Id=new Guid("35320c5e-f58a-4b1f-b63a-8ee07a840bdf"),FirstName="Sebastian",LastName="Nowak",Specialization=".Net Developer", Rating=2, YearsOfWork=1},
                new Employee(){Id=new Guid("45320c5e-f58a-4b1f-b63a-8ee07a840bdf"),FirstName="Wojtek",LastName="Sarski",Specialization=".Net Developer", Rating=4, YearsOfWork=3}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

        }
    }
}
