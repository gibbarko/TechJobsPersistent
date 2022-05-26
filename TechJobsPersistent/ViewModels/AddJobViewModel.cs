using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        private JobDbContext context;

        public AddJobViewModel(JobDbContext dbContext)
        {
            context = dbContext;
        }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> employersHere, List<Skill> skillsHere)
        {
            Employers = new List<SelectListItem>();

            Skills = skillsHere;

            foreach (var employer in employersHere)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

        }

        public AddJobViewModel()
        {
        }

        //Skill stuff

        public int SkillId { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
