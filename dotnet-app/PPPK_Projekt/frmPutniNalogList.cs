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
    public partial class frmPutniNalogList : Form
    {
        public frmPutniNalogList()
        {
            InitializeComponent();
        }

        private void frmPutniNalogList_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgwPutniNalozi.Rows.Clear();
                foreach (var putniNalog in SqlHelper.GetPutniNalozi())
                {
                    dgwPutniNalozi.Rows.Add(new object[] {
                    putniNalog.IDPutniNalog,
                    putniNalog.Naredbodavac,
                    putniNalog.BrojNaloga,
                    putniNalog.Polaziste,
                    putniNalog.Odrediste,
                    putniNalog.BrojDana,
                    putniNalog.DatumOtvaranja,
                    putniNalog.DatumZatvaranja,
                    "Uredi",
                    "Rute",
                    "Obriši"
                });
                    dgwPutniNalozi.Rows[dgwPutniNalozi.RowCount - 1].Tag = putniNalog;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmAddEditPutniNalog frmAddEditNalog = new frmAddEditPutniNalog();
            if (frmAddEditNalog.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgwPutniNalozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                new frmAddEditPutniNalog((PutniNalog)dgwPutniNalozi.CurrentRow.Tag).ShowDialog();
                LoadData();
            }

            if (e.ColumnIndex == 9)
            {
                new frmAddEditRuta(((PutniNalog)dgwPutniNalozi.CurrentRow.Tag).IDPutniNalog).ShowDialog();
                LoadData();
            }

            if (e.ColumnIndex == 10)
            {
                try
                {
                    if (MessageBox.Show("Jeste li sigurni da zelite izbrisati?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (SqlHelper.DeletePutniNalog(((PutniNalog)dgwPutniNalozi.CurrentRow.Tag).IDPutniNalog) > 0)
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

        private void btnZatvoreni_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowItem in dgwPutniNalozi.Rows)
            {
                if (rowItem.Cells["Column8"].Value != null && DateTime.Parse(rowItem.Cells["Column7"].Value.ToString()) <= DateTime.Now)
                    rowItem.Visible = true;   
                
                else 
                    rowItem.Visible = false;
            }
        }

        private void btnAktivni_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowItem in dgwPutniNalozi.Rows)
            {
                if (rowItem.Cells["Column8"].Value == null && DateTime.Parse(rowItem.Cells["Column7"].Value.ToString()) <= DateTime.Now)
                    rowItem.Visible = true;

                else
                    rowItem.Visible = false;
            }
        }

        private void btnBuduci_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowItem in dgwPutniNalozi.Rows)
            {
                if (DateTime.Parse(rowItem.Cells["Column7"].Value.ToString()) > DateTime.Now)
                    rowItem.Visible = true;

                else
                    rowItem.Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
