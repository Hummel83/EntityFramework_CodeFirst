namespace SQLite.Repo.Models
{
    public class Adresse : BaseID
    {
        public Adresse()
        {
            Postleitzahl = new Postleitzahlen();
        }

        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Postleitzahlen Postleitzahl { get; set; }
    }
}