using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200252
{
    public class PredmetiStudenti
    {
        public int Id { get; set; }
        public string Predmet { get; set; }
        public  Student Student { get; set; }
        public int BrojPolezenih { get; set; }
        public double Prosjek { get; set; }

    }
}
