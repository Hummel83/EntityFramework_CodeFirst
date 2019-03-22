using JetEntityFrameworkProvider;
using MsAccess.Repo.DemoData;
using MsAccess.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MsAccess.Repo
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
                    var huhu = blu.Hundeerstellen();
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