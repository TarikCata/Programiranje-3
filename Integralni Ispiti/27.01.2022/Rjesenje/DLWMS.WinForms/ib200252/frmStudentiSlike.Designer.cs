namespace DLWMS.WinForms.ib200252
{
    partial class frmStudentiSlike
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
            this.txtOpisGornji = new System.Windows.Forms.TextBox();
            this.pbSlikaDodaj = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBrojSlika = new System.Windows.Forms.Label();
            this.lblOpisDonji = new System.Windows.Forms.Label();
            this.pbDonjaSlika = new System.Windows.Forms.PictureBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonjaSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpisGornji
            // 
            this.txtOpisGornji.Location = new System.Drawing.Point(246, 38);
            this.txtOpisGornji.Multiline = true;
            this.txtOpisGornji.Name = "txtOpisGornji";
            this.txtOpisGornji.Size = new System.Drawing.Size(395, 92);
            this.txtOpisGornji.TabIndex = 0;
            // 
            // pbSlikaDodaj
            // 
            this.pbSlikaDodaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlikaDodaj.Location = new System.Drawing.Point(39, 38);
            this.pbSlikaDodaj.Name = "pbSlikaDodaj";
            this.pbSlikaDodaj.Size = new System.Drawing.Size(142, 112);
            this.pbSlikaDodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaDodaj.TabIndex = 2;
            this.pbSlikaDodaj.TabStop = false;
            this.pbSlikaDodaj.Click += new System.EventHandler(this.pbSlikaDodaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(566, 157);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 29);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBrojSlika
            // 
            this.lblBrojSlika.AutoSize = true;
            this.lblBrojSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSlika.Location = new System.Drawing.Point(314, 222);
            this.lblBrojSlika.Name = "lblBrojSlika";
            this.lblBrojSlika.Size = new System.Drawing.Size(0, 20);
            this.lblBrojSlika.TabIndex = 4;
            // 
            // lblOpisDonji
            // 
            this.lblOpisDonji.AutoSize = true;
            this.lblOpisDonji.Location = new System.Drawing.Point(156, 521);
            this.lblOpisDonji.Name = "lblOpisDonji";
            this.lblOpisDonji.Size = new System.Drawing.Size(0, 16);
            this.lblOpisDonji.TabIndex = 5;
            // 
            // pbDonjaSlika
            // 
            this.pbDonjaSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDonjaSlika.Location = new System.Drawing.Point(245, 258);
            this.pbDonjaSlika.Name = "pbDonjaSlika";
            this.pbDonjaSlika.Size = new System.Drawing.Size(206, 195);
            this.pbDonjaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDonjaSlika.TabIndex = 6;
            this.pbDonjaSlika.TabStop = false;
            // 
            // btnLijevo
            // 
            this.btnLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijevo.Location = new System.Drawing.Point(105, 342);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 66);
            this.btnLijevo.TabIndex = 7;
            this.btnLijevo.Text = "<";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesno.Location = new System.Drawing.Point(534, 342);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 66);
            this.btnDesno.TabIndex = 8;
            this.btnDesno.Text = ">";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(247, 479);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 16);
            this.lblDatum.TabIndex = 9;
            // 
            // frmStudentiSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 684);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.pbDonjaSlika);
            this.Controls.Add(this.lblOpisDonji);
            this.Controls.Add(this.lblBrojSlika);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pbSlikaDodaj);
            this.Controls.Add(this.txtOpisGornji);
            this.Name = "frmStudentiSlike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStudentiSlike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonjaSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpisGornji;
        private System.Windows.Forms.PictureBox pbSlikaDodaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblBrojSlika;
        private System.Windows.Forms.Label lblOpisDonji;
        private System.Windows.Forms.PictureBox pbDonjaSlika;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Label lblDatum;
    }
}