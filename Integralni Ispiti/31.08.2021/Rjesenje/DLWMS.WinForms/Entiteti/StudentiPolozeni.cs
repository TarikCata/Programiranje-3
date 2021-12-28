using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    public class StudentiPolozeni
    {
        public Student Student { get; set; }

        public string _Predmet { get; set; }

        public int BrojPolozenih { get; set; }

        public double Prosjek { get; set; }

        public override string ToString()
        {
            return Student.ToString();
        }
    }
}
