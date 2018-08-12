using System.Data.Entity;

namespace MsAccess
{
    using System;

    public class Context
        : DbContext
    {
        public Context(string connstring)
        {
           this.Database.Connection.ConnectionString = connstring ?? 
                throw new ArgumentNullException(nameof(connstring));
        }

        public Context()
            : base("DefaultConnection")
        {
        }


         public virtual DbSet<Hunde> Hunde { get; set; }

        public virtual DbSet<Farben> Farben { get; set; }
    }
  
}