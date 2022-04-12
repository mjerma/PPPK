using PPPK_Projekt.Dao;
using PPPK_Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPK_Projekt
{
    public partial class frmAddEditRuta : Form
    {
        private const string XML_RUTA_PATH = @"../../ruta.xml";
        private int IDPutniNalog;
        public frmAddEditRuta()
        {
            InitializeComponent();
        }

        public frmAddEditRuta(int putniNalogID)
        {
            InitializeComponent();
            IDPutniNalog = putniNalogID;
            FillRuteComboBox();
        }

        private void FillRuteComboBox()
        {
            try
            {
                var rute = SqlHelper.GetPutniNalogRute(IDPutniNalog);
                cbRute.DataSource = rute;
                cbRute.DisplayMember = "Ispis";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataSet ds = SqlHelper.SelectRutaData((cbRute.SelectedItem as Ruta).IDRuta);
            ds.WriteXml(XML_RUTA_PATH, XmlWriteMode.WriteSchema);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(XML_RUTA_PATH);

                ds.Tables[0].Rows
                    .Cast<DataRow>()
                    .ToList()
                    .ForEach(routeRow =>
                    {
                        txtSati.Text = routeRow[nameof(Ruta.Sati)].ToString();
                        txtKoordinataA.Text = routeRow[nameof(Ruta.KoordinataA)].ToString();
                        txtKoordinataB.Text = routeRow[nameof(Ruta.KoordinataB)].ToString();
                        txtPrijedeniKilometri.Text = routeRow[nameof(Ruta.PrijedeniKilometri)].ToString();
                        txtProsjecnaBrzina.Text = routeRow[nameof(Ruta.ProsjecnaBrzina)].ToString();
                        txtPotrosenoGorivo.Text = routeRow[nameof(Ruta.PotrosenoGorivo)].ToString();
                    });
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSati.Text) ||
                    string.IsNullOrEmpty(txtKoordinataA.Text) ||
                    string.IsNullOrEmpty(txtKoordinataB.Text) ||
                    string.IsNullOrEmpty(txtPotrosenoGorivo.Text) ||
                    string.IsNullOrEmpty(txtPrijedeniKilometri.Text) ||
                    string.IsNullOrEmpty(txtProsjecnaBrzina.Text))
                {
                    MessageBox.Show("All fields must have a value");
                    DialogResult = DialogResult.None;
                }

                SqlHelper.AddRuta(new Ruta
                    (
                        int.Parse(txtSati.Text),
                        double.Parse(txtKoordinataA.Text),
                        double.Parse(txtKoordinataB.Text),
                        IDPutniNalog,
                        int.Parse(txtPrijedeniKilometri.Text),
                        int.Parse(txtProsjecnaBrzina.Text),
                        double.Parse(txtPotrosenoGorivo.Text)
                    ));
                FillRuteComboBox();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlHelper.UpdateRuta(new Ruta
                    (
                        (cbRute.SelectedItem as Ruta).IDRuta,
                        int.Parse(txtSati.Text),
                        double.Parse(txtKoordinataA.Text),
                        double.Parse(txtKoordinataB.Text),
                        IDPutniNalog,
                        int.Parse(txtPrijedeniKilometri.Text),
                        int.Parse(txtProsjecnaBrzina.Text),
                        double.Parse(txtPotrosenoGorivo.Text)
                    ));
                FillRuteComboBox();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlHelper.DeleteRuta((cbRute.SelectedItem as Ruta).IDRuta);
                FillRuteComboBox();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextboxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void cbRute_DropDownClosed(object sender, EventArgs e)
        {
            if (cbRute.Items.Count > 0)
            {
                Ruta selected = cbRute.SelectedItem as Ruta;

                txtSati.Text = selected.Sati.ToString();
                txtKoordinataA.Text = selected.KoordinataA.ToString();
                txtKoordinataB.Text = selected.KoordinataB.ToString();
                txtPrijedeniKilometri.Text = selected.PrijedeniKilometri.ToString();
                txtProsjecnaBrzina.Text = selected.ProsjecnaBrzina.ToString();
                txtPotrosenoGorivo.Text = selected.PotrosenoGorivo.ToString();
            }
        }
    }
}
