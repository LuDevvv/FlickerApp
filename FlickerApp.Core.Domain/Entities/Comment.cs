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
    public class Comment : AuditableBaseEntity
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
=======
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate  { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

        // Foreign keys
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
