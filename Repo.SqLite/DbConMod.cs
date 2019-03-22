using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLite
{
   public class DbConMod
    {
        public DbConMod()
        {
           
        }

        public void addstring()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Remove("string.name");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("string.name", "new connection string"));
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            //config.AppSettings.Settings.
        }


    }
}
