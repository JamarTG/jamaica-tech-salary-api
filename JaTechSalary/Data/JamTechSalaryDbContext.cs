using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Data
{
    public class JamTechSalaryDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<JamTechSalary.API.Entities.SurveyResponse> SurveyResponse { get; set; } = default!;
        public DbSet<JamTechSalary.API.Entities.Benefit> Benefit { get; set; }
        public DbSet<JamTechSalary.API.Entities.AiTool> AiTool { get; set; }
        public DbSet<JamTechSalary.API.Entities.ProgrammingLanguage> ProgrammingLanguage { get; set; }
        public DbSet<JamTechSalary.API.Entities.SkillDevelopmentMethod> SkillDevelopmentMethod { get; set; }
        public DbSet<JamTechSalary.API.Entities.TechCommunity> TechCommunity { get; set; }
        public DbSet<JamTechSalary.API.Entities.JobPlatform> JobPlatform { get; set; }
    }
}