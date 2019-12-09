using System.Collections.Generic;
using System.Configuration;

namespace SQLite.Repo
{
    public class AppConfigSettings
    {
        public AppConfigSettings()
        {
            SqLiteConnectionStrings = new List<string>();
        }

        public IList<string> SqLiteConnectionStrings { get; }

        public IList<string> GetConnectionstrings()
        {
            var seetingCollection = ConfigurationManager.ConnectionStrings;
            return SqLiteConnectionStrings;
        }
    }
}