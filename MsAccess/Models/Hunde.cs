namespace DB.Lib.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Hunde")]
    public class Hund
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual Farbe Farben { get; set; }

        public virtual int Alter { get; set; }
    }
}
