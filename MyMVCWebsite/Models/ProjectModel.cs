using System.Collections.Generic;

namespace MyMVCWebsite.Models
{
    public class ProjectModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        // Using string for now, maybe DateTime later if needed
        public string ProjectDate { get; set; }

        public string URL { get; set; }

        public List<SkillModel> Skills { get; set; }
    }
}
