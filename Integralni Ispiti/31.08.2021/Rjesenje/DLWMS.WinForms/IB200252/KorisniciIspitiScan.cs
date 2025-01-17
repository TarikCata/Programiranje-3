﻿using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200252
{
    [Table("KorisniciIspitiScan")]
    public class KorisniciIspitiScan
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public string Napomena { get; set; }
        public byte[] Scan { get; set; }
        public bool Varanje { get; set; }
        public virtual Predmet Predmet { get; set; }
    }
}
