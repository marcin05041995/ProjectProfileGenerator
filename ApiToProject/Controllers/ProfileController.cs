using ApiToProject.Entities;
using ApiToProject.Models;
using ApiToProject.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Controllers
{
    [Route("api/employees/{employeeId}/projects")]
    public class ProfileController:Controller
    {
        private readonly DataBaseContext context;

        public ProfileController(DataBaseContext context)
        {
            this.context = context;
        }
        private Models.Profile GenerateProfile(Guid Id)
        {
            var employee = context.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee == null)
            {
                return null;
            }

            var output = new Models.Profile
            {

                Id = employee.Id,
                Name = employee.FirstName + " " + employee.LastName,
                Specialization = employee.Specialization,
                Rating = employee.Rating,
                OverallTenure = employee.YearsOfWork.ToString(),

            };

            return output;
        }

        private IList<ProfileSkill> GenerateSkills(Guid Id)
        {
            var employee = context.Employees.Include(x => x.EmployeeSkills).ThenInclude(x => x.Skill).FirstOrDefault(x => x.Id == Id);
            if (employee == null)
                return null;
            var skills = employee.EmployeeSkills;
            var output = new List<ProfileSkill>();

            foreach (var skill in skills)
            {
                output.Add(new ProfileSkill
                {
                    Id = skill.Skill.Id,
                    Name = skill.Skill.SkillName,
                    Experience = skill.ExperienceInYears,
                    Profficiency = skill.Profficiency
                });
            }

            return output;
        }

        private IList<ProfileProject> GenerateProject(Guid Id)
        {
            var employee = context.Employees.Include(z => z.EmployeeProjects).ThenInclude(z => z.Project).FirstOrDefault(z => z.Id == Id);
            if (employee == null)
                return null;

            var projects = employee.EmployeeProjects;
            var output = new List<ProfileProject>();

            foreach(var project in projects)
            {
                output.Add(new ProfileProject
                {
                    Id=project.Project.Id,
                    Name=project.Project.Title,
                    ClientSector=project.Project.ClientSector,
                    Technologies=project.Project.Technologies,
                    StartDate=project.Project.StartDate,
                    EndDate=project.Project.EndDate
                });
            }

            return output;
        }


        private IList<ProfileLanguage> GenerateLanguage(Guid Id)
        {
            var employee = context.Employees.Include(z => z.EmployeeLanguages).ThenInclude(z => z.Language).FirstOrDefault(z => z.Id == Id);
            if (employee == null)
                return null;
            var languages = employee.EmployeeLanguages;
            var output = new List<ProfileLanguage>();

            foreach(var language in languages)
            {
                output.Add(new ProfileLanguage
                {
                    Id = language.Language.Id,
                    Name = language.Language.LanguageName,
                    Speaking = language.SpeakingLevel,
                    Writing = language.WritingLevel,
                    Reading = language.ReadingLevel

                });
            }

            return output;

        }


    }
    
}

