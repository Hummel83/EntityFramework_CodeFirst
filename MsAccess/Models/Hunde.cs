using System.ComponentModel.DataAnnotations.Schema;

namespace MsAccess
{
    [Table("Hunde")]
    public class Hunde
    {

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual Farben Farbe { get; set; }

        public virtual int Alter { get; set; }

        public virtual byte BeinAnzahl { get; set; }


    }
}
