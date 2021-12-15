namespace Prva_Parcijala_2018
{
    partial class Studenti
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
            this.btnDetalji = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNoviStudent = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgStudenti = new System.Windows.Forms.DataGridView();
            this.BrojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldtg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(599, 31);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(103, 23);
            this.btnDetalji.TabIndex = 0;
            this.btnDetalji.Text = "Prikazi Detalje";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNoviStudent
            // 
            this.btnNoviStudent.Location = new System.Drawing.Point(708, 31);
            this.btnNoviStudent.Name = "btnNoviStudent";
            this.btnNoviStudent.Size = new System.Drawing.Size(107, 23);
            this.btnNoviStudent.TabIndex = 2;
            this.btnNoviStudent.Text = "Novi Student";
            this.btnNoviStudent.UseVisualStyleBackColor = true;
            this.btnNoviStudent.Click += new System.EventHandler(this.btnNoviStudent_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(153, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(413, 22);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite Broj Indeksa";
            // 
            // dgStudenti
            // 
            this.dgStudenti.AllowUserToAddRows = false;
            this.dgStudenti.AllowUserToDeleteRows = false;
            this.dgStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojIndeksa,
            this.Ime,
            this.Prezime,
            this.Prosjek,
            this.BrojPolozenih});
            this.dgStudenti.Location = new System.Drawing.Point(15, 72);
            this.dgStudenti.Name = "dgStudenti";
            this.dgStudenti.ReadOnly = true;
            this.dgStudenti.RowHeadersWidth = 51;
            this.dgStudenti.RowTemplate.Height = 24;
            this.dgStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudenti.Size = new System.Drawing.Size(809, 339);
            this.dgStudenti.TabIndex = 5;
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojIndeksa.DataPropertyName = "BrojIndeksa";
            this.BrojIndeksa.HeaderText = "Broj Indeksa";
            this.BrojIndeksa.MinimumWidth = 6;
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjecna Ocjena";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "Broj Polozenih";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            // 
            // lbldtg
            // 
            this.lbldtg.AutoSize = true;
            this.lbldtg.Location = new System.Drawing.Point(12, 425);
            this.lbldtg.Name = "lbldtg";
            this.lbldtg.Size = new System.Drawing.Size(0, 16);
            this.lbldtg.TabIndex = 6;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.lbldtg);
            this.Controls.Add(this.dgStudenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnNoviStudent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDetalji);
            this.Name = "Studenti";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNoviStudent;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojIndeksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.Label lbldtg;
    }
}

