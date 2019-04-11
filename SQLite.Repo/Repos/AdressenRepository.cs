using SQLite.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLite.Repo.Repos
{
    public class AdressenRepository
    {
        public List<Adresse> GetAdressen()
        {
            try
            {
                SqLiteContext adressenContext = new SqLiteContext();
                return adressenContext.Adressen.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}