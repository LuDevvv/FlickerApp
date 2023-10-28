using FlickerApp.Core.Domain.Common;

namespace FlickerApp.Core.Domain.Entities
{
    public class Publication : AuditableBaseEntity
    {
        public int PublicationId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate  { get; set; }
        public string? Photo { get; set; }

        // Foreign key
        public int UserId { get; set; }
        public User User { get; set; }

        // Relations
        public ICollection<Comment> Comments { get; set; }
    }
}
