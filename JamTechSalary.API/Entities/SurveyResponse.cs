using JamTechSalary.API.Enums;

namespace JamTechSalary.API.Entities
{

    public class SurveyResponse
    {
   
        public int Id { get; set; }

   
        public string? JobTitle { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string? WorkPlace { get; set; }               
        public string? Industry { get; set; }
        public HoursPerWeek HoursPerWeek { get; set; }
        public SalaryRange SalaryRange { get; set; }
        public decimal? SideProjectEarnings { get; set; }   
        public string? SideProjectComments { get; set; }
        public int? YearsOfExperience { get; set; }
        public string? MainAreaOfInterest { get; set; }     

        public Gender Gender { get; set; }
        public AgeRange AgeRange { get; set; }
        public bool ResidesInJamaica { get; set; }
        public string? Parish { get; set; }
        public string? Country { get; set; }

        public EducationLevel EducationLevel { get; set; }
        public string? UniversityMajor { get; set; }
        public string? TertiaryInstitution { get; set; }


        public JobFindingEase JobFindingEase { get; set; }
        public CareerGoal CareerGoal { get; set; }
        public string? PreferredEmploymentDestination { get; set; }  

     
        public PromotionRecord Promotion { get; set; } = new();
        public SalaryIncreaseRecord SalaryIncrease { get; set; } = new();
        public LayoffRecord Layoff { get; set; } = new();


        public bool UsesAiTools { get; set; }
        public AiReplacement BelievesAiWillReplaceRole { get; set; }

     
        public string? MissedAspectsComment { get; set; }
        public string? CommunityImprovementComment { get; set; }

        public List<ProgrammingLanguage> CurrentLanguages { get; set; } = [];
        public List<ProgrammingLanguage> PlannedLanguages { get; set; } = [];
        public List<SkillDevelopmentMethod> SkillDevelopmentMethods { get; set; } = [];
        public List<Benefit> Benefits { get; set; } = [];
        public List<AiTool> AiToolsUsed { get; set; } = [];
        public List<TechCommunity> TechCommunities { get; set; } = [];
        public List<JobPlatform> JobSearchPlatforms { get; set; } = [];
        public List<JobPlatform> JobFindingPlatforms { get; set; } = [];  
    }
}
