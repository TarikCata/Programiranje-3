using System;
using System.Collections.Generic;

namespace Prva_Parcijala_2018
{
    internal class InMemoryDb
    {
        public static List<Student> Registrovani { get; set; }
        public static List<Predmet> Predmeti { get; set; } = GenerisiPredmete();

        public double Prosjek { get; set; }
        private static List<Predmet> GenerisiPredmete()
        {
            Predmeti = new List<Predmet>();
            int brojac = 1;
            for (int i = 0; i < 5; i++)
            {
                Random r = new Random();
                var p = new Predmet()
                {
                    Naziv = $"Predmet {brojac}",
                    Ocjena = r.Next(6, 10),
                    _DateTime = DateTime.Now.ToUniversalTime(),
                };
                Predmeti.Add(p);
                brojac++;
            }
            return Predmeti;
        }

        static InMemoryDb()
        {
            Registrovani = new List<Student>();
            DodajDefault();
        }

        private static void DodajDefault()
        {
            Student s1 = new Student()
            {
                Ime = "Denis",
                Prezime = "Mušić",
                Email = "denis@edu.fit.ba",
            };
            Student s2 = new Student()
            {
                Ime = "Elmir",
                Prezime = "Babović",
                Email = "elmir@edu.fit.ba",
            };
            Student s3 = new Student()
            {
                Ime = "Emina",
                Prezime = "Junuz",
                Email = "emina@edu.fit.ba",
            };

            s1.DodajOcjenu("Matematika 1", 10);
            s1.DodajOcjenu("Programiranje 1", 10);
            s1.DodajOcjenu("Programiranje 2", 10);
            s1.DodajOcjenu("Programiranje 3", 10);
            s1.Restart();

            s2.DodajOcjenu("Programiranje 1", 10);
            s2.DodajOcjenu("Programiranje 2", 6);
            s2.DodajOcjenu("Programiranje 3", 6);
            s2.DodajOcjenu("Programiranje 4", 6);
            s2.DodajOcjenu("Programiranje 5", 10);
            s2.Restart();

            s3.DodajOcjenu("Programiranje 6", 10);
            s3.DodajOcjenu("Programiranje 7", 9);
            s3.DodajOcjenu("Programiranje 8", 6);
            s3.DodajOcjenu("Programiranje 9", 7);
            s3.DodajOcjenu("Programiranje 10", 6);
            s3.Restart();

            Registrovani.Add(s1);
            Registrovani.Add(s2);
            Registrovani.Add(s3);
        }

        
    }
}
