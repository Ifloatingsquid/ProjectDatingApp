using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectDatingApp.Shared.Domain
{
    public class PersonalProfile
    {
        public int PersonalProfileID { get; set; }
        public string FavouriteSong { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Race { get; set; }
        public string Hobby { get; set; }
        public string ProfileDes { get; set; }
        public virtual List<User> Users { get; set; }

    }
}
