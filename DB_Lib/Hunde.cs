using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lib
{
    [Table("Hunde")]
    public class Hund
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Farbe Farben{ get; set; }

        public int Alter { get; set; }
    }

    [Table("Farben")]
    public class Farbe
    {
        public int Id { get; set; }
        
        public string Farb { get; set; }

       
    }
}
