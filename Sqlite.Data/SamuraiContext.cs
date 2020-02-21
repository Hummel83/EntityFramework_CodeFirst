using System;
using Microsoft.EntityFrameworkCore;
using Sqlite.Domain;

namespace Sqlite.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = SamuraiAppData");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
