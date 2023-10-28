
using System.ComponentModel.DataAnnotations;

namespace FlickerApp.Core.Application.ViewModels.Publication
{
    public class SavePublicationViewModel
    {
        public int PublicationId { get; set; }

        [Required(ErrorMessage = "The Content field is required.")]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "The User ID field is required.")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
    }
}
