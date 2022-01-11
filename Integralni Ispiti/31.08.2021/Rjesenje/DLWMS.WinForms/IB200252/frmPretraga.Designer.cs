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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPredmetiStudenti = new System.Windows.Forms.DataGridView();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblNajbolji = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSamoglasnici = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImeiPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolezeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili Prezime";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(121, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(664, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvPredmetiStudenti
            // 
            this.dgvPredmetiStudenti.AllowUserToAddRows = false;
            this.dgvPredmetiStudenti.AllowUserToDeleteRows = false;
            this.dgvPredmetiStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmetiStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImeiPrezime,
            this.PolezeniPredmeti,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dgvPredmetiStudenti.Location = new System.Drawing.Point(12, 63);
            this.dgvPredmetiStudenti.Name = "dgvPredmetiStudenti";
            this.dgvPredmetiStudenti.ReadOnly = true;
            this.dgvPredmetiStudenti.RowHeadersWidth = 51;
            this.dgvPredmetiStudenti.RowTemplate.Height = 24;
            this.dgvPredmetiStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredmetiStudenti.Size = new System.Drawing.Size(773, 213);
            this.dgvPredmetiStudenti.TabIndex = 2;
            this.dgvPredmetiStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmetiStudenti_CellContentClick);
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(9, 295);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 16);
            this.lblProsjek.TabIndex = 3;
            // 
            // lblNajbolji
            // 
            this.lblNajbolji.AutoSize = true;
            this.lblNajbolji.Location = new System.Drawing.Point(508, 295);
            this.lblNajbolji.Name = "lblNajbolji";
            this.lblNajbolji.Size = new System.Drawing.Size(0, 16);
            this.lblNajbolji.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 379);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(773, 79);
            this.textBox1.TabIndex = 5;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(690, 464);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(95, 31);
            this.btnGenerisi.TabIndex = 6;
            this.btnGenerisi.Text = "Generisi Info";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "SadrzajInfo";
            // 
            // lblSamoglasnici
            // 
            this.lblSamoglasnici.AutoSize = true;
            this.lblSamoglasnici.Location = new System.Drawing.Point(13, 497);
            this.lblSamoglasnici.Name = "lblSamoglasnici";
            this.lblSamoglasnici.Size = new System.Drawing.Size(0, 16);
            this.lblSamoglasnici.TabIndex = 8;
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.AutoSize = true;
            this.lblSuglasnici.Location = new System.Drawing.Point(13, 513);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(0, 16);
            this.lblSuglasnici.TabIndex = 9;
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.AutoSize = true;
            this.lblZnakovi.Location = new System.Drawing.Point(13, 529);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(0, 16);
            this.lblZnakovi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unesite Sadrzaj";
            // 
            // ImeiPrezime
            // 
            this.ImeiPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeiPrezime.DataPropertyName = "Student";
            this.ImeiPrezime.HeaderText = "Ime i Prezime";
            this.ImeiPrezime.MinimumWidth = 6;
            this.ImeiPrezime.Name = "ImeiPrezime";
            this.ImeiPrezime.ReadOnly = true;
            // 
            // PolezeniPredmeti
            // 
            this.PolezeniPredmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolezeniPredmeti.DataPropertyName = "Predmet";
            this.PolezeniPredmeti.HeaderText = "PolezeniPredmeti";
            this.PolezeniPredmeti.MinimumWidth = 6;
            this.PolezeniPredmeti.Name = "PolezeniPredmeti";
            this.PolezeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "BrojPolezenih";
            this.BrojPolozenih.HeaderText = "BrojPolozenih";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Ispiti
            // 
            this.Ispiti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispiti.HeaderText = "";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblZnakovi);
            this.Controls.Add(this.lblSuglasnici);
            this.Controls.Add(this.lblSamoglasnici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNajbolji);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvPredmetiStudenti);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPredmetiStudenti;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblNajbolji;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSamoglasnici;
        private System.Windows.Forms.Label lblSuglasnici;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeiPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolezeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}