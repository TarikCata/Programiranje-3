﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200252
{
    public class KorisniciPoruke
    {
        public int Id { get; set; }
        public virtual Korisnik korisnik { get; set; }  
        public string Sadrzaj { get; set; }   
        public string Datum { get; set; }   
        public byte [] Slika { get; set; }   

    }
}
