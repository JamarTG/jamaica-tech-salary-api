using System.ComponentModel.DataAnnotations;
using JamTechSalary.API.Enums;

namespace JamTechSalary.API.Entities
{

    public class SurveyResponse
    {
        [Required]
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        
        [Required]
        public EmploymentStatus EmploymentStatus { get; set; }
   
        [Required]
        public WorkLocation WorkLocation { get; set; }

        public string? WorkPlace { get; set; }               
        public string? Industry { get; set; }
        
        [Required]
        public HoursPerWeek HoursPerWeek { get; set; }

        [Required]
        public SalaryRange SalaryRange { get; set; }
        public decimal? SideProjectEarnings { get; set; }   
        public string? SideProjectComments { get; set; }
        public int? YearsOfExperience { get; set; }
        public string? MainAreaOfInterest { get; set; }

        [Required]
        public Gender Gender { get; set; }
        
        [Required]
        public AgeRange AgeRange { get; set; }

        [Required]
        public bool ResidesInJamaica { get; set; }
        
        public string? Parish { get; set; }
        public string? Country { get; set; }

        [Required]
        public EducationLevel EducationLevel { get; set; }
        public string? UniversityMajor { get; set; }
        public string? TertiaryInstitution { get; set; }

        [Required]
        public JobFindingEase JobFindingEase { get; set; }
        
        [Required]
        public CareerGoal CareerGoal { get; set; }
        public string? PreferredEmploymentDestination { get; set; }

        [Required]
        public PromotionRecord Promotion { get; set; } = new();
        
        [Required]
        public SalaryIncreaseRecord SalaryIncrease { get; set; } = new();

        [Required]
        public LayoffRecord Layoff { get; set; } = new();

        [Required]
        public bool UsesAiTools { get; set; }

        [Required]
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
