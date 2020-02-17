using Microsoft.EntityFrameworkCore;
using SQLite.Repo.Models;

namespace SQLite.Repo
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
            optionsBuilder.UseSqlite(
                @"data source=\F:\DEV_Projects\Projects\EntityFramework_CodeFirst\SQLite.Repo.Tests\entitySQLiteTests.db");
        }
    }
}