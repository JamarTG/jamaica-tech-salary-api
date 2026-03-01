using JamTechSalary.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Data
{

    public class JamTechSalaryDbContext(DbContextOptions options) : DbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SurveyResponse>()
                .HasMany(c => c.CurrentLanguages)
                .WithMany()
                .UsingEntity(e => e.ToTable("SurveyCurrentLanguages"));

            modelBuilder.Entity<SurveyResponse>()
                .HasMany(c => c.PlannedLanguages)
                .WithMany()
                .UsingEntity(e => e.ToTable("SurveyPlannedLanguages"));


            modelBuilder.Entity<SurveyResponse>()
                .HasMany(c => c.JobFindingPlatforms)
                .WithMany()
                .UsingEntity(e => e.ToTable("SurveyJobFindingPlatforms"));

            modelBuilder.Entity<SurveyResponse>()
                .HasMany(c => c.JobSearchPlatforms)
                .WithMany()
                .UsingEntity(e => e.ToTable("SurveyJobSearchingPlatforms"));

        }



        public DbSet<JamTechSalary.API.Entities.SurveyResponse> SurveyResponse { get; set; } = default!;
        public DbSet<JamTechSalary.API.Entities.Benefit> Benefit { get; set; }
        public DbSet<JamTechSalary.API.Entities.AiTool> AiTool { get; set; }
        public DbSet<JamTechSalary.API.Entities.ProgrammingLanguage> ProgrammingLanguage { get; set; }
        public DbSet<JamTechSalary.API.Entities.SkillDevelopmentMethod> SkillDevelopmentMethod { get; set; }
        public DbSet<JamTechSalary.API.Entities.TechCommunity> TechCommunity { get; set; }
        public DbSet<JamTechSalary.API.Entities.JobPlatform> JobPlatform { get; set; }
    }
}