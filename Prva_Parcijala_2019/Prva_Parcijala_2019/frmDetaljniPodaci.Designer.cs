namespace Prva_Parcijala_2018
{
    partial class frmDetaljniPodaci
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
            this.pbStudentSlika = new System.Windows.Forms.PictureBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStudentSlika
            // 
            this.pbStudentSlika.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbStudentSlika.Location = new System.Drawing.Point(12, 32);
            this.pbStudentSlika.Name = "pbStudentSlika";
            this.pbStudentSlika.Size = new System.Drawing.Size(200, 214);
            this.pbStudentSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudentSlika.TabIndex = 9;
            this.pbStudentSlika.TabStop = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(249, 157);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(251, 22);
            this.txtPrezime.TabIndex = 12;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(249, 97);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(251, 22);
            this.txtIme.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(249, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(251, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.BackColor = System.Drawing.SystemColors.Control;
            this.txtBrojIndeksa.Location = new System.Drawing.Point(249, 40);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.ReadOnly = true;
            this.txtBrojIndeksa.Size = new System.Drawing.Size(251, 22);
            this.txtBrojIndeksa.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Ocjena,
            this.DatumPolaganja});
            this.dataGridView1.Location = new System.Drawing.Point(12, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 309);
            this.dataGridView1.TabIndex = 14;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.DataPropertyName = "_DateTime";
            this.DatumPolaganja.HeaderText = "Datum Polaganja";
            this.DatumPolaganja.MinimumWidth = 6;
            this.DatumPolaganja.Name = "DatumPolaganja";
            this.DatumPolaganja.ReadOnly = true;
            this.DatumPolaganja.Width = 125;
            // 
            // frmDetaljniPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.pbStudentSlika);
            this.Name = "frmDetaljniPodaci";
            this.Text = "frmDetaljniPodaci";
            this.Load += new System.EventHandler(this.frmDetaljniPodaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStudentSlika;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
    }
}