namespace DLWMS.WinForms.ib200252
{
    partial class frmPretraga
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
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.ImeiPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPredmeti = new System.Windows.Forms.DataGridView();
            this.Rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmett = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjenaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seminarski = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimalna Ocjena:";
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Location = new System.Drawing.Point(135, 20);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(121, 24);
            this.cmbOcjene.TabIndex = 5;
            this.cmbOcjene.SelectedIndexChanged += new System.EventHandler(this.cmbOcjene_SelectedIndexChanged);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(284, 21);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(84, 23);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // ImeiPrezime
            // 
            this.ImeiPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeiPrezime.DataPropertyName = "Id";
            this.ImeiPrezime.HeaderText = "Rb";
            this.ImeiPrezime.MinimumWidth = 6;
            this.ImeiPrezime.Name = "ImeiPrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Student";
            this.Predmet.HeaderText = "Ime i Prezime";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "Predmet";
            this.DatumPolaganja.HeaderText = "Predmet";
            this.DatumPolaganja.MinimumWidth = 6;
            this.DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumPolaganja";
            this.Datum.HeaderText = "DatumPolaganja";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.Width = 125;
            // 
            // dgvPredmeti
            // 
            this.dgvPredmeti.AllowUserToAddRows = false;
            this.dgvPredmeti.AllowUserToDeleteRows = false;
            this.dgvPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rb,
            this.ImePrezime,
            this.Predmett,
            this.Datumm,
            this.Ocjenaa,
            this.Seminarski});
            this.dgvPredmeti.Location = new System.Drawing.Point(15, 59);
            this.dgvPredmeti.Name = "dgvPredmeti";
            this.dgvPredmeti.ReadOnly = true;
            this.dgvPredmeti.RowHeadersWidth = 51;
            this.dgvPredmeti.RowTemplate.Height = 24;
            this.dgvPredmeti.Size = new System.Drawing.Size(810, 342);
            this.dgvPredmeti.TabIndex = 7;
            this.dgvPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmeti_CellContentClick);
            // 
            // Rb
            // 
            this.Rb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rb.DataPropertyName = "Id";
            this.Rb.HeaderText = "Rb";
            this.Rb.MinimumWidth = 6;
            this.Rb.Name = "Rb";
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmett
            // 
            this.Predmett.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmett.DataPropertyName = "Predmet";
            this.Predmett.HeaderText = "Predmet";
            this.Predmett.MinimumWidth = 6;
            this.Predmett.Name = "Predmett";
            // 
            // Datumm
            // 
            this.Datumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datumm.DataPropertyName = "DatumPolaganja";
            this.Datumm.HeaderText = "Datum Polaganja";
            this.Datumm.MinimumWidth = 6;
            this.Datumm.Name = "Datumm";
            // 
            // Ocjenaa
            // 
            this.Ocjenaa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjenaa.DataPropertyName = "Ocjena";
            this.Ocjenaa.HeaderText = "Ocjena";
            this.Ocjenaa.MinimumWidth = 6;
            this.Ocjenaa.Name = "Ocjenaa";
            // 
            // Seminarski
            // 
            this.Seminarski.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seminarski.HeaderText = "";
            this.Seminarski.MinimumWidth = 6;
            this.Seminarski.Name = "Seminarski";
            this.Seminarski.Text = "Seminarski";
            this.Seminarski.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 521);
            this.Controls.Add(this.dgvPredmeti);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeiPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridView dgvPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmett;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjenaa;
        private System.Windows.Forms.DataGridViewButtonColumn Seminarski;
    }
}