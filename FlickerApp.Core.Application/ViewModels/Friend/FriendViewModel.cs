using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.ViewModels.Friend
{
    public class FriendViewModel
    {
        public int FriendId { get; set; }

        [Display(Name = "Full Friend Name")]
        public string FullFriendName { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Display(Name = "Friend User ID")]
        public int FriendUserId { get; set; }

    }
}
