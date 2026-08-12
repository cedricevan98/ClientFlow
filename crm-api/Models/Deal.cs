namespace CrmApi.Models;

public enum DealStage { Lead, Qualified, Proposal, Negotiation, Won, Lost }

public class Deal
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Value { get; set; }
    public DealStage Stage { get; set; } = DealStage.Lead;
    public DateTime? CloseDate { get; set; }
    public string? Notes { get; set; }
    public int? ContactId { get; set; }
    public Contact? Contact { get; set; }
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Activity> Activities { get; set; } = new List<Activity>();
}
