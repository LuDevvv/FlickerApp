<<<<<<< HEAD
<<<<<<< HEAD
﻿using FlickerApp.Core.Domain.Common;

namespace FlickerApp.Core.Domain.Entities
{
    public class User : AuditableBaseEntity
=======
﻿namespace FlickerApp.Core.Domain.Entities
{
    public class User
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
=======
﻿namespace FlickerApp.Core.Domain.Entities
{
    public class User
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        public string? ProfilePicture { get; set; }
=======
        public string ProfilePicture { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
=======
        public string ProfilePicture { get; set; }
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        public DateTime BirthDate { get; set; }
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
=======
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

        // Relations
        public List<Friend> Friends { get; set; }
        public ICollection<Publication> Publications { get; set; }
    }
}
