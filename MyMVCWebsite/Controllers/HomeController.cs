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
                Description = "Build, maintain and add features throughout the company website, from front-end UX/UI improvements, " +
                "to building internal tools in the back-end. Collaborate with a team of developers using Agile methodology, " +
                "as well as work with project managers and executives closely on various projects." +
                " Projects include redesigning and rebuilding the company homepage," +
                " developing internal tools, and helping replace a third-party service with an " +
                "in-house solution that saved the company over $200,000 annually.",
                URL = "https://chalkcouture.com",
                Skills = new List<SkillModel>()
                {
                    new SkillModel() { Name = "ASP.NET", Proficiency = 1 },
                    new SkillModel() { Name = "MySQL", Proficiency = 1 },
                    new SkillModel() { Name = "Git", Proficiency = 1 },
                    new SkillModel() { Name = "C#", Proficiency = 1 },
                    new SkillModel() { Name = "AWS", Proficiency = 1 },
                }
            };

            var experience2 = new ExperienceModel()
            {
                Title = "Junior Web Developer - Concept Marketing",
                Description = "Maintained and updated over 10 different client’s websites, " +
                "including helping rebuild several from scratch. " +
                "Assisted in the development of a custom-made Wordpress theme for the company using HTML, CSS including Bootstrap, JavaScript, jQuery and PHP.",
                URL = "https://conceptmrk.com",
                Skills = new List<SkillModel>()
                {
                    new SkillModel() { Name = "Wordpress", Proficiency = 1 },
                    new SkillModel() { Name = "HTML", Proficiency = 1 },
                    new SkillModel() { Name = "CSS", Proficiency = 1 },
                    new SkillModel() { Name = "PHP", Proficiency = 1 }
                }
            };

            var experience3 = new ExperienceModel()
            {
                Title = "Part-Time Supervisor - UPS",
                Description = "Led a team of 5–10 employees through training, communication, and positive reinforcement. " +
                "While not a software development role, it helped strengthen my leadership and teamwork skills.",
                URL = "",
                Skills = new List<SkillModel>()
                {
                    new SkillModel() { Name = "Management", Proficiency = 1 },
                }
            };

            experience.Add(experience1);
            experience.Add(experience2);
            experience.Add(experience3);
            return experience;
        }
    }
}
