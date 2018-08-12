using System;
using System.Linq;

using JetEntityFrameworkProvider;

using MsAccess.Properties;

namespace MsAccess
{
    using static Settings;

    public static class Mirgationstart
    {
        private static readonly string Cs = Default.testConnectionString;

        public static void Muh()
        {
            try
            {
                JetConnection.ShowSqlStatements = true;

                using (Context con = new Context())
                {
                    con.Hunde.Count();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

    }
}
