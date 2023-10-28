using FlickerApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Domain.Entities
{
    public class Friend : AuditableBaseEntity
    {
        public int FriendId { get; set; }

        // Foreign key: User who is adding a friend
        public int UserId { get; set; }
        public User User { get; set; }

        // Foreign key: User who is a friend
        public int FriendUserId { get; set; }
    }
}
