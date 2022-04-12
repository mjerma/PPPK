
namespace PPPK_Projekt
{
    partial class frmAddEditRuta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProsjecnaBrzina = new System.Windows.Forms.TextBox();
            this.txtKoordinataA = new System.Windows.Forms.TextBox();
            this.txtKoordinataB = new System.Windows.Forms.TextBox();
            this.txtPrijedeniKilometri = new System.Windows.Forms.TextBox();
            this.txtPotrosenoGorivo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRute = new System.Windows.Forms.ComboBox();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koordinata A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koordinata B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijeđeni kilometri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prosječna brzina (km/h)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Potrošeno gorivo (L)";
            // 
            // txtProsjecnaBrzina
            // 
            this.txtProsjecnaBrzina.Location = new System.Drawing.Point(135, 190);
            this.txtProsjecnaBrzina.Name = "txtProsjecnaBrzina";
            this.txtProsjecnaBrzina.Size = new System.Drawing.Size(158, 20);
            this.txtProsjecnaBrzina.TabIndex = 10;
            // 
            // txtKoordinataA
            // 
            this.txtKoordinataA.Location = new System.Drawing.Point(135, 97);
            this.txtKoordinataA.Name = "txtKoordinataA";
            this.txtKoordinataA.Size = new System.Drawing.Size(158, 20);
            this.txtKoordinataA.TabIndex = 7;
            // 
            // txtKoordinataB
            // 
            this.txtKoordinataB.Location = new System.Drawing.Point(135, 128);
            this.txtKoordinataB.Name = "txtKoordinataB";
            this.txtKoordinataB.Size = new System.Drawing.Size(158, 20);
            this.txtKoordinataB.TabIndex = 8;
            // 
            // txtPrijedeniKilometri
            // 
            this.txtPrijedeniKilometri.Location = new System.Drawing.Point(135, 159);
            this.txtPrijedeniKilometri.Name = "txtPrijedeniKilometri";
            this.txtPrijedeniKilometri.Size = new System.Drawing.Size(158, 20);
            this.txtPrijedeniKilometri.TabIndex = 9;
            // 
            // txtPotrosenoGorivo
            // 
            this.txtPotrosenoGorivo.Location = new System.Drawing.Point(135, 220);
            this.txtPotrosenoGorivo.Name = "txtPotrosenoGorivo";
            this.txtPotrosenoGorivo.Size = new System.Drawing.Size(158, 20);
            this.txtPotrosenoGorivo.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 259);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 30);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(111, 259);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(85, 30);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(208, 259);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(85, 30);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(63, 300);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(85, 30);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(154, 300);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 30);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ruta";
            // 
            // cbRute
            // 
            this.cbRute.FormattingEnabled = true;
            this.cbRute.Location = new System.Drawing.Point(13, 28);
            this.cbRute.Name = "cbRute";
            this.cbRute.Size = new System.Drawing.Size(281, 21);
            this.cbRute.TabIndex = 5;
            this.cbRute.DropDownClosed += new System.EventHandler(this.cbRute_DropDownClosed);
            // 
            // txtSati
            // 
            this.txtSati.Location = new System.Drawing.Point(135, 62);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(158, 20);
            this.txtSati.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sati";
            // 
            // frmAddEditRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 345);
            this.Controls.Add(this.txtSati);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPotrosenoGorivo);
            this.Controls.Add(this.txtPrijedeniKilometri);
            this.Controls.Add(this.txtKoordinataB);
            this.Controls.Add(this.txtKoordinataA);
            this.Controls.Add(this.txtProsjecnaBrzina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEditRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Ruta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProsjecnaBrzina;
        private System.Windows.Forms.TextBox txtKoordinataA;
        private System.Windows.Forms.TextBox txtKoordinataB;
        private System.Windows.Forms.TextBox txtPrijedeniKilometri;
        private System.Windows.Forms.TextBox txtPotrosenoGorivo;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRute;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.Label label7;
    }
}