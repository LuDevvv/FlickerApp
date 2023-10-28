using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.Comment
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Publication ID")]
        public int PublicationId { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }
    }
}
