using System.Collections.Generic;

namespace MyMVCWebsite.Models
{
    public class ExperienceModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List<SkillModel> Skills { get; set; }
    }
}
