<<<<<<< HEAD
﻿using FlickerApp.Core.Application.ViewModels.Comment;
using System;
=======
﻿using System;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
    
=======

>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
namespace FlickerApp.Core.Application.ViewModels.Publication
{
    public class PublicationViewModel
    {
        public int PublicationId { get; set; }

<<<<<<< HEAD
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Photo URL")]
        public string PhotoUrl { get; set; }

        [Display(Name = "Publication Date")]
        public string PublicationDate { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        public List<CommentViewModel> Comments { get; set; }
=======
        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Created Date is required.")]
        public DateTime CreatedDate { get; set; }
        public string Photo { get; set; }
        public int UserId { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
