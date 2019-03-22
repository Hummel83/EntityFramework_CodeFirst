using System;
using System.Collections.Generic;

namespace SqLite.Repo
{
    public class AppConfigSettings
    {
        public IList<string> SqLiteConnectionStrings { get; }

        public AppConfigSettings()
        {
            SqLiteConnectionStrings = new List<string>();
        }

        public IList<string> GetConnectionstrings()
        {
            try
            {
                var seetingCollection = ConfigurationManager.ConnectionStrings;
            }
            catch (Exception)
            {
                throw;
            }
            return SqLiteConnectionStrings;
        }
    }
}