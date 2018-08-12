using System.ComponentModel.DataAnnotations.Schema;
namespace MsAccess
{

    [Table("Farben")]
    public class Farben
    {
        public int Id { get; set; }

        public string Farbe { get; set; }
    }
}
