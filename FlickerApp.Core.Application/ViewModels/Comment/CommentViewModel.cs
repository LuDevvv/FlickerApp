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

        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }

        public int PublicationId { get; set; }
        public int UserId { get; set; }
    }
}
