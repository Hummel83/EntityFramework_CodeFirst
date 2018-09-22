using JetEntityFrameworkProvider;
using MsAccess.Properties;
using System;
using System.Linq;

namespace MsAccess
{
    using System.Collections.Generic;

    using static Settings;

    public static class Mirgationstart
    {
        private static readonly string Cs = Default.testConnectionString;

        public static void Muh()
        {
            try
            {
                JetConnection.ShowSqlStatements = true;

                using (AccessContext con = new AccessContext())
                {
                    var blu = new DemoHundeData();
                    List<Hunde> huhu = blu.Hundeerstellen();
                    foreach (var hundi in huhu)
                    {
                        con.Hunde.Add(hundi);
                    }
                    con.SaveChanges();

                    int count = con.Hunde.Count();
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
