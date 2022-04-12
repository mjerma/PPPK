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
    public partial class frmVozacList : Form
    {
        public frmVozacList()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmAddEditVozac frmAddEdit = new frmAddEditVozac();
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                dgwVozaci.Rows.Clear();
                foreach (var vozac in SqlHelper.GetVozaci(lblInfo))
                {
                    dgwVozaci.Rows.Add(new object[] {
                    vozac.IDVozac,
                    vozac.Ime,
                    vozac.Prezime,
                    vozac.BrojMobitela,
                    vozac.BrojVozackeDozvole,
                    "Uredi",
                    "Obriši"
                });
                    dgwVozaci.Rows[dgwVozaci.RowCount - 1].Tag = vozac;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmVozacList_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgwVozaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                new frmAddEditVozac((Vozac)dgwVozaci.CurrentRow.Tag).ShowDialog();
                LoadData();
            }

            if (e.ColumnIndex == 6)
            {
                try
                {
                    if (MessageBox.Show("Jeste li sigurni da zelite izbrisati?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (SqlHelper.DeleteVozac(((Vozac)dgwVozaci.CurrentRow.Tag).IDVozac) > 0)
                        {
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
