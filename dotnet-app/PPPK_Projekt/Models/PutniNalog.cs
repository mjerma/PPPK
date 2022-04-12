using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_Projekt.Models
{
    public class PutniNalog
    {
        public int IDPutniNalog { get; set; }
        public string Naredbodavac { get; set; }
        public int BrojNaloga { get; set; }
        public int VozacID { get; set; }
        public int VoziloID { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public int BrojDana { get; set; }
        public DateTime DatumOtvaranja { get; set; }
        public DateTime? DatumZatvaranja { get; set; }

        public PutniNalog()
        {
        }

        public PutniNalog(string naredbodavac, int brojNaloga, int vozacID, int voziloID, string polaziste, string odrediste, int brojDana, DateTime datumOtvaranja, DateTime? datumZatvaranja)
        {
            Naredbodavac = naredbodavac;
            BrojNaloga = brojNaloga;
            VozacID = vozacID;
            VoziloID = voziloID;
            Polaziste = polaziste;
            Odrediste = odrediste;
            BrojDana = brojDana;
            DatumOtvaranja = datumOtvaranja;
            DatumZatvaranja = datumZatvaranja;
        }

        public PutniNalog(int iDPutniNalog, string naredbodavac, int brojNaloga, int vozacID, int voziloID, string polaziste, string odrediste, int brojDana, DateTime datumOtvaranja, DateTime? datumZatvaranja)
        {
            IDPutniNalog = iDPutniNalog;
            Naredbodavac = naredbodavac;
            BrojNaloga = brojNaloga;
            VozacID = vozacID;
            VoziloID = voziloID;
            Polaziste = polaziste;
            Odrediste = odrediste;
            BrojDana = brojDana;
            DatumOtvaranja = datumOtvaranja;
            DatumZatvaranja = datumZatvaranja;
        }
    }
}
