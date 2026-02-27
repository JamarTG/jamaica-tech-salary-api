namespace JamTechSalary.API.Entities
{
    // ─── Promotion sub-model ──────────────────────────────────────────────────

    public class PromotionRecord
    {
        public bool WasPromoted { get; set; }
        public string? PromotedToRole { get; set; }
    }
}
