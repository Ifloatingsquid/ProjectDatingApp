using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatingApp.Shared.Domain
{
    public class User
    {
        public int UserID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Popularity { get; set; }
        public string ICNumber { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string Role { get; set; }
        public int PersonalProfileID { get; set; }
        public virtual PersonalProfile PersonalProfile { get; set; }
        public virtual List<Topic> Topics { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Match> Matches { get; set; }
        public virtual List<Chat> Chats { get; set; }
    }
}
