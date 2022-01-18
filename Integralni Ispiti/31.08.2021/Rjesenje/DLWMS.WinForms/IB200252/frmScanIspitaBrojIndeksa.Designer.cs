namespace DLWMS.WinForms.IB200252
{
    partial class frmScanIspitaBrojIndeksa
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
            this.dgvKorisniciScan = new System.Windows.Forms.DataGridView();
            this.ImeiPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolezeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnNoiv = new System.Windows.Forms.Button();
            this.lblKomunikacija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciScan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisniciScan
            // 
            this.dgvKorisniciScan.AllowUserToAddRows = false;
            this.dgvKorisniciScan.AllowUserToDeleteRows = false;
            this.dgvKorisniciScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImeiPrezime,
            this.PolezeniPredmeti,
            this.BrojPolozenih,
            this.Slika,
            this.Ispiti});
            this.dgvKorisniciScan.Location = new System.Drawing.Point(14, 86);
            this.dgvKorisniciScan.Name = "dgvKorisniciScan";
            this.dgvKorisniciScan.ReadOnly = true;
            this.dgvKorisniciScan.RowHeadersWidth = 51;
            this.dgvKorisniciScan.RowTemplate.Height = 24;
            this.dgvKorisniciScan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisniciScan.Size = new System.Drawing.Size(773, 306);
            this.dgvKorisniciScan.TabIndex = 3;
            this.dgvKorisniciScan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciScan_CellContentClick);
            // 
            // ImeiPrezime
            // 
            this.ImeiPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeiPrezime.DataPropertyName = "Predmet";
            this.ImeiPrezime.HeaderText = "Predmet";
            this.ImeiPrezime.MinimumWidth = 6;
            this.ImeiPrezime.Name = "ImeiPrezime";
            this.ImeiPrezime.ReadOnly = true;
            // 
            // PolezeniPredmeti
            // 
            this.PolezeniPredmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolezeniPredmeti.DataPropertyName = "Napomena";
            this.PolezeniPredmeti.HeaderText = "Napomena";
            this.PolezeniPredmeti.MinimumWidth = 6;
            this.PolezeniPredmeti.Name = "PolezeniPredmeti";
            this.PolezeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "Varanje";
            this.BrojPolozenih.HeaderText = "Varanje";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            this.BrojPolozenih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BrojPolozenih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // Ispiti
            // 
            this.Ispiti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispiti.HeaderText = "";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Brisi";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(693, 407);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(95, 31);
            this.btnPrintaj.TabIndex = 7;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnNoiv
            // 
            this.btnNoiv.Location = new System.Drawing.Point(667, 40);
            this.btnNoiv.Name = "btnNoiv";
            this.btnNoiv.Size = new System.Drawing.Size(120, 31);
            this.btnNoiv.TabIndex = 8;
            this.btnNoiv.Text = "Dodaj scan ispita";
            this.btnNoiv.UseVisualStyleBackColor = true;
            this.btnNoiv.Click += new System.EventHandler(this.btnNoiv_Click);
            // 
            // lblKomunikacija
            // 
            this.lblKomunikacija.AutoSize = true;
            this.lblKomunikacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomunikacija.Location = new System.Drawing.Point(18, 40);
            this.lblKomunikacija.Name = "lblKomunikacija";
            this.lblKomunikacija.Size = new System.Drawing.Size(0, 25);
            this.lblKomunikacija.TabIndex = 9;
            // 
            // frmScanIspitaBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKomunikacija);
            this.Controls.Add(this.btnNoiv);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvKorisniciScan);
            this.Name = "frmScanIspitaBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScanIspitaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisniciScan;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnNoiv;
        private System.Windows.Forms.Label lblKomunikacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeiPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolezeniPredmeti;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}