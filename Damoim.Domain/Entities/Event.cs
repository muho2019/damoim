namespace Damoim.Domain.Entities;

public class Event : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Location { get; set; } = null!;
    public int MaxParticipants { get; set; }
    
    public int GroupId { get; set; }
    public virtual Group Group { get; set; } = null!;
    public virtual ICollection<EventParticipant> Participants { get; set; } = new List<EventParticipant>();
}