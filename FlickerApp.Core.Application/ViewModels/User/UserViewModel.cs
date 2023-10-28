<<<<<<< HEAD
﻿using FlickerApp.Core.Application.ViewModels.Friend;
using FlickerApp.Core.Application.ViewModels.Publication;
using System.ComponentModel.DataAnnotations;
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

namespace FlickerApp.Core.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int UserId { get; set; }
<<<<<<< HEAD

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Phone")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public string Phone { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        public List<PublicationViewModel> Publications { get; set; }

        public List<FriendViewModel> Friends { get; set; }
=======
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
