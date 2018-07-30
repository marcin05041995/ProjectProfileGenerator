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
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //modelBuilder.Entity<Employee>()
            //    .HasMany(a => a._Projects);

            //modelBuilder.Entity<Employee>()
            //    .HasMany(b => b._Skills);

            //modelBuilder.Entity<Employee>()
            //    .HasMany(c => c.Languages);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(d => d.Employees);
            ////.HasForeignKey(e=>e.EmployeeId);



            modelBuilder.Entity<EmployeeProject>()
                .HasIndex(u => new { u.ProjectId, u.EmployeeId });

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(pe => pe.Project)
                .WithMany(p => p.EmplyeeProjects)
                .HasForeignKey(pc => pc.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(pe => pe.Employee)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(pc => pc.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}