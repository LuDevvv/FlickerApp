<<<<<<< HEAD
﻿
using System.ComponentModel.DataAnnotations;
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

namespace FlickerApp.Core.Application.ViewModels.Publication
{
    public class SavePublicationViewModel
    {
<<<<<<< HEAD
        public int PublicationId { get; set; }

        [Required(ErrorMessage = "The Content field is required.")]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "The User ID field is required.")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
=======
        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }
        public string Photo { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
