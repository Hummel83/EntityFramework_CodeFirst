using Xunit;
using SqLite.Repo;

namespace Unittests.SqLite
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
            var seetingCollection = new AppConfigSettings();
            var bla = seetingCollection.GetConnectionstrings();

            Assert.NotEmpty(bla);
        }


    }
}


