
namespace DLWMS.WinForms.IB180207
{
    partial class frmCovidTestIB180207
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbRezultatTesta = new System.Windows.Forms.ComboBox();
            this.dtmDatumTestiranja = new System.Windows.Forms.DateTimePicker();
            this.cbNalaz = new System.Windows.Forms.CheckBox();
            this.txtBrojTestova = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnObrisiTestove = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbDel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum testiranja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezultat testa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj testova:";
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(97, 288);
            this.lblBrojTestova.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(44, 16);
            this.lblBrojTestova.TabIndex = 5;
            this.lblBrojTestova.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Generisanje testova:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Broj testova:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Brisanje testova:";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(16, 33);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(160, 24);
            this.cmbStudent.TabIndex = 9;
            // 
            // cmbRezultatTesta
            // 
            this.cmbRezultatTesta.FormattingEnabled = true;
            this.cmbRezultatTesta.Location = new System.Drawing.Point(460, 33);
            this.cmbRezultatTesta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRezultatTesta.Name = "cmbRezultatTesta";
            this.cmbRezultatTesta.Size = new System.Drawing.Size(132, 24);
            this.cmbRezultatTesta.TabIndex = 10;
            // 
            // dtmDatumTestiranja
            // 
            this.dtmDatumTestiranja.Location = new System.Drawing.Point(185, 34);
            this.dtmDatumTestiranja.Margin = new System.Windows.Forms.Padding(4);
            this.dtmDatumTestiranja.Name = "dtmDatumTestiranja";
            this.dtmDatumTestiranja.Size = new System.Drawing.Size(265, 22);
            this.dtmDatumTestiranja.TabIndex = 11;
            // 
            // cbNalaz
            // 
            this.cbNalaz.AutoSize = true;
            this.cbNalaz.Location = new System.Drawing.Point(601, 38);
            this.cbNalaz.Margin = new System.Windows.Forms.Padding(4);
            this.cbNalaz.Name = "cbNalaz";
            this.cbNalaz.Size = new System.Drawing.Size(129, 20);
            this.cbNalaz.TabIndex = 12;
            this.cbNalaz.Text = "Nalaz dostavljen";
            this.cbNalaz.UseVisualStyleBackColor = true;
            // 
            // txtBrojTestova
            // 
            this.txtBrojTestova.Location = new System.Drawing.Point(261, 302);
            this.txtBrojTestova.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojTestova.Name = "txtBrojTestova";
            this.txtBrojTestova.Size = new System.Drawing.Size(132, 22);
            this.txtBrojTestova.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Dostavljen,
            this.Datum,
            this.Rezultat});
            this.dataGridView1.Location = new System.Drawing.Point(16, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(821, 185);
            this.dataGridView1.TabIndex = 14;
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
            // Dostavljen
            // 
            this.Dostavljen.DataPropertyName = "Dostavljen";
            this.Dostavljen.HeaderText = "Dostavljen";
            this.Dostavljen.MinimumWidth = 6;
            this.Dostavljen.Name = "Dostavljen";
            this.Dostavljen.ReadOnly = true;
            this.Dostavljen.Width = 125;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "DatumTestiranja";
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
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(737, 31);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(403, 299);
            this.btnGenerisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(100, 28);
            this.btnGenerisi.TabIndex = 16;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnObrisiTestove
            // 
            this.btnObrisiTestove.Location = new System.Drawing.Point(520, 299);
            this.btnObrisiTestove.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiTestove.Name = "btnObrisiTestove";
            this.btnObrisiTestove.Size = new System.Drawing.Size(167, 28);
            this.btnObrisiTestove.TabIndex = 17;
            this.btnObrisiTestove.Text = "OBRISI TESTOVE";
            this.btnObrisiTestove.UseVisualStyleBackColor = true;
            this.btnObrisiTestove.Click += new System.EventHandler(this.btnObrisiTestove_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(737, 298);
            this.btnPrintaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(100, 28);
            this.btnPrintaj.TabIndex = 18;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Location = new System.Drawing.Point(12, 356);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(0, 16);
            this.lbAdd.TabIndex = 19;
            // 
            // lbDel
            // 
            this.lbDel.AutoSize = true;
            this.lbDel.Location = new System.Drawing.Point(16, 397);
            this.lbDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDel.Name = "lbDel";
            this.lbDel.Size = new System.Drawing.Size(0, 16);
            this.lbDel.TabIndex = 20;
            // 
            // frmCovidTestIB180207
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 422);
            this.Controls.Add(this.lbDel);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnObrisiTestove);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBrojTestova);
            this.Controls.Add(this.cbNalaz);
            this.Controls.Add(this.dtmDatumTestiranja);
            this.Controls.Add(this.cmbRezultatTesta);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCovidTestIB180207";
            this.Text = "frmCovidTestIB180207";
            this.Load += new System.EventHandler(this.frmCovidTestIB180207_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbRezultatTesta;
        private System.Windows.Forms.DateTimePicker dtmDatumTestiranja;
        private System.Windows.Forms.CheckBox cbNalaz;
        private System.Windows.Forms.TextBox txtBrojTestova;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnObrisiTestove;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dostavljen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbDel;
    }
}