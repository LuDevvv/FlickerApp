<<<<<<< HEAD
﻿using FlickerApp.Core.Domain.Common;

namespace FlickerApp.Core.Domain.Entities
{
    public class Publication : AuditableBaseEntity
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlickerApp.Core.Domain.Entities
{
    public class Publication
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    {
        public int PublicationId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate  { get; set; }
<<<<<<< HEAD
        public string? Photo { get; set; }
=======
        public string Photo { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

        // Foreign key
        public int UserId { get; set; }
        public User User { get; set; }

        // Relations
        public ICollection<Comment> Comments { get; set; }
    }
}
