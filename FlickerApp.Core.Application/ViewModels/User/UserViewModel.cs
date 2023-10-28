using FlickerApp.Core.Application.ViewModels.Friend;
using FlickerApp.Core.Application.ViewModels.Publication;
using System.ComponentModel.DataAnnotations;

namespace FlickerApp.Core.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int UserId { get; set; }

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
    }
}
