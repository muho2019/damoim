namespace Damoim.Domain.Entities;

public class EventParticipant : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public int EventId { get; set; }
    public virtual Event Event { get; set; } = null!;

    public DateTime RegisteredAt { get; set; }
}