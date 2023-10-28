using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.Comment
{
    public class SaveCommentViewModel
    {
        public int CommentId { get; set; }

        [Required(ErrorMessage = "The Content field is required.")]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Required(ErrorMessage = "The Created Date field is required.")]
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "The Publication ID field is required.")]
        [Display(Name = "Publication ID")]
        public int PublicationId { get; set; }

        [Required(ErrorMessage = "The User ID field is required.")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
    }
}
