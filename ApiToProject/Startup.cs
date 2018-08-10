using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiToProject.Entities;
using ApiToProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace ApiToProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<DataBaseContext>(opt =>
            //    opt.UseInMemoryDatabase("EmployeeList"));
            services.AddMvc();

            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=DbProfileGenerator;Trusted_Connection=True;";
            services.AddDbContext<DataBaseContext>(o => o.UseSqlServer(connectionString));

            //register repo
            services.AddScoped<IProfileGeneratorServices, ProfileGeneratorServices> ();
            //services.AddCors();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .SetPreflightMaxAge(TimeSpan.FromSeconds(2520))
                        .Build());
            });

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DataBaseContext dataBaseContext)
        {
            

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Employee, Models.Profile>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src =>
                       $"{src.FirstName} {src.LastName} {src.Specialization} {src.YearsOfWork}"));

                cfg.CreateMap<InputModels.InputEmployeeModel, Entities.Employee>();
            });

            //app.UseCors(builder =>
            //    builder.WithOrigins("http://localhost:8080/#/employee"));

            app.UseCors("CorsPolicy");
            app.UseMvc();

            


        }
    }
}