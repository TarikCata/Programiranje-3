namespace DLWMS.WinForms.IB200252
{
    partial class frmStudentiCovidTestovi
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
            this.dgvStudentiCovidTestovi = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRezultat = new System.Windows.Forms.ComboBox();
            this.cbNalaz = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiCovidTestovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentiCovidTestovi
            // 
            this.dgvStudentiCovidTestovi.AllowUserToAddRows = false;
            this.dgvStudentiCovidTestovi.AllowUserToDeleteRows = false;
            this.dgvStudentiCovidTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiCovidTestovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.Dostavljen});
            this.dgvStudentiCovidTestovi.Location = new System.Drawing.Point(12, 89);
            this.dgvStudentiCovidTestovi.Name = "dgvStudentiCovidTestovi";
            this.dgvStudentiCovidTestovi.ReadOnly = true;
            this.dgvStudentiCovidTestovi.RowHeadersWidth = 51;
            this.dgvStudentiCovidTestovi.RowTemplate.Height = 24;
            this.dgvStudentiCovidTestovi.Size = new System.Drawing.Size(776, 270);
            this.dgvStudentiCovidTestovi.TabIndex = 0;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
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
            // Rezultat
            // 
            this.Rezultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.MinimumWidth = 6;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            // 
            // Dostavljen
            // 
            this.Dostavljen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dostavljen.DataPropertyName = "Dostavljen";
            this.Dostavljen.HeaderText = "Dostavljen";
            this.Dostavljen.MinimumWidth = 6;
            this.Dostavljen.Name = "Dostavljen";
            this.Dostavljen.ReadOnly = true;
            this.Dostavljen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dostavljen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(14, 378);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(0, 16);
            this.lblBrojTestova.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generisanje Testova:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brisanje Testova:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj Testova:";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(341, 411);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 6;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(503, 396);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(147, 38);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi Testove";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 415);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 41);
            this.btnPrintaj.TabIndex = 8;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(12, 41);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(136, 24);
            this.cmbStudent.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(175, 42);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum Testiranja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rezultat Testa";
            // 
            // cmbRezultat
            // 
            this.cmbRezultat.FormattingEnabled = true;
            this.cmbRezultat.Location = new System.Drawing.Point(423, 44);
            this.cmbRezultat.Name = "cmbRezultat";
            this.cmbRezultat.Size = new System.Drawing.Size(121, 24);
            this.cmbRezultat.TabIndex = 14;
            // 
            // cbNalaz
            // 
            this.cbNalaz.AutoSize = true;
            this.cbNalaz.Location = new System.Drawing.Point(578, 44);
            this.cbNalaz.Name = "cbNalaz";
            this.cbNalaz.Size = new System.Drawing.Size(129, 20);
            this.cbNalaz.TabIndex = 15;
            this.cbNalaz.Text = "Nalaz dostavljen";
            this.cbNalaz.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(713, 41);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmStudentiCovidTestovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbNalaz);
            this.Controls.Add(this.cmbRezultat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.dgvStudentiCovidTestovi);
            this.Name = "frmStudentiCovidTestovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentiCovidTestovi";
            this.Load += new System.EventHandler(this.frmStudentiCovidTestovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiCovidTestovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentiCovidTestovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dostavljen;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRezultat;
        private System.Windows.Forms.CheckBox cbNalaz;
        private System.Windows.Forms.Button btnDodaj;
    }
}