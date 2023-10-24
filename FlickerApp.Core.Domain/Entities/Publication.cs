using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlickerApp.Core.Domain.Entities
{
    public class Publication
    {
        public int PublicationId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate  { get; set; }
        public string Photo { get; set; }

        // Foreign key
        public int UserId { get; set; }
        public User User { get; set; }

        // Relations
        public ICollection<Comment> Comments { get; set; }
    }
}
