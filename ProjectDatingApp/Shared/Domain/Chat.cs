using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDatingApp.Shared.Domain
{
    public class Chat
    {
        public int ChatID { get; set; }
        public string MessageText { get; set; }
        public DateTime ChatTimeStamp { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public virtual List<Match> Matches { get; set; }
    }
}
