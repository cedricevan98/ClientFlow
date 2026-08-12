namespace CrmApi.Models;

public enum ActivityType { Call, Email, Meeting, Note, Task }

public class Activity
{
    public int Id { get; set; }
    public ActivityType Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public int? ContactId { get; set; }
    public Contact? Contact { get; set; }
    public int? DealId { get; set; }
    public Deal? Deal { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
