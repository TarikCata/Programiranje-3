namespace cSharpIntroWinForms.IB200252
{
    partial class frmPorukeBrojIndeksa
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
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.lblKomunikacija = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(669, 25);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(119, 27);
            this.btnNovaPoruka.TabIndex = 0;
            this.btnNovaPoruka.Text = "Nova poruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
            this.dgvPoruke.Location = new System.Drawing.Point(12, 58);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowHeadersWidth = 51;
            this.dgvPoruke.RowTemplate.Height = 24;
            this.dgvPoruke.Size = new System.Drawing.Size(776, 266);
            this.dgvPoruke.TabIndex = 1;
            // 
            // lblKomunikacija
            // 
            this.lblKomunikacija.AutoSize = true;
            this.lblKomunikacija.Location = new System.Drawing.Point(22, 25);
            this.lblKomunikacija.Name = "lblKomunikacija";
            this.lblKomunikacija.Size = new System.Drawing.Size(108, 16);
            this.lblKomunikacija.TabIndex = 2;
            this.lblKomunikacija.Text = "Komunikacija sa:";
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
            // Sadrzaj
            // 
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.MinimumWidth = 6;
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            this.Sadrzaj.Width = 125;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Brisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Brisi.Text = "Brisi";
            this.Brisi.Width = 125;
            // 
            // frmPorukeBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.lblKomunikacija);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.btnNovaPoruka);
            this.Name = "frmPorukeBrojIndeksa";
            this.Text = "frmPorukeBrojIndeksa";
            this.Load += new System.EventHandler(this.frmPorukeBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaPoruka;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Label lblKomunikacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}