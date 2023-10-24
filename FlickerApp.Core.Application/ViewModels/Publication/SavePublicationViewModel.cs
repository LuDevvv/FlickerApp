using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.Publication
{
    public class SavePublicationViewModel
    {
        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }
        public string Photo { get; set; }
    }
}
