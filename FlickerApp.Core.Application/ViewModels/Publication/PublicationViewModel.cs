using FlickerApp.Core.Application.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace FlickerApp.Core.Application.ViewModels.Publication
{
    public class PublicationViewModel
    {
        public int PublicationId { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Photo URL")]
        public string PhotoUrl { get; set; }

        [Display(Name = "Publication Date")]
        public string PublicationDate { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        public List<CommentViewModel> Comments { get; set; }
    }
}
