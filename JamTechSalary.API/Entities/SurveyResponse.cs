using JamTechSalary.API.Enums;

namespace JamTechSalary.API.Entities
{

    // ─── Root survey response ─────────────────────────────────────────────────

    public class SurveyResponse
    {
        // Identity
        public int Id { get; set; }

        // Professional info
        public string? JobTitle { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string? WorkPlace { get; set; }               // "Financial institutions", "Prefer Not To Say", etc.
        public string? Industry { get; set; }
        public HoursPerWeek HoursPerWeek { get; set; }
        public SalaryRange SalaryRange { get; set; }
        public decimal? SideProjectEarnings { get; set; }   // Monthly JMD
        public string? SideProjectComments { get; set; }
        public int? YearsOfExperience { get; set; }
        public string? MainAreaOfInterest { get; set; }     // e.g. "Database Management"

        // Demographics
        public Gender Gender { get; set; }
        public AgeRange AgeRange { get; set; }
        public bool ResidesInJamaica { get; set; }
        public string? Parish { get; set; }
        public string? Country { get; set; }

        // Education
        public EducationLevel EducationLevel { get; set; }
        public string? UniversityMajor { get; set; }
        public string? TertiaryInstitution { get; set; }

        // Career mobility
        public JobFindingEase JobFindingEase { get; set; }
        public CareerGoal CareerGoal { get; set; }
        public string? PreferredEmploymentDestination { get; set; }  // "Overseas", specific companies, etc.

        // Career events (past 2 years)
        public PromotionRecord Promotion { get; set; } = new();
        public SalaryIncreaseRecord SalaryIncrease { get; set; } = new();
        public LayoffRecord Layoff { get; set; } = new();

        // AI
        public bool UsesAiTools { get; set; }
        public AiReplacement BelievesAiWillReplaceRole { get; set; }

        // Free-text feedback
        public string? MissedAspectsComment { get; set; }
        public string? CommunityImprovementComment { get; set; }

        // ── Many-to-many relationships ──────────────────────────────────────
        public List<ProgrammingLanguage> CurrentLanguages { get; set; } = new();
        public List<ProgrammingLanguage> PlannedLanguages { get; set; } = new();
        public List<SkillDevelopmentMethod> SkillDevelopmentMethods { get; set; } = new();
        public List<Benefit> Benefits { get; set; } = new();
        public List<AiTool> AiToolsUsed { get; set; } = new();
        public List<TechCommunity> TechCommunities { get; set; } = new();
        public List<JobPlatform> JobSearchPlatforms { get; set; } = new();
        public List<JobPlatform> JobFindingPlatforms { get; set; } = new();  // "How did you get your job?"
    }
}
