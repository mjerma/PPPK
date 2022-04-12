using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishod7
{
    public partial class frmServis : Form
    {
        private const string HTML_IZVJESTAJ_PATH = @"../../izvjestaj.html";
        public frmServis()
        {
            InitializeComponent();
            LoadVozila();
        }

        private void LoadVozila()
        {
            using (var db = new PPPK_ProjektEntities())
            {
                lbVozila.DataSource = db.Vozilo.ToList();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var db = new PPPK_ProjektEntities())
            {
                db.Servis.Add(new Servis
                {
                    Opis = tbOpis.Text.Trim(),
                    Datum = dtpDatum.Value,
                    VoziloID = (lbVozila.SelectedItem as Vozilo)?.IDVozilo,
                });
                db.SaveChanges();
                LoadServisi();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PPPK_ProjektEntities())
            {
                var servis = cbServisi.SelectedItem as Servis;
                var dbServis = db.Servis.FirstOrDefault(s => s.IDServis == servis.IDServis);

                dbServis.Opis = tbOpis.Text.Trim();
                dbServis.Datum = dtpDatum.Value;

                db.SaveChanges();
                LoadServisi();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new PPPK_ProjektEntities())
            {
                var servis = cbServisi.SelectedItem as Servis;
                var dbServis = db.Servis.FirstOrDefault(s => s.IDServis == servis.IDServis);

                db.Servis.Remove(dbServis);

                db.SaveChanges();
                LoadServisi();
            }
        }

        private void btnHtmlReport_Click(object sender, EventArgs e)
        {
            string H2_TAG = "<h2>";
            string H2_CLOSING_TAG = "</h2>";
            string H3_TAG = "<h3>";
            string H3_CLOSING_TAG = "</h3>";

            var izvjestaj = new StringBuilder();
            izvjestaj.Append($"<html>{Environment.NewLine}");

            Vozilo vozilo = lbVozila.SelectedItem as Vozilo;
            izvjestaj.Append($"{H2_TAG}Vozilo{H2_CLOSING_TAG}{Environment.NewLine}");
            izvjestaj.Append($"{H3_TAG}{nameof(Vozilo.Tip)}: {vozilo.Tip}{H3_CLOSING_TAG}{Environment.NewLine}");
            izvjestaj.Append($"{H3_TAG}{nameof(Vozilo.Marka)}: {vozilo.Marka}{H3_CLOSING_TAG}{Environment.NewLine}");
            izvjestaj.Append($"{H3_TAG}{nameof(Vozilo.IDVozilo)}: {vozilo.IDVozilo}{H3_CLOSING_TAG}{Environment.NewLine}");
            izvjestaj.Append($"{H3_TAG}{nameof(Vozilo.GodinaProizvodnje)}: {vozilo.GodinaProizvodnje}{H3_CLOSING_TAG}{Environment.NewLine}");
            izvjestaj.Append($"{H3_TAG}{nameof(Vozilo.PrijedeniKilometri)}: {vozilo.PrijedeniKilometri}{H3_CLOSING_TAG}{Environment.NewLine}");

            using (var db = new PPPK_ProjektEntities())
            {
                db.Servis
                    .ToList()
                    .Where(s => s.VoziloID == vozilo.IDVozilo)
                    .ToList()
                    .ForEach(s =>
                    {
                        izvjestaj.Append($"{H2_TAG}Servis{H2_CLOSING_TAG}{Environment.NewLine}");
                        izvjestaj.Append($"{H3_TAG}{nameof(Servis.Opis)}: {s.Opis}{H3_CLOSING_TAG}{Environment.NewLine}");
                        izvjestaj.Append($"{H3_TAG}{nameof(Servis.Datum)}: {s.Datum}{H3_CLOSING_TAG}{Environment.NewLine}");
                    });
            }

            izvjestaj.Append($"</html>{Environment.NewLine}");
            File.WriteAllText(HTML_IZVJESTAJ_PATH, izvjestaj.ToString());
        }

        private void lbVozila_SelectedIndexChanged(object sender, EventArgs e) => LoadServisi();

        private void cbServisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servis servis = cbServisi.SelectedItem as Servis;
            tbOpis.Text = servis.Opis;
            dtpDatum.Value = servis.Datum;
        }

        private void LoadServisi()
        {
            using (var db = new PPPK_ProjektEntities())
            {
                cbServisi.DataSource = db.Servis
                    .ToList()
                    .Where(s => s.VoziloID == (lbVozila.SelectedItem as Vozilo)?.IDVozilo)
                    .ToList();
            }
        }
    }
}
