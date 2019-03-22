using Repo.SqLite.Contexts;
using Repo.SqLite.Models;
using Repo.SqLite.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Unittests
{
    public class DefaultAdresseData
    {
        private readonly IList<Adresse> _adresse;
        public DefaultAdresseData(IList<Adresse> adresse )
        {
            _adresse = adresse;
        }
        public IList<Adresse> Adresse => _adresse;

        public IList<Adresse> ReadEmptyTable()
        {
            _adresse.Add(new Adresse() { Id = 0, Vorname = "Bert", Nachname = "Hallo" });
            _adresse.Add(new Adresse() { Id = 1, Vorname = "Berti", Nachname = "Lieb1" });
            _adresse.Add(new Adresse() { Id = 2, Vorname = "Berta", Nachname = "Bumm2" });

            return Adresse;
        }

    }
}
