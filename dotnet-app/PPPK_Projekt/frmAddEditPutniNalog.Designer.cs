namespace PPPK_Projekt
{
    partial class frmAddEditPutniNalog
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojNaloga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaredbodavac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPolaziste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumOtvaranja = new System.Windows.Forms.DateTimePicker();
            this.cbVozac = new System.Windows.Forms.ComboBox();
            this.cbVozilo = new System.Windows.Forms.ComboBox();
            this.dtpDatumZatvaranja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumZatvaranja = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(386, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDodaj.Location = new System.Drawing.Point(270, 220);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(109, 32);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vozilo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vozač:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Broj naloga:";
            // 
            // txtBrojNaloga
            // 
            this.txtBrojNaloga.Location = new System.Drawing.Point(269, 32);
            this.txtBrojNaloga.Name = "txtBrojNaloga";
            this.txtBrojNaloga.Size = new System.Drawing.Size(226, 20);
            this.txtBrojNaloga.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Naredbodavac:";
            // 
            // txtNaredbodavac
            // 
            this.txtNaredbodavac.Location = new System.Drawing.Point(27, 32);
            this.txtNaredbodavac.Name = "txtNaredbodavac";
            this.txtNaredbodavac.Size = new System.Drawing.Size(226, 20);
            this.txtNaredbodavac.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Polazište:";
            // 
            // txtPolaziste
            // 
            this.txtPolaziste.Location = new System.Drawing.Point(27, 126);
            this.txtPolaziste.Name = "txtPolaziste";
            this.txtPolaziste.Size = new System.Drawing.Size(226, 20);
            this.txtPolaziste.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Odredište:";
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(269, 126);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(226, 20);
            this.txtOdrediste.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Broj dana:";
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Location = new System.Drawing.Point(27, 173);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(226, 20);
            this.txtBrojDana.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Datum otvaranja:";
            // 
            // dtpDatumOtvaranja
            // 
            this.dtpDatumOtvaranja.Location = new System.Drawing.Point(269, 173);
            this.dtpDatumOtvaranja.Name = "dtpDatumOtvaranja";
            this.dtpDatumOtvaranja.Size = new System.Drawing.Size(226, 20);
            this.dtpDatumOtvaranja.TabIndex = 30;
            // 
            // cbVozac
            // 
            this.cbVozac.FormattingEnabled = true;
            this.cbVozac.Location = new System.Drawing.Point(27, 79);
            this.cbVozac.Name = "cbVozac";
            this.cbVozac.Size = new System.Drawing.Size(226, 21);
            this.cbVozac.TabIndex = 32;
            // 
            // cbVozilo
            // 
            this.cbVozilo.FormattingEnabled = true;
            this.cbVozilo.Location = new System.Drawing.Point(269, 79);
            this.cbVozilo.Name = "cbVozilo";
            this.cbVozilo.Size = new System.Drawing.Size(226, 21);
            this.cbVozilo.TabIndex = 33;
            // 
            // dtpDatumZatvaranja
            // 
            this.dtpDatumZatvaranja.Location = new System.Drawing.Point(27, 224);
            this.dtpDatumZatvaranja.Name = "dtpDatumZatvaranja";
            this.dtpDatumZatvaranja.Size = new System.Drawing.Size(226, 20);
            this.dtpDatumZatvaranja.TabIndex = 35;
            // 
            // lblDatumZatvaranja
            // 
            this.lblDatumZatvaranja.AutoSize = true;
            this.lblDatumZatvaranja.Location = new System.Drawing.Point(24, 208);
            this.lblDatumZatvaranja.Name = "lblDatumZatvaranja";
            this.lblDatumZatvaranja.Size = new System.Drawing.Size(93, 13);
            this.lblDatumZatvaranja.TabIndex = 34;
            this.lblDatumZatvaranja.Text = "Datum zatvaranja:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(27, 251);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 36;
            // 
            // frmAddEditPutniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 270);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dtpDatumZatvaranja);
            this.Controls.Add(this.lblDatumZatvaranja);
            this.Controls.Add(this.cbVozilo);
            this.Controls.Add(this.cbVozac);
            this.Controls.Add(this.dtpDatumOtvaranja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrojDana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOdrediste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPolaziste);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojNaloga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaredbodavac);
            this.Name = "frmAddEditPutniNalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Putni nalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojNaloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaredbodavac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPolaziste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumOtvaranja;
        private System.Windows.Forms.ComboBox cbVozac;
        private System.Windows.Forms.ComboBox cbVozilo;
        private System.Windows.Forms.DateTimePicker dtpDatumZatvaranja;
        private System.Windows.Forms.Label lblDatumZatvaranja;
        private System.Windows.Forms.Label lblInfo;
    }
}