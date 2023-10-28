using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.Friend
{
    public class FriendViewModel
    {
        public int FriendId { get; set; }
<<<<<<< HEAD

        [Display(Name = "Full Friend Name")]
        public string FullFriendName { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Display(Name = "Friend User ID")]
        public int FriendUserId { get; set; }

=======
        public int UserId { get; set; }
        public int FriendUserId { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
