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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Employee>()
                .HasMany(a => a.Projectss);

            modelBuilder.Entity<Employee>()
                .HasMany(b => b.Skillss);

            modelBuilder.Entity<Employee>()
                .HasMany(c => c.Languages);

            modelBuilder.Entity<Projects>()
                .HasMany(d => d.Employees);
                //.HasForeignKey(e=>e.EmployeeId);



            //modelBuilder.Entity<Employee>()
            //    .HasIndex(u => new { u.ProjectId, u.EmployeeId });

            //modelBuilder.Entity<Employee>()
            //    .HasOne(pe => pe.Projects)
            //    .WithMany(p => p.ProjectEmployees)
            //    .HasForeignKey(pc => pc.ProjectId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(pe => pe.Employee)
            //    .WithMany(p => p.ProjectEmployees)
            //    .HasForeignKey(pc => pc.EmployeeId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }

    }
}