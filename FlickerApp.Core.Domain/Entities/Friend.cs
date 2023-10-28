<<<<<<< HEAD
﻿using FlickerApp.Core.Domain.Common;
using System;
=======
﻿using System;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Domain.Entities
{
<<<<<<< HEAD
    public class Friend : AuditableBaseEntity
=======
    public class Friend
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    {
        public int FriendId { get; set; }

        // Foreign key: User who is adding a friend
        public int UserId { get; set; }
        public User User { get; set; }

        // Foreign key: User who is a friend
        public int FriendUserId { get; set; }
    }
}
