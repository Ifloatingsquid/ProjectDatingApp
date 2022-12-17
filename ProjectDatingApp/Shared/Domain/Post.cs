using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatingApp.Shared.Domain
{
    public class Post
    {
        public int PostID { get; set; }
        public string PostText { get; set; }
        public int TopicID { get; set; }
        public virtual Topic Topic { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
