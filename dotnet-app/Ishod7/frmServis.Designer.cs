
namespace Ishod7
{
    partial class frmServis
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
            this.btnHtmlReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbServisi = new System.Windows.Forms.ComboBox();
            this.lbVozila = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHtmlReport
            // 
            this.btnHtmlReport.Location = new System.Drawing.Point(77, 363);
            this.btnHtmlReport.Name = "btnHtmlReport";
            this.btnHtmlReport.Size = new System.Drawing.Size(120, 27);
            this.btnHtmlReport.TabIndex = 20;
            this.btnHtmlReport.Text = "HTML izvještaj";
            this.btnHtmlReport.UseVisualStyleBackColor = true;
            this.btnHtmlReport.Click += new System.EventHandler(this.btnHtmlReport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(103, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(23, 330);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 27);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(23, 283);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(236, 20);
            this.dtpDatum.TabIndex = 15;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(23, 182);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(236, 77);
            this.tbOpis.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Opis:";
            // 
            // cbServisi
            // 
            this.cbServisi.FormattingEnabled = true;
            this.cbServisi.Location = new System.Drawing.Point(23, 136);
            this.cbServisi.Name = "cbServisi";
            this.cbServisi.Size = new System.Drawing.Size(236, 21);
            this.cbServisi.TabIndex = 12;
            this.cbServisi.SelectedIndexChanged += new System.EventHandler(this.cbServisi_SelectedIndexChanged);
            // 
            // lbVozila
            // 
            this.lbVozila.FormattingEnabled = true;
            this.lbVozila.Location = new System.Drawing.Point(23, 13);
            this.lbVozila.Margin = new System.Windows.Forms.Padding(2);
            this.lbVozila.Name = "lbVozila";
            this.lbVozila.Size = new System.Drawing.Size(237, 95);
            this.lbVozila.TabIndex = 11;
            this.lbVozila.SelectedIndexChanged += new System.EventHandler(this.lbVozila_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Servis:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 407);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHtmlReport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbServisi);
            this.Controls.Add(this.lbVozila);
            this.Name = "frmServis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHtmlReport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbServisi;
        private System.Windows.Forms.ListBox lbVozila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
    }
}

