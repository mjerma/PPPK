namespace PPPK_Projekt
{
    partial class frmPutniNalogList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAktivni = new System.Windows.Forms.Button();
            this.btnZatvoreni = new System.Windows.Forms.Button();
            this.btnBuduci = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgwPutniNalozi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPutniNalozi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1061, 74);
            this.pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Putni nalozi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAktivni);
            this.panel1.Controls.Add(this.btnZatvoreni);
            this.panel1.Controls.Add(this.btnBuduci);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.dgwPutniNalozi);
            this.panel1.Location = new System.Drawing.Point(18, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 529);
            this.panel1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(122, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAktivni
            // 
            this.btnAktivni.Location = new System.Drawing.Point(791, 14);
            this.btnAktivni.Name = "btnAktivni";
            this.btnAktivni.Size = new System.Drawing.Size(71, 29);
            this.btnAktivni.TabIndex = 4;
            this.btnAktivni.Text = "Aktivni";
            this.btnAktivni.UseVisualStyleBackColor = true;
            this.btnAktivni.Click += new System.EventHandler(this.btnAktivni_Click);
            // 
            // btnZatvoreni
            // 
            this.btnZatvoreni.Location = new System.Drawing.Point(945, 14);
            this.btnZatvoreni.Name = "btnZatvoreni";
            this.btnZatvoreni.Size = new System.Drawing.Size(71, 29);
            this.btnZatvoreni.TabIndex = 3;
            this.btnZatvoreni.Text = "Zatvoreni";
            this.btnZatvoreni.UseVisualStyleBackColor = true;
            this.btnZatvoreni.Click += new System.EventHandler(this.btnZatvoreni_Click);
            // 
            // btnBuduci
            // 
            this.btnBuduci.Location = new System.Drawing.Point(868, 14);
            this.btnBuduci.Name = "btnBuduci";
            this.btnBuduci.Size = new System.Drawing.Size(71, 29);
            this.btnBuduci.TabIndex = 2;
            this.btnBuduci.Text = "Budući";
            this.btnBuduci.UseVisualStyleBackColor = true;
            this.btnBuduci.Click += new System.EventHandler(this.btnBuduci_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 14);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(101, 29);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgwPutniNalozi
            // 
            this.dgwPutniNalozi.AllowUserToAddRows = false;
            this.dgwPutniNalozi.AllowUserToDeleteRows = false;
            this.dgwPutniNalozi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPutniNalozi.BackgroundColor = System.Drawing.Color.White;
            this.dgwPutniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPutniNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.edit,
            this.route,
            this.delete});
            this.dgwPutniNalozi.Location = new System.Drawing.Point(15, 58);
            this.dgwPutniNalozi.Name = "dgwPutniNalozi";
            this.dgwPutniNalozi.ReadOnly = true;
            this.dgwPutniNalozi.RowHeadersVisible = false;
            this.dgwPutniNalozi.Size = new System.Drawing.Size(1001, 457);
            this.dgwPutniNalozi.TabIndex = 0;
            this.dgwPutniNalozi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPutniNalozi_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 93.27411F;
            this.Column2.HeaderText = "Naredbodavac";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 93.27411F;
            this.Column3.HeaderText = "Broj naloga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 93.27411F;
            this.Column4.HeaderText = "Polazište";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 93.27411F;
            this.Column5.HeaderText = "Odredište";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Broj dana";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Datum otvaranja";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Datum zatvaranja";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // route
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.route.DefaultCellStyle = dataGridViewCellStyle2;
            this.route.HeaderText = "";
            this.route.Name = "route";
            this.route.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmPutniNalogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 637);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Name = "frmPutniNalogList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Putni nalozi";
            this.Shown += new System.EventHandler(this.frmPutniNalogList_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPutniNalozi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgwPutniNalozi;
        private System.Windows.Forms.Button btnBuduci;
        private System.Windows.Forms.Button btnAktivni;
        private System.Windows.Forms.Button btnZatvoreni;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}