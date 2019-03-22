using Microsoft.EntityFrameworkCore;
using SqLite.Repo.Models;

namespace SqLite.Repo
{
    public class SqLiteContext : DbContext
    {
        public virtual DbSet<Adresse> Adressen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source=\F:\DEV_Projects\Projects\EntityFramework_CodeFirst\Unittest\entitySQLiteTests.db");
        }
    }
}