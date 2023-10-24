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
        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }
    }
}
