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
                new Employee(){Id=new Guid("1"),FirstName="Jan",LastName="Kowalski",Specialization=".Net Developer", YearsOfWork=2},
                new Employee(){Id=new Guid("2"),FirstName="Sebastian",LastName="Nowak",Specialization=".Net Developer", YearsOfWork=1},
                new Employee(){Id=new Guid("3"),FirstName="Wojtek",LastName="Sarski",Specialization=".Net Developer", YearsOfWork=3}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

        }
    }
}
