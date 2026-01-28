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
                Skills = await GetSkills()
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

        public async Task<List<Skill>> GetSkills()
        {
            var skills = new List<Skill>();
            var skill1 = new Skill()
            {
                Name = "ASP.Net",
                Proficiency = 1
            };

            var skill2 = new Skill()
            {
                Name = "MySQL",
                Proficiency = 1
            };
            var skill3 = new Skill()
            {
                Name = "skill",
                Proficiency = 1
            };
            var skill4 = new Skill()
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
    }
}
