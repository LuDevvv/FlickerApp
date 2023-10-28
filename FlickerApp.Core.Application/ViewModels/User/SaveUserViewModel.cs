using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.User
{
    public class SaveUserViewModel
    {
        public int UserId { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Birth Date is required.")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Phone")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public string Phone { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required.")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Display(Name = "Is Active")]
=======
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
<<<<<<< HEAD
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        public bool IsActive { get; set; }
    }
}
