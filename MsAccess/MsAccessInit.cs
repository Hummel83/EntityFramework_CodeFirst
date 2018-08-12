using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MsAccess
{
    using System.Data.Entity;
    class MsAccessInit : IDatabaseInitializer<Context>
    {
        public void InitializeDatabase(Context context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
            else
            {
                
            }


        }
    }
}
