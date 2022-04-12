using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_Projekt.Models
{
    public class Vozac
    {
        public int IDVozac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojMobitela { get; set; }
        public string BrojVozackeDozvole { get; set; }
        public string PunoIme => ToString();
        public override string ToString() => Ime + " " + Prezime;

        public Vozac()
        {
        }

        public Vozac(int iDVozac, string ime, string prezime, string brojMobitela, string brojVozackeDozvole)
        {
            IDVozac = iDVozac;
            Ime = ime;
            Prezime = prezime;
            BrojMobitela = brojMobitela;
            BrojVozackeDozvole = brojVozackeDozvole;
        }

        public Vozac(string ime, string prezime, string brojMobitela, string brojVozackeDozvole)
        {
            Ime = ime;
            Prezime = prezime;
            BrojMobitela = brojMobitela;
            BrojVozackeDozvole = brojVozackeDozvole;
        }
    }
}
