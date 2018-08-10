using ApiToProject.Entities;
using ApiToProject.InputModels;
using ApiToProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiToProject.Controllers
{
    [Route("api/projects")]
    public class ProjectController:Controller
    {
        private readonly DataBaseContext context;

        public ProjectController(DataBaseContext context)
        {
            this.context = context;
        }

        private Models.ProfileProject GenerateProject(Guid Id)
        {
            var project = context.Projects.FirstOrDefault(x => x.Id == Id);
            if (project == null)
            {
                return null;
            }
            var output = new Models.ProfileProject
            {              
                Id = project.Id,      
                Name = project.Title ,
                ClientSector = project.ClientSector,
                Technologies = project.Technologies,
                StartDate = project.StartDate,
                EndDate = project.EndDate
            };
            return output;
        }

        private IList<Profile> GenerateProfile(Guid Id)
        {
            var employee = context.Projects.Include(z => z.EmployeeProjects).ThenInclude(z => z.Employee).FirstOrDefault(z => z.Id == Id);
            if (employee == null)
                return null;
            var languages = employee.EmployeeProjects;
            var output = new List<Profile>();

            foreach (var e in languages)
            {
                output.Add(new Profile
                {
                    Id = e.Employee.Id,
                    Name = e.Employee.FirstName,
                    LastName = e.Employee.LastName,
                    Specialization = e.Employee.Specialization,
                    Rating = e.Employee.Rating,
                    OverallTenure = e.Employee.YearsOfWork
                });
            }

            return output;

        }

        [Route("GetProject")]
        [HttpGet]
        public IActionResult GetProject(Guid Id)
        {
            var output = new ProjectViewModel
            {
                ProfileProject = GenerateProject(Id),
                Profiles = GenerateProfile(Id)
            };
            return StatusCode(200, output);
        }

        [Route("GetProjects")]
        [HttpGet]
        public IActionResult GetProjects()
        {
            var tmp=context.Projects.ToList();

            var output = new List<ProjectViewModel>();
                 foreach(var proj in tmp)
            {
                output.Add(new ProjectViewModel
                {
                    ProfileProject = GenerateProject(proj.Id),
                    Profiles = GenerateProfile(proj.Id)
                });
            }

            return StatusCode(200, output);
        }

        [HttpPost]
        public IActionResult AddProject(InputProjectModel inputProjectModel)
        {

            context.Projects.Add(new Project()
            {
                Title = inputProjectModel.Name,
                ClientSector = inputProjectModel.ClientSector,
                Technologies = inputProjectModel.Technologies,
                StartDate = inputProjectModel.StartDate,
                EndDate = inputProjectModel.EndDate,
            });
            context.SaveChanges();
            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpGet]
        public IActionResult EditProject(Guid id)
        {
            if (id == null)
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var project = context.Projects.FirstOrDefault(x => x.Id == id);

            if (project == null)
                return new StatusCodeResult((int)HttpStatusCode.NotFound);

            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpPost]
        public IActionResult EditProject(InputProjectModel inputProjectModel)
        {
            if (inputProjectModel == null)
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var project = context.Projects.FirstOrDefault(x => x.Id == inputProjectModel.Id);

            if (project == null)
                return new StatusCodeResult((int)HttpStatusCode.NotFound);

            project.Title = inputProjectModel.Name;
            project.ClientSector = inputProjectModel.ClientSector;
            project.Technologies = inputProjectModel.Technologies;
            project.StartDate = inputProjectModel.StartDate;
            project.EndDate = inputProjectModel.EndDate;

            context.SaveChanges();

            return StatusCode((int)HttpStatusCode.OK);
        }

        public IActionResult DeleteProject(Guid Id)
        {
            Project project = context.Projects.Find(Id);
            context.Projects.Remove(project);

            context.SaveChanges();
            return StatusCode((int)HttpStatusCode.OK);
        }
    }
}
