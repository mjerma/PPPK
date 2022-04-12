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
    public partial class frmAddVozilo : Form
    {
        public frmAddVozilo()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTip.Text) ||
                    string.IsNullOrEmpty(txtMarka.Text) ||
                    string.IsNullOrEmpty(txtGodinaProizvodnje.Text) ||
                    string.IsNullOrEmpty(txtPrijedeniKilometri.Text))
                {
                    MessageBox.Show("All fields must have a value");
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    Vozilo vozilo = new Vozilo
                    (
                        txtTip.Text,
                        txtMarka.Text,
                        int.Parse(txtGodinaProizvodnje.Text),
                        int.Parse(txtPrijedeniKilometri.Text),
                        true
                    );
                    SqlHelper.AddVozilo(vozilo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
