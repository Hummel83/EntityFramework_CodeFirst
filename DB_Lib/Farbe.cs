namespace DB.Lib
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The farbe.
    /// </summary>
    [Table("Farben")]
    public class Farbe
    {
        public int Id { get; set; }
        
        public string Farb { get; set; }
    }
}
