using System.Collections.Generic;

namespace MsAccess
{
    class DemoData
    {
        public List<Hunde> Hundeerstellen()
        {
            var Hundeliste = new List<Hunde>();

            Farben muh;
            muh = new Farben();
            muh.Farbe = "blau2";

            Hunde bello = new Hunde { Name = "Bernd", Alter = 4, BeinAnzahl = 3, Farbe = muh };

            Hundeliste.Add(bello);

            return Hundeliste;
        }
    }
}
