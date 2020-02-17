using SQLite.Repo;
using Xunit;

namespace Unittests
{
    public class AppConfigSettingsTest
    {
        [Fact]
        public void CreateEmptyObject()
        {
            var seetingCollection = new AppConfigSettings();
            Assert.NotNull(seetingCollection);
        }

        [Fact]
        public void GetAllConnectionsString()
        {
            var Acs = new AppConfigSettings();
            var bla = Acs.GetConnectionStrings();

            Assert.Equal(2, Acs.SqlConnectionStrings.Count);
        }
    }
}