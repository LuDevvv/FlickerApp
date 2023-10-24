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
        [Required(ErrorMessage = "User Id is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Friend User Id is required.")]
        public int FriendUserId { get; set; }
    }
}
