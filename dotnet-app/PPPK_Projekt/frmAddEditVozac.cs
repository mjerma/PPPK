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
    public partial class frmAddEditVozac : Form
    {
        Vozac _Vozac = null;
        public frmAddEditVozac()
        {
            InitializeComponent();
        }

        public frmAddEditVozac(Vozac vozac)
        {
            InitializeComponent();
            _Vozac = vozac;
            btnDodaj.Text = "Uredi";
            txtIme.Text = vozac.Ime;
            txtPrezime.Text = vozac.Prezime;
            txtBrojMobitela.Text = vozac.BrojMobitela;
            txtBrojVozackeDozvole.Text = vozac.BrojVozackeDozvole;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIme.Text) || 
                    string.IsNullOrEmpty(txtPrezime.Text) ||
                    string.IsNullOrEmpty(txtBrojMobitela.Text) || 
                    string.IsNullOrEmpty(txtBrojVozackeDozvole.Text))
                {
                    MessageBox.Show("All fields must have a value");
                    DialogResult = DialogResult.None;
                }
                //ADD
                if(_Vozac == null)
                {
                    Vozac noviVozac = new Vozac
                    (
                        txtIme.Text,
                        txtPrezime.Text,
                        txtBrojMobitela.Text,
                        txtBrojVozackeDozvole.Text
                    );
                    SqlHelper.AddVozac(noviVozac);
                }
                //UPDATE
                else
                {
                    Vozac updVozac = new Vozac
                    (
                        _Vozac.IDVozac,
                        txtIme.Text,
                        txtPrezime.Text,
                        txtBrojMobitela.Text,
                        txtBrojVozackeDozvole.Text
                    );
                    SqlHelper.UpdateVozac(updVozac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
