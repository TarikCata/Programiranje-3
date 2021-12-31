using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.Entiteti
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestovi
    {
        public int id { get; set; }
        public Student Student { get; set; }
        public string DatumTestiranja { get; set; }
        public string Rezultat { get; set; }
        public bool Dostavljen { get; set; }
    }
}
