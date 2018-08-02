using ApiToProject.Entities;
using ApiToProject.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiToProject.Controllers
{
    [Route("api/skills")]
    public class SkillController:Controller
    {
        private readonly DataBaseContext context;

        public SkillController(DataBaseContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult AddSkill(InputSkillModel inputSkillModel)
        {

            context.Skills.Add(new Skill()
            {
                SkillName = inputSkillModel.Name,
                ExperienceInYears = inputSkillModel.Experience,
                Profficiency = inputSkillModel.Profficiency
                
            });

            //context.EmployeeSkills.Add(new EmployeeSkill()
            //{
            //    ExperienceInYears = inputSkillModel.Experience,
            //    Profficiency = inputSkillModel.Profficiency
            //});

            context.SaveChanges();
            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpGet]
        public IActionResult EditSkill(Guid id)
        {
            if (id == null)
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var skill = context.Skills.FirstOrDefault(x => x.Id == id);
            //var employeeskill = context.EmployeeSkills.FirstOrDefault(x => x.Id == id);

            if (skill == null /*|| employeeskill==null*/)
                return new StatusCodeResult((int)HttpStatusCode.NotFound);

            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpPost]
        public IActionResult EditSkill(InputSkillModel inputSkillModel)
        {
            if (inputSkillModel == null)
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var skill = context.Skills.FirstOrDefault(x => x.Id == inputSkillModel.Id);
            //var employeeskill = context.EmployeeSkills.FirstOrDefault(x => x.Id == inputSkillModel.Id);

            if (skill == null /*|| employeeskill == null*/)
                return new StatusCodeResult((int)HttpStatusCode.NotFound);

            skill.SkillName = inputSkillModel.Name;
            skill.ExperienceInYears = inputSkillModel.Experience;
            skill.Profficiency = inputSkillModel.Profficiency;
            //employeeskill.ExperienceInYears = inputSkillModel.Experience;
            //employeeskill.Profficiency = inputSkillModel.Profficiency;

            context.SaveChanges();

            return StatusCode((int)HttpStatusCode.OK);
        }

        public IActionResult DeleteSkill(Guid Id)
        {
            Skill skill = context.Skills.Find(Id);
            context.Skills.Remove(skill);

            //EmployeeSkill employeeSkill = context.EmployeeSkills.Find(Id);
            //context.EmployeeSkills.Remove(employeeSkill);

            context.SaveChanges();
            return StatusCode((int)HttpStatusCode.OK);
        }
    }
}
