namespace DLWMS.WinForms.IB200252
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStdPredmeti = new System.Windows.Forms.DataGridView();
            this.ImePrazime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjekPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsej = new System.Windows.Forms.Label();
            this.lblNajboljiProsjek = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Samoglasnici = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.lblKarakteri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(111, 27);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(805, 22);
            this.txtPretraga.TabIndex = 3;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime ili prezime";
            // 
            // dgvStdPredmeti
            // 
            this.dgvStdPredmeti.AllowUserToAddRows = false;
            this.dgvStdPredmeti.AllowUserToDeleteRows = false;
            this.dgvStdPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStdPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrazime,
            this.PolozeniPredmet,
            this.BrojPolozenih,
            this.ProsjekPolozenih,
            this.Ispiti});
            this.dgvStdPredmeti.Location = new System.Drawing.Point(12, 71);
            this.dgvStdPredmeti.Name = "dgvStdPredmeti";
            this.dgvStdPredmeti.ReadOnly = true;
            this.dgvStdPredmeti.RowHeadersWidth = 51;
            this.dgvStdPredmeti.RowTemplate.Height = 24;
            this.dgvStdPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStdPredmeti.Size = new System.Drawing.Size(904, 228);
            this.dgvStdPredmeti.TabIndex = 5;
            this.dgvStdPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStdPredmeti_CellContentClick);
            // 
            // ImePrazime
            // 
            this.ImePrazime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrazime.DataPropertyName = "Student";
            this.ImePrazime.HeaderText = "Ime i Prezime";
            this.ImePrazime.MinimumWidth = 6;
            this.ImePrazime.Name = "ImePrazime";
            this.ImePrazime.ReadOnly = true;
            // 
            // PolozeniPredmet
            // 
            this.PolozeniPredmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolozeniPredmet.DataPropertyName = "_Predmet";
            this.PolozeniPredmet.HeaderText = "Polozeni Predmet";
            this.PolozeniPredmet.MinimumWidth = 6;
            this.PolozeniPredmet.Name = "PolozeniPredmet";
            this.PolozeniPredmet.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "BrojPolozenih";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            this.BrojPolozenih.Width = 125;
            // 
            // ProsjekPolozenih
            // 
            this.ProsjekPolozenih.DataPropertyName = "Prosjek";
            this.ProsjekPolozenih.HeaderText = "ProsjekPolozenih";
            this.ProsjekPolozenih.MinimumWidth = 6;
            this.ProsjekPolozenih.Name = "ProsjekPolozenih";
            this.ProsjekPolozenih.ReadOnly = true;
            this.ProsjekPolozenih.Width = 125;
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.Width = 125;
            // 
            // lblProsej
            // 
            this.lblProsej.AutoSize = true;
            this.lblProsej.Location = new System.Drawing.Point(9, 316);
            this.lblProsej.Name = "lblProsej";
            this.lblProsej.Size = new System.Drawing.Size(0, 16);
            this.lblProsej.TabIndex = 6;
            // 
            // lblNajboljiProsjek
            // 
            this.lblNajboljiProsjek.AutoSize = true;
            this.lblNajboljiProsjek.Location = new System.Drawing.Point(577, 321);
            this.lblNajboljiProsjek.Name = "lblNajboljiProsjek";
            this.lblNajboljiProsjek.Size = new System.Drawing.Size(0, 16);
            this.lblNajboljiProsjek.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 340);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(901, 121);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sadrzaj Info";
            // 
            // Samoglasnici
            // 
            this.Samoglasnici.AutoSize = true;
            this.Samoglasnici.Location = new System.Drawing.Point(12, 494);
            this.Samoglasnici.Name = "Samoglasnici";
            this.Samoglasnici.Size = new System.Drawing.Size(0, 16);
            this.Samoglasnici.TabIndex = 10;
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.AutoSize = true;
            this.lblSuglasnici.Location = new System.Drawing.Point(9, 510);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(0, 16);
            this.lblSuglasnici.TabIndex = 11;
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.AutoSize = true;
            this.lblZnakovi.Location = new System.Drawing.Point(9, 549);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(0, 16);
            this.lblZnakovi.TabIndex = 12;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(811, 494);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(105, 41);
            this.btnGenerisi.TabIndex = 13;
            this.btnGenerisi.Text = "Generisi Info";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // lblKarakteri
            // 
            this.lblKarakteri.AutoSize = true;
            this.lblKarakteri.Location = new System.Drawing.Point(808, 466);
            this.lblKarakteri.Name = "lblKarakteri";
            this.lblKarakteri.Size = new System.Drawing.Size(0, 16);
            this.lblKarakteri.TabIndex = 14;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 600);
            this.Controls.Add(this.lblKarakteri);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.lblZnakovi);
            this.Controls.Add(this.lblSuglasnici);
            this.Controls.Add(this.Samoglasnici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNajboljiProsjek);
            this.Controls.Add(this.lblProsej);
            this.Controls.Add(this.dgvStdPredmeti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStdPredmeti;
        private System.Windows.Forms.Label lblProsej;
        private System.Windows.Forms.Label lblNajboljiProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrazime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjekPolozenih;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Samoglasnici;
        private System.Windows.Forms.Label lblSuglasnici;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Label lblKarakteri;
    }
}