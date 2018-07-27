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
                new Employee(){Id=new Guid(),Name="Jan",LastName="Kowalski",Specialization=".Net Developer", YearsOfWork=2}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

        }
    }
}
