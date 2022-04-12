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
    public partial class frmAddEditPutniNalog : Form
    {
        PutniNalog _putniNalog = null;
        public frmAddEditPutniNalog()
        {
            InitializeComponent();
            FillComboBox();

            lblDatumZatvaranja.Hide();
            dtpDatumZatvaranja.Hide();
            dtpDatumOtvaranja.Value = DateTime.Now;
        }

        private void FillComboBox()
        {
            try
            {
                cbVozac.DataSource = SqlHelper.GetVozaci(lblInfo).ToList();
                cbVozac.DisplayMember = "PunoIme";
                cbVozac.ValueMember = "IDVozac";


                List<Vozilo> slobodnaVozila = new List<Vozilo>();
                foreach (Vozilo vozilo in SqlHelper.GetVozila().ToList())
                {
                    if (vozilo.JeSlobodno)
                    {
                        slobodnaVozila.Add(vozilo);
                    }
                }
                cbVozilo.DataSource = slobodnaVozila;
                cbVozilo.DisplayMember = "TipMarka";
                cbVozilo.ValueMember = "IDVozilo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboBoxOnEdit(int VoziloID)
        {
            try
            {
                cbVozac.DataSource = SqlHelper.GetVozaci(lblInfo).ToList();
                cbVozac.DisplayMember = "PunoIme";
                cbVozac.ValueMember = "IDVozac";


                List<Vozilo> slobodnaVozila = new List<Vozilo>();
                foreach (Vozilo vozilo in SqlHelper.GetVozila().ToList())
                {
                    if (vozilo.JeSlobodno)
                    {
                        slobodnaVozila.Add(vozilo);
                    }
                }

                slobodnaVozila.Add(SqlHelper.GetVozilo(VoziloID));

                cbVozilo.DataSource = slobodnaVozila;
                cbVozilo.DisplayMember = "TipMarka";
                cbVozilo.ValueMember = "IDVozilo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public frmAddEditPutniNalog(PutniNalog putniNalog)
        {
            InitializeComponent();
            FillComboBoxOnEdit(putniNalog.VoziloID);

            _putniNalog = putniNalog;
            btnDodaj.Text = "Uredi";
            txtNaredbodavac.Text = putniNalog.Naredbodavac;
            txtBrojNaloga.Text = putniNalog.BrojNaloga.ToString();
            cbVozac.SelectedValue = putniNalog.VozacID;
            cbVozilo.SelectedValue = putniNalog.VoziloID;
            txtPolaziste.Text = putniNalog.Polaziste;
            txtOdrediste.Text = putniNalog.Odrediste;
            txtBrojDana.Text = putniNalog.BrojDana.ToString();
            dtpDatumOtvaranja.Value = putniNalog.DatumOtvaranja;
            dtpDatumZatvaranja.Value = putniNalog.DatumZatvaranja ?? DateTime.Now;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNaredbodavac.Text) ||
                    string.IsNullOrEmpty(txtBrojNaloga.Text) ||
                    string.IsNullOrEmpty(txtPolaziste.Text) ||
                    string.IsNullOrEmpty(txtOdrediste.Text) ||
                    string.IsNullOrEmpty(txtBrojDana.Text)) 
                {
                    MessageBox.Show("All fields must have a value");
                    DialogResult = DialogResult.None;
                }
                //ADD
                if (_putniNalog == null)
                {
                    Vozac vozac = (Vozac)cbVozac.SelectedItem;
                    Vozilo vozilo = (Vozilo)cbVozilo.SelectedItem;

                    PutniNalog noviPutniNalog = new PutniNalog
                    (
                        txtNaredbodavac.Text,
                        int.Parse(txtBrojNaloga.Text),
                        vozac.IDVozac,
                        vozilo.IDVozilo,
                        txtPolaziste.Text,
                        txtOdrediste.Text,
                        int.Parse(txtBrojDana.Text),
                        dtpDatumOtvaranja.Value,
                        null
                    );
                    SqlHelper.AddPutniNalog(noviPutniNalog);
                }
                //UPDATE
                else
                {
                    PutniNalog updPutniNalog = new PutniNalog
                    (
                        _putniNalog.IDPutniNalog,
                        txtNaredbodavac.Text,
                        int.Parse(txtBrojNaloga.Text),
                        ((Vozac)cbVozac.SelectedItem).IDVozac,
                        ((Vozilo)cbVozilo.SelectedItem).IDVozilo,
                        txtPolaziste.Text,
                        txtOdrediste.Text,
                        int.Parse(txtBrojDana.Text),
                        dtpDatumOtvaranja.Value,
                        dtpDatumZatvaranja.Value
                    );
                    SqlHelper.UpdatePutniNalog(updPutniNalog);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
