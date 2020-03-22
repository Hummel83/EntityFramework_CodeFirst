using Microsoft.EntityFrameworkCore;
using Sqlite.Domain;

namespace Sqlite.Data
{
    public class SamuraiContext : DbContext
    {
        //local testDb path
        private readonly string _bla =
            "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Chris\\Documents\test1.mdf;Integrated Security = True; Connect Timeout = 30";

        private readonly string _localMsSqlDb =
            "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = SamuraiAppData";

        /// <summary>
        ///     Use Default MSSql ConnectionsString
        /// </summary>
        public SamuraiContext()
        {
            ContextConnectionsString = _localMsSqlDb;
        }

        public SamuraiContext(string ConnectionsString)
        {
            if (string.IsNullOrEmpty(ConnectionsString))
                ContextConnectionsString = _localMsSqlDb;
            else
                ContextConnectionsString = ConnectionsString;
        }

        public string ContextConnectionsString { get; set; }
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ContextConnectionsString);
        }
    }
}