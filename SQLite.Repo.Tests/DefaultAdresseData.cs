using SQLite.Repo.Models;
using System.Collections.Generic;

namespace Unittests
{
    public class DefaultAdresseData
    {
        private readonly IList<Adresse> _adresse;

        public DefaultAdresseData(IList<Adresse> adresse)
        {
            _adresse = adresse;
            AddTestUserToAddress();
        }

        public IList<Adresse> Adresse => _adresse;

        public void AddTestUserToAddress()
        {
            _adresse.Add(new Adresse() { AdressId = 0, Vorname = "Bert", Nachname = "Hallo" });
            _adresse.Add(new Adresse() { AdressId = 1, Vorname = "Berti", Nachname = "Lieb1" });
            _adresse.Add(new Adresse() { AdressId = 2, Vorname = "Berta", Nachname = "Bumm2" });            
        }
    }
}