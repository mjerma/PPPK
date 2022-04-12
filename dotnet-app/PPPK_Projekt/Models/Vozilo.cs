using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_Projekt.Models
{
    public class Vozilo
    {
        public int IDVozilo { get; set; }
        public string Tip { get; set; }
        public string Marka { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int PrijedeniKilometri { get; set; }
        public bool JeSlobodno { get; set; }

        public string TipMarka => ToString();
        public override string ToString() => Tip + " - " + Marka;

        public Vozilo()
        {
        }

        public Vozilo(int iDVozilo, string tip, string marka, int godinaProizvodnje, int prijedeniKilometri, bool jeSlobodno)
        {
            IDVozilo = iDVozilo;
            Tip = tip;
            Marka = marka;
            GodinaProizvodnje = godinaProizvodnje;
            PrijedeniKilometri = prijedeniKilometri;
            JeSlobodno = jeSlobodno;
        }

        public Vozilo(string tip, string marka, int godinaProizvodnje, int prijedeniKilometri, bool jeSlobodno)
        {
            Tip = tip;
            Marka = marka;
            GodinaProizvodnje = godinaProizvodnje;
            PrijedeniKilometri = prijedeniKilometri;
            JeSlobodno = jeSlobodno;
        }
    }
}
