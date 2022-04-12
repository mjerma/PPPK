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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnVozaci_Click(object sender, EventArgs e)
        {
            frmVozacList frmVozaci = new frmVozacList();
            frmVozaci.ShowDialog();
        }

        private void btnUnosVozila_Click(object sender, EventArgs e)
        {
            frmAddVozilo frmVozilo = new frmAddVozilo();
            frmVozilo.ShowDialog();
        }

        private void btnPutniNalozi_Click(object sender, EventArgs e)
        {
            frmPutniNalogList frmPutniNalozi = new frmPutniNalogList();
            frmPutniNalozi.ShowDialog();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            frmSetup frmBackupRestore = new frmSetup();
            frmBackupRestore.ShowDialog();
        }
    }
}
