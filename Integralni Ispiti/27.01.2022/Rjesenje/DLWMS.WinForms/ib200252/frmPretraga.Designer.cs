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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPredmeti = new System.Windows.Forms.DataGridView();
            this.ImeiPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Slilke = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Predmeta";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(200, 27);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(562, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvPredmeti
            // 
            this.dgvPredmeti.AllowUserToAddRows = false;
            this.dgvPredmeti.AllowUserToDeleteRows = false;
            this.dgvPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImeiPrezime,
            this.Predmet,
            this.DatumPolaganja,
            this.Ocjena,
            this.Brisi,
            this.Slilke});
            this.dgvPredmeti.Location = new System.Drawing.Point(33, 81);
            this.dgvPredmeti.Name = "dgvPredmeti";
            this.dgvPredmeti.ReadOnly = true;
            this.dgvPredmeti.RowHeadersWidth = 51;
            this.dgvPredmeti.RowTemplate.Height = 24;
            this.dgvPredmeti.Size = new System.Drawing.Size(808, 295);
            this.dgvPredmeti.TabIndex = 2;
            this.dgvPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmeti_CellContentClick);
            // 
            // ImeiPrezime
            // 
            this.ImeiPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeiPrezime.DataPropertyName = "Student";
            this.ImeiPrezime.HeaderText = "Ime i Prezime";
            this.ImeiPrezime.MinimumWidth = 6;
            this.ImeiPrezime.Name = "ImeiPrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.HeaderText = "DatumPolaganja";
            this.DatumPolaganja.MinimumWidth = 6;
            this.DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // Slilke
            // 
            this.Slilke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slilke.HeaderText = "";
            this.Slilke.MinimumWidth = 6;
            this.Slilke.Name = "Slilke";
            this.Slilke.Text = "Slike";
            this.Slilke.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 485);
            this.Controls.Add(this.dgvPredmeti);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeiPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.DataGridViewButtonColumn Slilke;
    }
}