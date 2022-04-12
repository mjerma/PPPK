namespace PPPK_Projekt
{
    partial class MainMenu
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
            this.btnPutniNalozi = new System.Windows.Forms.Button();
            this.btnUnosVozila = new System.Windows.Forms.Button();
            this.btnVozaci = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPutniNalozi
            // 
            this.btnPutniNalozi.Location = new System.Drawing.Point(63, 180);
            this.btnPutniNalozi.Name = "btnPutniNalozi";
            this.btnPutniNalozi.Size = new System.Drawing.Size(146, 47);
            this.btnPutniNalozi.TabIndex = 3;
            this.btnPutniNalozi.Text = "Putni nalozi";
            this.btnPutniNalozi.UseVisualStyleBackColor = true;
            this.btnPutniNalozi.Click += new System.EventHandler(this.btnPutniNalozi_Click);
            // 
            // btnUnosVozila
            // 
            this.btnUnosVozila.Location = new System.Drawing.Point(63, 115);
            this.btnUnosVozila.Name = "btnUnosVozila";
            this.btnUnosVozila.Size = new System.Drawing.Size(146, 47);
            this.btnUnosVozila.TabIndex = 2;
            this.btnUnosVozila.Text = "Unos vozila";
            this.btnUnosVozila.UseVisualStyleBackColor = true;
            this.btnUnosVozila.Click += new System.EventHandler(this.btnUnosVozila_Click);
            // 
            // btnVozaci
            // 
            this.btnVozaci.Location = new System.Drawing.Point(63, 49);
            this.btnVozaci.Name = "btnVozaci";
            this.btnVozaci.Size = new System.Drawing.Size(146, 47);
            this.btnVozaci.TabIndex = 1;
            this.btnVozaci.Text = "Vozači";
            this.btnVozaci.UseVisualStyleBackColor = true;
            this.btnVozaci.Click += new System.EventHandler(this.btnVozaci_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Location = new System.Drawing.Point(63, 245);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(146, 47);
            this.btnBackupRestore.TabIndex = 4;
            this.btnBackupRestore.Text = "Setup";
            this.btnBackupRestore.UseVisualStyleBackColor = true;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 341);
            this.Controls.Add(this.btnBackupRestore);
            this.Controls.Add(this.btnVozaci);
            this.Controls.Add(this.btnPutniNalozi);
            this.Controls.Add(this.btnUnosVozila);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPutniNalozi;
        private System.Windows.Forms.Button btnUnosVozila;
        private System.Windows.Forms.Button btnVozaci;
        private System.Windows.Forms.Button btnBackupRestore;
    }
}

