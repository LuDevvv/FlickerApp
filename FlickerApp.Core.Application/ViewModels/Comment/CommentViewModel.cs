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

<<<<<<< HEAD
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Publication ID")]
        public int PublicationId { get; set; }

        [Display(Name = "User ID")]
=======
        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        public int PublicationId { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        public int UserId { get; set; }
    }
}
