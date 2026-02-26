using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Data
{
    public class JamTechSalaryDbContext:DbContext
    {
        public JamTechSalaryDbContext(DbContextOptions options) : base(options) {
            

        }
    }
}
