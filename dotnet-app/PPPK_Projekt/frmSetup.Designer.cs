
namespace PPPK_Projekt
{
    partial class frmSetup
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnCleanDb = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(14, 73);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(105, 45);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(136, 73);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(105, 45);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnCleanDb
            // 
            this.btnCleanDb.BackColor = System.Drawing.Color.Red;
            this.btnCleanDb.Location = new System.Drawing.Point(136, 12);
            this.btnCleanDb.Name = "btnCleanDb";
            this.btnCleanDb.Size = new System.Drawing.Size(105, 45);
            this.btnCleanDb.TabIndex = 3;
            this.btnCleanDb.Text = "Clean db";
            this.btnCleanDb.UseVisualStyleBackColor = false;
            this.btnCleanDb.Click += new System.EventHandler(this.btnCleanDb_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(14, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(105, 45);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import random podataka";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 136);
            this.Controls.Add(this.btnCleanDb);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnCleanDb;
        private System.Windows.Forms.Button btnImport;
    }
}