using System.Collections.Generic;
using System.Linq;
using SQLite.Repo.Models;

namespace SQLite.Repo.Repos
{
    public class AdressenRepository
    {
        public List<Adresse> GetAdressen()
        {
            var adressenContext = new SqLiteContext();
            return adressenContext.Adressen.ToList();
        }
    }
}