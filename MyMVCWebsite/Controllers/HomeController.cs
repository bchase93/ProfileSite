using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMVCWebsite.Models;

namespace MyMVCWebsite.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel()
            {
                IntroText = "Wecome to my website",
                //Skills = await GetSkills(),
                Experience = await GetExperience()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<List<SkillModel>> GetSkills()
        {
            var skills = new List<SkillModel>();
            var skill1 = new SkillModel()
            {
                Name = "ASP.Net",
                Proficiency = 1
            };

            var skill2 = new SkillModel()
            {
                Name = "MySQL",
                Proficiency = 1
            };
            var skill3 = new SkillModel()
            {
                Name = "skill",
                Proficiency = 1
            };
            var skill4 = new SkillModel()
            {
                Name = "andother skill",
                Proficiency = 1
            };
            skills.Add(skill1);
            skills.Add(skill2);
            skills.Add(skill3);
            skills.Add(skill4);
            return skills;
        }

        public async Task<List<ExperienceModel>> GetExperience()
        {
            var experience = new List<ExperienceModel>();
            var experience1 = new ExperienceModel()
            {
                Title = "Software Developer - Chalk Couture",
                Description = "Build and maintain web applications using ASP.Net and MySQL.",
                URL = "https://chalkcouture.com",
                Skills = new List<SkillModel>()
                {
                    new SkillModel() { Name = "ASP.Net", Proficiency = 1 },
                    new SkillModel() { Name = "MySQL", Proficiency = 1 }
                }
            };

            experience.Add(experience1);
            return experience;
        }
    }
}
