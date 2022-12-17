using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectDatingApp.Shared.Domain
{
    public class Match
    {
        public int MatchID { get; set; }
        public Boolean MatchBoolean { get; set; }
        public int UserID1 { get; set; }
        public virtual User User { get; set; }
        public int UserID2 { get; set; }
        public int ChatID { get; set; }
        public virtual Chat Chat { get; set; }
    }
}
