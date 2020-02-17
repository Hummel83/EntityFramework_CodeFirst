namespace SQLite.Repo.Models
{
    public class Adresse 
    {
        public Adresse()
        {
            Postleitzahl = new Postleitzahlen();
        }

        public int AdressId { get; set; }

        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Postleitzahlen Postleitzahl { get; set; }
    }
}