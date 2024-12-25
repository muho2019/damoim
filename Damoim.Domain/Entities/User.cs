namespace Damoim.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string ProfileImage { get; set; } = null!;
    public string Bio { get; set; } = null!;
    
    public virtual ICollection<Group> CreatedGroups { get; set; } = new List<Group>();
    public virtual ICollection<GroupMember> GroupMemberships { get; set; } = new List<GroupMember>();
    public virtual ICollection<Interest> Interests { get; set; } = new List<Interest>();
    public virtual ICollection<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();
}