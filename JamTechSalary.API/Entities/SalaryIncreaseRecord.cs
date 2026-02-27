namespace JamTechSalary.API.Entities
{
    // ─── Salary increase sub-model ────────────────────────────────────────────

    public class SalaryIncreaseRecord
    {
        public bool ReceivedIncrease { get; set; }

        /// <summary>Percentage band, e.g. "6% to 10%".</summary>
        public string? IncreasePercentageBand { get; set; }
    }
}
