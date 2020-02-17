using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SQLite.Repo
{
    public class AppConfigSettings
    {
        public AppConfigSettings()
        {
            SqlConnectionStrings = new List<string>();
        }

        public IList<string> SqlConnectionStrings { get; }

        public IList<string> GetConnectionStrings()
        {
            try
            {
                //var MsSql =
                //    ConfigurationManager.ConnectionStrings["entitySQLiteTests"].ConnectionString;
                var Muja =
                    ConfigurationManager.ConnectionStrings[0].ConnectionString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }   
            
            

            //var SQlite =
            //    ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        
         



            return SqlConnectionStrings;
        }
    }
}