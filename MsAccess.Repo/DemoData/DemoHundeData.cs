
using MsAccess.Repo.Models;
using System.Collections.Generic;

namespace MsAccess.Repo.DemoData
{
    public class DemoHundeData
    {
        public List<Hunde> Hundeerstellen()
        {
            List<Hunde> Hundeliste = new List<Hunde>();

            Farben muh;
            muh = new Farben
            {
                Farbe = "blau2"
            };

            Hunde bello = new Hunde
            {
                Name = "Bernd",
                Alter = 4,
                BeinAnzahl = 3,
                Farbe = muh
            };

            Hundeliste.Add(bello);

            return Hundeliste;
        }
    }
}