using System.Collections.Generic;

namespace Sqlite.Domain
{
    public class Clan
    {
        public Clan()
        {
            Samurai= new HashSet<Samurai>();
        }
        public int ClanId { get; set; }
        public string ClanName { get; set; }
        public virtual ICollection<Samurai> Samurai { get; set; }

    }
}