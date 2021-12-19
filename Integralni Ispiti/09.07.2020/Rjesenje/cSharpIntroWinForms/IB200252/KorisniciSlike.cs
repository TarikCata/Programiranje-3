using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200252
{
    public class KorisniciSlike
    {
        public int id { get; set; }
        public virtual Korisnik korisnik { get; set; }
        public  byte[] slika { get; set; }
    }
}
