using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace JaTechSalary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SurveyResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    JobTitle = table.Column<string>(type: "longtext", nullable: true),
                    EmploymentStatus = table.Column<int>(type: "int", nullable: false),
                    WorkLocation = table.Column<int>(type: "int", nullable: false),
                    WorkPlace = table.Column<string>(type: "longtext", nullable: true),
                    Industry = table.Column<string>(type: "longtext", nullable: true),
                    HoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    SalaryRange = table.Column<int>(type: "int", nullable: false),
                    SideProjectEarnings = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SideProjectComments = table.Column<string>(type: "longtext", nullable: true),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    MainAreaOfInterest = table.Column<string>(type: "longtext", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    AgeRange = table.Column<int>(type: "int", nullable: false),
                    ResidesInJamaica = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Parish = table.Column<string>(type: "longtext", nullable: true),
                    Country = table.Column<string>(type: "longtext", nullable: true),
                    EducationLevel = table.Column<int>(type: "int", nullable: false),
                    UniversityMajor = table.Column<string>(type: "longtext", nullable: true),
                    TertiaryInstitution = table.Column<string>(type: "longtext", nullable: true),
                    JobFindingEase = table.Column<int>(type: "int", nullable: false),
                    CareerGoal = table.Column<int>(type: "int", nullable: false),
                    PreferredEmploymentDestination = table.Column<string>(type: "longtext", nullable: true),
                    Promotion_WasPromoted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Promotion_PromotedToRole = table.Column<string>(type: "longtext", nullable: true),
                    SalaryIncrease_ReceivedIncrease = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SalaryIncrease_IncreasePercentageBand = table.Column<string>(type: "longtext", nullable: true),
                    Layoff_WasLaidOff = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Layoff_CompanyName = table.Column<string>(type: "longtext", nullable: true),
                    UsesAiTools = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BelievesAiWillReplaceRole = table.Column<int>(type: "int", nullable: false),
                    MissedAspectsComment = table.Column<string>(type: "longtext", nullable: true),
                    CommunityImprovementComment = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponse", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AiTool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiTool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AiTool_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefit_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "JobPlatform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "int", nullable: true),
                    SurveyResponseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPlatform", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPlatform_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobPlatform_SurveyResponse_SurveyResponseId1",
                        column: x => x.SurveyResponseId1,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "int", nullable: true),
                    SurveyResponseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguage_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguage_SurveyResponse_SurveyResponseId1",
                        column: x => x.SurveyResponseId1,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillDevelopmentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillDevelopmentMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillDevelopmentMethod_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TechCommunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    SurveyResponseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechCommunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechCommunity_SurveyResponse_SurveyResponseId",
                        column: x => x.SurveyResponseId,
                        principalTable: "SurveyResponse",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AiTool_SurveyResponseId",
                table: "AiTool",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_SurveyResponseId",
                table: "Benefit",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPlatform_SurveyResponseId",
                table: "JobPlatform",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPlatform_SurveyResponseId1",
                table: "JobPlatform",
                column: "SurveyResponseId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguage_SurveyResponseId",
                table: "ProgrammingLanguage",
                column: "SurveyResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguage_SurveyResponseId1",
                table: "ProgrammingLanguage",
                column: "SurveyResponseId1");

            migrationBuilder.CreateIndex(
                name: "IX_SkillDevelopmentMethod_SurveyResponseId",
                table: "SkillDevelopmentMethod",
                column: "SurveyResponseId");

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
                name: "JobPlatform");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguage");

            migrationBuilder.DropTable(
                name: "SkillDevelopmentMethod");

            migrationBuilder.DropTable(
                name: "TechCommunity");

            migrationBuilder.DropTable(
                name: "SurveyResponse");
        }
    }
}
