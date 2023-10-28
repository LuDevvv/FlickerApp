using FlickerApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Domain.Entities
{
    public class Comment : AuditableBaseEntity
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        // Foreign keys
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
