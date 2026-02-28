using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Entities
{
    [Owned]
    public class LayoffRecord
    {
        [Required]
        public bool WasLaidOff { get; set; }
        public string? CompanyName { get; set; }
    }
}
