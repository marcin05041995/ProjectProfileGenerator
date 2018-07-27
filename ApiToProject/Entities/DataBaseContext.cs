using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiToProject.Entities;

namespace ApiToProject.Entities
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Projects> Projectss { get; set; }
        public DbSet<Skills> Skillss { get; set; }
        public DbSet<Languages> Languages { get; set; }
    }
}