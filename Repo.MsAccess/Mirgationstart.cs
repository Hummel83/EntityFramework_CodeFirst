using System;
using System.Collections.Generic;
using System.Linq;
using JetEntityFrameworkProvider;
using MsAccess;
using Repo.MsAccess.DemoData;
using Repo.MsAccess.Models;


namespace Repo.MsAccess
{
    public static class Mirgationstart
    {
        private static readonly string Cs = Properties.Settings.Default.testConnectionString;

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
