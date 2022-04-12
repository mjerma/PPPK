using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_Projekt.Models
{
    public class Ruta
    {
        public int IDRuta { get; set; }
        public int Sati { get; set; }
        public double KoordinataA { get; set; }
        public double KoordinataB { get; set; }
        public int PutniNalogID { get; set; }
        public int PrijedeniKilometri { get; set; }
        public int ProsjecnaBrzina { get; set; }
        public double PotrosenoGorivo { get; set; }

        public string Ispis => $"{KoordinataA} - {KoordinataB}";

        public Ruta() 
        { 
        
        }
        public Ruta(int idRuta, int sati, double koordinataA, double koordinataB, int putniNalogID, int prijedeniKilometri, int prosjecnaBrzina, double potrosenoGorivo)
        {
            IDRuta = idRuta;
            Sati = sati;
            KoordinataA = koordinataA;
            KoordinataB = koordinataB;
            PutniNalogID = putniNalogID;
            PrijedeniKilometri = prijedeniKilometri;
            ProsjecnaBrzina = prosjecnaBrzina;
            PotrosenoGorivo = potrosenoGorivo;
        }

        public Ruta(int sati, double koordinataA, double koordinataB, int putniNalogID, int prijedeniKilometri, int prosjecnaBrzina, double potrosenoGorivo)
        {
            Sati = sati;
            KoordinataA = koordinataA;
            KoordinataB = koordinataB;
            PutniNalogID = putniNalogID;
            PrijedeniKilometri = prijedeniKilometri;
            ProsjecnaBrzina = prosjecnaBrzina;
            PotrosenoGorivo = potrosenoGorivo;
        }
    }
}
