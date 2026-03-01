using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JaTechSalary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPlatform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPlatform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    EmploymentStatus = table.Column<int>(type: "integer", nullable: false),
                    WorkLocation = table.Column<int>(type: "integer", nullable: false),
                    WorkPlace = table.Column<string>(type: "text", nullable: true),
                    Industry = table.Column<string>(type: "text", nullable: true),
                    HoursPerWeek = table.Column<int>(type: "integer", nullable: false),
                    SalaryRange = table.Column<int>(type: "integer", nullable: false),
                    SideProjectEarnings = table.Column<decimal>(type: "numeric", nullable: true),
                    SideProjectComments = table.Column<string>(type: "text", nullable: true),
                    YearsOfExperience = table.Column<int>(type: "integer", nullable: true),
                    MainAreaOfInterest = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    AgeRange = table.Column<int>(type: "integer", nullable: false),
                    ResidesInJamaica = table.Column<bool>(type: "boolean", nullable: false),
                    Parish = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    EducationLevel = table.Column<int>(type: "integer", nullable: false),
                    UniversityMajor = table.Column<string>(type: "text", nullable: true),
                    TertiaryInstitution = table.Column<string>(type: "text", nullable: true),
                    JobFindingEase = table.Column<int>(type: "integer", nullable: false),
                    CareerGoal = table.Column<int>(type: "integer", nullable: false),
                    PreferredEmploymentDestination = table.Column<string>(type: "text", nullable: true),
                    Promotion_WasPromoted = table.Column<bool>(type: "boolean", nullable: false),
                    Promotion_PromotedToRole = table.Column<string>(type: "text", nullable: true),
                    SalaryIncrease_ReceivedIncrease = table.Column<bool>(type: "boolean", nullable: false),
                    SalaryIncrease_IncreasePercentageBand = table.Column<string>(type: "text", nullable: true),
                    Layoff_WasLaidOff = table.Column<bool>(type: "boolean", nullable: false),
                    Layoff_CompanyName = table.Column<string>(type: "text", nullable: true),
                    UsesAiTools = table.Column<bool>(type: "boolean", nullable: false),
                    BelievesAiWillReplaceRole = table.Column<int>(type: "integer", nullable: false),
                    MissedAspectsComment = table.Column<string>(type: "text", nullable: true),
                    CommunityImprovementComment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AiTool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiTool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AiTool_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefit_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SkillDevelopmentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillDevelopmentMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillDevelopmentMethod_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SurveyCurrentLanguages",
                columns: table => new
                {
                    CurrentLanguagesId = table.Column<int>(type: "integer", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyCurrentLanguages", x => new { x.CurrentLanguagesId, x.SurveyResponseId });
                    table.ForeignKey(
                        name: "FK_SurveyCurrentLanguages_ProgrammingLanguage_CurrentLanguages~",
                        column: x => x.CurrentLanguagesId,
                        principalTable: "ProgrammingLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyCurrentLanguages_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyJobFindingPlatforms",
                columns: table => new
                {
                    JobFindingPlatformsId = table.Column<int>(type: "integer", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyJobFindingPlatforms", x => new { x.JobFindingPlatformsId, x.SurveyResponseId });
                    table.ForeignKey(
                        name: "FK_SurveyJobFindingPlatforms_JobPlatform_JobFindingPlatformsId",
                        column: x => x.JobFindingPlatformsId,
                        principalTable: "JobPlatform",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyJobFindingPlatforms_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyJobSearchingPlatforms",
                columns: table => new
                {
                    JobSearchPlatformsId = table.Column<int>(type: "integer", nullable: false),
                    SurveyResponse1Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyJobSearchingPlatforms", x => new { x.JobSearchPlatformsId, x.SurveyResponse1Id });
                    table.ForeignKey(
                        name: "FK_SurveyJobSearchingPlatforms_JobPlatform_JobSearchPlatformsId",
                        column: x => x.JobSearchPlatformsId,
                        principalTable: "JobPlatform",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyJobSearchingPlatforms_SurveyResponse_SurveyResponse1Id",
                        column: x => x.SurveyResponse1Id,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyPlannedLanguages",
                columns: table => new
                {
                    PlannedLanguagesId = table.Column<int>(type: "integer", nullable: false),
                    SurveyResponse1Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyPlannedLanguages", x => new { x.PlannedLanguagesId, x.SurveyResponse1Id });
                    table.ForeignKey(
                        name: "FK_SurveyPlannedLanguages_ProgrammingLanguage_PlannedLanguages~",
                        column: x => x.PlannedLanguagesId,
                        principalTable: "ProgrammingLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyPlannedLanguages_SurveyResponse_SurveyResponse1Id",
                        column: x => x.SurveyResponse1Id,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechCommunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechCommunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechCommunity_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AiTool_SurveyResponseId",
                table: "AiTool",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_SurveyResponseId",
                table: "Benefit",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillDevelopmentMethod_SurveyResponseId",
                table: "SkillDevelopmentMethod",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyCurrentLanguages_SurveyResponseId",
                table: "SurveyCurrentLanguages",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyJobFindingPlatforms_SurveyResponseId",
                table: "SurveyJobFindingPlatforms",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyJobSearchingPlatforms_SurveyResponse1Id",
                table: "SurveyJobSearchingPlatforms",
                column: "SurveyResponse1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyPlannedLanguages_SurveyResponse1Id",
                table: "SurveyPlannedLanguages",
                column: "SurveyResponse1Id");

            migrationBuilder.CreateIndex(
                name: "IX_TechCommunity_SurveyResponseId",
                table: "TechCommunity",
                column: "SurveyResponseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AiTool");

            migrationBuilder.DropTable(
                name: "Benefit");

            migrationBuilder.DropTable(
                name: "SkillDevelopmentMethod");

            migrationBuilder.DropTable(
                name: "SurveyCurrentLanguages");

            migrationBuilder.DropTable(
                name: "SurveyJobFindingPlatforms");

            migrationBuilder.DropTable(
                name: "SurveyJobSearchingPlatforms");

            migrationBuilder.DropTable(
                name: "SurveyPlannedLanguages");

            migrationBuilder.DropTable(
                name: "TechCommunity");

            migrationBuilder.DropTable(
                name: "JobPlatform");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");

            migrationBuilder.DropTable(
                name: "SurveyResponse");
        }
    }
}
