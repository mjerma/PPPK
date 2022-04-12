using PPPK_Projekt.Dao;
using PPPK_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace PPPK_Projekt
{
    public partial class frmSetup : Form
    {
        private const string XML_DATABASE_PATH = @"../../database_data.xml";
        public frmSetup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                BackupDbToXML();
                SqlHelper.CleanDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackupDbToXML()
        {
            using (XmlWriter writer = XmlWriter.Create(XML_DATABASE_PATH, new XmlWriterSettings { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DatabaseData");

                DataTable dtPutniNalozi = SqlHelper.GetAllDatabaseData();
                IList<Ruta> putniNalogRute;
                dtPutniNalozi.Rows.Cast<DataRow>()
                    .ToList()
                    .ForEach(dr =>
                    {
                        putniNalogRute = SqlHelper.GetPutniNalogRute((int)dr[nameof(PutniNalog.IDPutniNalog)]);
                        // TravelWarrant
                        writer.WriteStartElement(nameof(PutniNalog));
                        writer.WriteAttributeString(nameof(PutniNalog.IDPutniNalog), dr[nameof(PutniNalog.IDPutniNalog)].ToString());
                        writer.WriteElementString(nameof(PutniNalog.Naredbodavac), dr[nameof(PutniNalog.Naredbodavac)].ToString());
                        writer.WriteElementString(nameof(PutniNalog.BrojNaloga), dr[nameof(PutniNalog.BrojNaloga)].ToString());

                        // Driver
                        writer.WriteStartElement(nameof(Vozac));
                        writer.WriteElementString(nameof(Vozac.IDVozac), dr[nameof(Vozac.IDVozac)].ToString());
                        writer.WriteElementString(nameof(Vozac.Ime), dr[nameof(Vozac.Ime)].ToString());
                        writer.WriteElementString(nameof(Vozac.Prezime), dr[nameof(Vozac.Prezime)].ToString());
                        writer.WriteElementString(nameof(Vozac.BrojMobitela), dr[nameof(Vozac.BrojMobitela)].ToString());
                        writer.WriteElementString(nameof(Vozac.BrojVozackeDozvole), dr[nameof(Vozac.BrojVozackeDozvole)].ToString());
                        writer.WriteEndElement();

                        // Car
                        writer.WriteStartElement(nameof(Vozilo));
                        writer.WriteElementString(nameof(Vozilo.IDVozilo), dr[nameof(Vozilo.IDVozilo)].ToString());
                        writer.WriteElementString(nameof(Vozilo.Tip), dr[nameof(Vozilo.Tip)].ToString());
                        writer.WriteElementString(nameof(Vozilo.Marka), dr[nameof(Vozilo.Marka)].ToString());
                        writer.WriteElementString(nameof(Vozilo.GodinaProizvodnje), dr[nameof(Vozilo.GodinaProizvodnje)].ToString());
                        writer.WriteElementString(nameof(Vozilo.PrijedeniKilometri), dr[nameof(Vozilo.PrijedeniKilometri)].ToString());
                        writer.WriteElementString(nameof(Vozilo.JeSlobodno), dr[nameof(Vozilo.JeSlobodno)].ToString());
                        writer.WriteEndElement();

                        // Rute
                        writer.WriteStartElement("Rute");
                        foreach (var ruta in putniNalogRute)
                        {
                            writer.WriteStartElement(nameof(Ruta));
                            writer.WriteElementString(nameof(Ruta.IDRuta), ruta.IDRuta.ToString());
                            writer.WriteElementString(nameof(Ruta.Sati), ruta.Sati.ToString());
                            writer.WriteElementString(nameof(Ruta.KoordinataA), ruta.KoordinataA.ToString());
                            writer.WriteElementString(nameof(Ruta.KoordinataB), ruta.KoordinataB.ToString());
                            writer.WriteElementString(nameof(Ruta.PrijedeniKilometri), ruta.PrijedeniKilometri.ToString());
                            writer.WriteElementString(nameof(Ruta.ProsjecnaBrzina), ruta.ProsjecnaBrzina.ToString());
                            writer.WriteElementString(nameof(Ruta.PotrosenoGorivo), ruta.PotrosenoGorivo.ToString());
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();

                        writer.WriteElementString(nameof(PutniNalog.Polaziste), dr[nameof(PutniNalog.Polaziste)].ToString());
                        writer.WriteElementString(nameof(PutniNalog.Odrediste), dr[nameof(PutniNalog.Odrediste)].ToString());
                        writer.WriteElementString(nameof(PutniNalog.BrojDana), dr[nameof(PutniNalog.BrojDana)].ToString());
                        writer.WriteElementString(nameof(PutniNalog.DatumOtvaranja), dr[nameof(PutniNalog.DatumOtvaranja)].ToString());
                        writer.WriteElementString(nameof(PutniNalog.DatumZatvaranja), dr[nameof(PutniNalog.DatumZatvaranja)].ToString());

                        writer.WriteEndElement();
                    });

                writer.WriteEndElement();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                RestoreVozaci();
                RestoreVozila();
                RestorePutniNalozi();
                RestoreRute();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RestorePutniNalozi()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList putniNaloziNodes = root.SelectNodes($"{nameof(PutniNalog)}");

            putniNaloziNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(pnn =>
                {
                    PutniNalog putniNalog = new PutniNalog
                    {
                        IDPutniNalog = int.Parse(pnn.Attributes[0].Value),
                        Naredbodavac = pnn.SelectSingleNode(nameof(PutniNalog.Naredbodavac)).InnerText,
                        BrojNaloga = int.Parse(pnn.SelectSingleNode(nameof(PutniNalog.BrojNaloga)).InnerText),
                        VozacID = int.Parse(pnn.SelectSingleNode($"{nameof(Vozac)}/{nameof(Vozac.IDVozac)}").InnerText),
                        VoziloID = int.Parse(pnn.SelectSingleNode($"{nameof(Vozilo)}/{nameof(Vozilo.IDVozilo)}").InnerText),
                        Polaziste = pnn.SelectSingleNode(nameof(PutniNalog.Polaziste)).InnerText,
                        Odrediste = pnn.SelectSingleNode(nameof(PutniNalog.Odrediste)).InnerText,
                        BrojDana = int.Parse(pnn.SelectSingleNode(nameof(PutniNalog.BrojDana)).InnerText),
                        DatumOtvaranja = DateTime.Parse(pnn.SelectSingleNode(nameof(PutniNalog.DatumOtvaranja)).InnerText),
                        DatumZatvaranja = string.IsNullOrEmpty(pnn.SelectSingleNode(nameof(PutniNalog.DatumZatvaranja)).InnerText) ?
                                          (DateTime?)null : DateTime.Parse(pnn.SelectSingleNode(nameof(PutniNalog.DatumZatvaranja)).InnerText)
                    };
                    SqlHelper.AddPutniNalog(putniNalog);
                });
        }

        private void RestoreVozila()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList voziloNodes = root.SelectNodes($"{nameof(PutniNalog)}/{nameof(Vozilo)}");

            voziloNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(vn =>
                {
                    Vozilo vozilo = new Vozilo
                    {
                        IDVozilo = int.Parse(vn.SelectSingleNode(nameof(Vozilo.IDVozilo)).InnerText),
                        Tip = vn.SelectSingleNode(nameof(Vozilo.Tip)).InnerText,
                        Marka = vn.SelectSingleNode(nameof(Vozilo.Marka)).InnerText,
                        GodinaProizvodnje = int.Parse(vn.SelectSingleNode(nameof(Vozilo.GodinaProizvodnje)).InnerText),
                        PrijedeniKilometri = int.Parse(vn.SelectSingleNode(nameof(Vozilo.PrijedeniKilometri)).InnerText),
                        JeSlobodno = bool.Parse(vn.SelectSingleNode(nameof(Vozilo.JeSlobodno)).InnerText)
                    };
                    SqlHelper.AddVozilo(vozilo);
                });
        }

        private void RestoreVozaci()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList vozacNodes = root.SelectNodes($"{nameof(PutniNalog)}/{nameof(Vozac)}");

            vozacNodes.Cast<XmlNode>()
                .ToList()
                .ForEach(vn =>
                {
                    Vozac vozac = new Vozac
                    {
                        IDVozac = int.Parse(vn.SelectSingleNode(nameof(Vozac.IDVozac)).InnerText),
                        Ime = vn.SelectSingleNode(nameof(Vozac.Ime)).InnerText,
                        Prezime = vn.SelectSingleNode(nameof(Vozac.Prezime)).InnerText,
                        BrojMobitela = vn.SelectSingleNode(nameof(Vozac.BrojMobitela)).InnerText,
                        BrojVozackeDozvole = vn.SelectSingleNode(nameof(Vozac.BrojVozackeDozvole)).InnerText
                    };

                    SqlHelper.AddVozac(vozac);
                });
        }

        private void RestoreRute()
        {
            XmlDocument doc = LoadDocument();
            XmlElement root = doc.DocumentElement;
            XmlNodeList ruteNodes = root.SelectNodes($"{nameof(PutniNalog)}/Rute/{nameof(Ruta)}");
            if (ruteNodes.Count > 0)
            {
                ruteNodes.Cast<XmlNode>()
                    .ToList()
                    .ForEach(rn =>
                    {
                        Ruta ruta = new Ruta
                        {
                            IDRuta = int.Parse(rn.SelectSingleNode(nameof(Ruta.IDRuta)).InnerText),
                            Sati = int.Parse(rn.SelectSingleNode(nameof(Ruta.Sati)).InnerText),
                            KoordinataA = int.Parse(rn.SelectSingleNode(nameof(Ruta.KoordinataA)).InnerText),
                            KoordinataB = int.Parse(rn.SelectSingleNode(nameof(Ruta.KoordinataB)).InnerText),
                            PutniNalogID = int.Parse(rn.ParentNode.ParentNode.Attributes[0].Value),
                            PrijedeniKilometri = int.Parse(rn.SelectSingleNode(nameof(Ruta.PrijedeniKilometri)).InnerText),
                            ProsjecnaBrzina = int.Parse(rn.SelectSingleNode(nameof(Ruta.ProsjecnaBrzina)).InnerText),
                            PotrosenoGorivo = int.Parse(rn.SelectSingleNode(nameof(Ruta.PotrosenoGorivo)).InnerText),
                        };
                        SqlHelper.AddRuta(ruta);
                    });
            }
        }

        private XmlDocument LoadDocument()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XML_DATABASE_PATH);
            return doc;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlHelper.AddExampleRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCleanDb_Click(object sender, EventArgs e)
        {
            try
            {
                SqlHelper.CleanDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
