using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IspitIB200252
{
    [Table("GodineStudija")]
    public class GodinaStudija
    {
        public int id { get; set; }

        public string Naziv { get; set; }

        public int Aktivna { get; set; }
    }
}
