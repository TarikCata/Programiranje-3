namespace DLWMS.WinForms.ib200252
{
    partial class frmPredmetiSeminarski
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBrojSlika = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.pbDonja = new System.Windows.Forms.PictureBox();
            this.pbGornja = new System.Windows.Forms.PictureBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGornja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(316, 20);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(64, 25);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "label1";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.Location = new System.Drawing.Point(315, 60);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(64, 25);
            this.lblPredmet.TabIndex = 3;
            this.lblPredmet.Text = "label1";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(238, 147);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(399, 84);
            this.txtOpis.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(535, 243);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(102, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj Sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBrojSlika
            // 
            this.lblBrojSlika.AutoSize = true;
            this.lblBrojSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSlika.Location = new System.Drawing.Point(300, 352);
            this.lblBrojSlika.Name = "lblBrojSlika";
            this.lblBrojSlika.Size = new System.Drawing.Size(81, 20);
            this.lblBrojSlika.TabIndex = 6;
            this.lblBrojSlika.Text = "Broj Slika";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(251, 652);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(59, 20);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(255, 692);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 20);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis";
            // 
            // pbDonja
            // 
            this.pbDonja.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbDonja.Location = new System.Drawing.Point(238, 398);
            this.pbDonja.Name = "pbDonja";
            this.pbDonja.Size = new System.Drawing.Size(249, 235);
            this.pbDonja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDonja.TabIndex = 1;
            this.pbDonja.TabStop = false;
            // 
            // pbGornja
            // 
            this.pbGornja.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbGornja.Location = new System.Drawing.Point(24, 147);
            this.pbGornja.Name = "pbGornja";
            this.pbGornja.Size = new System.Drawing.Size(138, 119);
            this.pbGornja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGornja.TabIndex = 0;
            this.pbGornja.TabStop = false;
            this.pbGornja.Click += new System.EventHandler(this.pbGornja_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijevo.Location = new System.Drawing.Point(87, 471);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 79);
            this.btnLijevo.TabIndex = 9;
            this.btnLijevo.Text = "<";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesno.Location = new System.Drawing.Point(574, 471);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 72);
            this.btnDesno.TabIndex = 10;
            this.btnDesno.Text = ">";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // frmPredmetiSeminarski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 828);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblBrojSlika);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.pbDonja);
            this.Controls.Add(this.pbGornja);
            this.Name = "frmPredmetiSeminarski";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPredmetiSeminarski";
            ((System.ComponentModel.ISupportInitialize)(this.pbDonja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGornja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGornja;
        private System.Windows.Forms.PictureBox pbDonja;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblBrojSlika;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
    }
}