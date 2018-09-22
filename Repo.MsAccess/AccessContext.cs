using System;
using System.Data.Entity;
using MsAccess;
using Repo.MsAccess.Models;

namespace Repo.MsAccess
{
    public class AccessContext 
        : DbContext
    {
        public AccessContext(string connstring)
        {
           this.Database.Connection.ConnectionString = connstring ?? 
                throw new ArgumentNullException(nameof(connstring));
        }

        public AccessContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
        }


         public virtual DbSet<Hunde> Hunde { get; set; }

        public virtual DbSet<Farben> Farben { get; set; }
    }
  
}