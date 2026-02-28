using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Entities
{

    [Owned]
    public class SalaryIncreaseRecord
    {
        [Required]
        public bool ReceivedIncrease { get; set; }

        public string? IncreasePercentageBand { get; set; }
    }
}
