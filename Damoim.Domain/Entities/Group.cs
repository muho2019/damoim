namespace Damoim.Domain.Entities;

public class Group : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Image { get; set; } = null!;
    public int MaxMembers { get; set; }
    public bool IsPrivate { get; set; }
    
    public int CreatorId { get; set; }
    public virtual User Creator { get; set; } = null!;
    public virtual ICollection<GroupMember> Members { get; set; } = new List<GroupMember>();
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}