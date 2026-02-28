using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace JamTechSalary.API.Entities
{
    [Owned]
    public class PromotionRecord
    {
        [Required]
        public bool WasPromoted { get; set; }
        public string? PromotedToRole { get; set; }
    }
}
