using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.Friend
{
    public class SaveFriendViewModel
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public int FriendId { get; set; }

        [Required(ErrorMessage = "The User ID field is required.")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The Friend User ID field is required.")]
        [Display(Name = "Friend User ID")]
        public int FriendUserId { get; set; }

=======
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        [Required(ErrorMessage = "User Id is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Friend User Id is required.")]
        public int FriendUserId { get; set; }
<<<<<<< HEAD
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
