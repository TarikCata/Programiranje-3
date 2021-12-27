namespace DLWMS.WinForms.Forme
{
    partial class frmStudentiPotvrde
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
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.txtGenerisi = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.lblpotvrde = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.AllowUserToAddRows = false;
            this.dgvPotvrde.AllowUserToDeleteRows = false;
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Datum,
            this.Aktivan});
            this.dgvPotvrde.Location = new System.Drawing.Point(13, 98);
            this.dgvPotvrde.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.ReadOnly = true;
            this.dgvPotvrde.RowHeadersWidth = 51;
            this.dgvPotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotvrde.Size = new System.Drawing.Size(774, 339);
            this.dgvPotvrde.TabIndex = 1;
            // 
            // txtGenerisi
            // 
            this.txtGenerisi.Location = new System.Drawing.Point(13, 61);
            this.txtGenerisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenerisi.Name = "txtGenerisi";
            this.txtGenerisi.Size = new System.Drawing.Size(147, 22);
            this.txtGenerisi.TabIndex = 3;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(167, 54);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(96, 37);
            this.btnGenerisi.TabIndex = 4;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(376, 54);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(89, 37);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(696, 54);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(92, 37);
            this.btnSpasi.TabIndex = 6;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            // 
            // lblpotvrde
            // 
            this.lblpotvrde.AutoSize = true;
            this.lblpotvrde.Location = new System.Drawing.Point(12, 444);
            this.lblpotvrde.Name = "lblpotvrde";
            this.lblpotvrde.Size = new System.Drawing.Size(0, 16);
            this.lblpotvrde.TabIndex = 7;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Student";
            this.Ime.HeaderText = "Student";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Svrha";
            this.Prezime.HeaderText = "Svrha";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Izdata";
            this.Aktivan.HeaderText = "Izdata";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 125;
            // 
            // frmStudentiPotvrde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.lblpotvrde);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.txtGenerisi);
            this.Controls.Add(this.dgvPotvrde);
            this.Name = "frmStudentiPotvrde";
            this.Text = "frmStudentiPotvrde";
            this.Load += new System.EventHandler(this.frmStudentiPotvrde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.TextBox txtGenerisi;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label lblpotvrde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
    }
}