using FlickerApp.Core.Domain.Common;

namespace FlickerApp.Core.Domain.Entities
{
    public class User : AuditableBaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string? ProfilePicture { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime BirthDate { get; set; }

        // Relations
        public List<Friend> Friends { get; set; }
        public ICollection<Publication> Publications { get; set; }
    }
}
