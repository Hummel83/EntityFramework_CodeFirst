using System.Collections.Generic;
using Repo.MsAccess.Models;

namespace Repo.MsAccess.DemoData
{
    public class DemoHundeData
    {
        public List<Hunde> Hundeerstellen()
        {
            List<Hunde> Hundeliste = new List<Hunde>();

            Farben muh;
            muh = new Farben();
            muh.Farbe = "blau2";

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
