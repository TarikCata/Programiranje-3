using System.Collections.Generic;
using System.Drawing;
using System;
namespace Prva_Parcijala_2018
{
    class Student
    {
        public static int Br = 190000;
        private static int Br2 = 0;
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public Image image { get; set; }
        public  List<Predmet> Predmeti { get; set; }
        public double Prosjek { get; set; }
        public int BrojPolozenih { get; set; }

        public Student()
        {
            int n = Br++;
            BrojIndeksa = "IB" + n.ToString();
            Predmeti = new List<Predmet>();
        }
       
        public bool DodajOcjenu(string naziv, int ocjena)
        {
            double sum = 0;
            foreach (var p in Predmeti)
                sum += p.Ocjena;

            sum += ocjena;
            Prosjek = Math.Round((sum / (Predmeti.Count + 1)), 2);
            Predmeti.Add(new Predmet() { Naziv = naziv, Ocjena = ocjena, _DateTime = DateTime.Now.ToLocalTime()});
            ++Br2;
            BrojPolozenih = Br2;
            return true;
        }
        public void Restart()
        {
            Br2 = 0;
        }
    }
}
