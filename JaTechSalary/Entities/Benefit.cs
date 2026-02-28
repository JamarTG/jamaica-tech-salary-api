using System.ComponentModel.DataAnnotations;

namespace JamTechSalary.API.Entities
{
    public class Benefit
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; 
    }
}
