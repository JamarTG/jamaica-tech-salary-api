namespace JamTechSalary.API.Entities
{
    // ─── Layoff sub-model ─────────────────────────────────────────────────────

    public class LayoffRecord
    {
        public bool WasLaidOff { get; set; }
        public string? CompanyName { get; set; }
    }
}
