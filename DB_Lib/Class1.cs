using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lib
{
   public static class Test1
    {
      public static void Muh()
        {
            JetEntityFrameworkProvider.JetConnection.ShowSqlStatements = true;
        }
        
    }
}
