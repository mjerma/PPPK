namespace PPPK_Projekt
{
    partial class frmAddEditVozac
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojMobitela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojVozackeDozvole = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(23, 34);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(226, 20);
            this.txtIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(23, 85);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(226, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj mobitela:";
            // 
            // txtBrojMobitela
            // 
            this.txtBrojMobitela.Location = new System.Drawing.Point(23, 136);
            this.txtBrojMobitela.Name = "txtBrojMobitela";
            this.txtBrojMobitela.Size = new System.Drawing.Size(226, 20);
            this.txtBrojMobitela.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj vozačke dozvole:";
            // 
            // txtBrojVozackeDozvole
            // 
            this.txtBrojVozackeDozvole.Location = new System.Drawing.Point(23, 184);
            this.txtBrojVozackeDozvole.Name = "txtBrojVozackeDozvole";
            this.txtBrojVozackeDozvole.Size = new System.Drawing.Size(226, 20);
            this.txtBrojVozackeDozvole.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDodaj.Location = new System.Drawing.Point(23, 231);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(109, 32);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(140, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmAddEditVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojVozackeDozvole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojMobitela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "frmAddEditVozac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojMobitela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojVozackeDozvole;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button2;
    }
}