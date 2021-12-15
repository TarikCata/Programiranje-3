namespace cSharpIntroWinForms
{
    partial class frmGodineStudija
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnSpasiGodina = new System.Windows.Forms.Button();
            this.dgvGodineStudija = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodineStudija)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 31);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(219, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Location = new System.Drawing.Point(276, 33);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(73, 20);
            this.cbAktivna.TabIndex = 4;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSpasiGodina
            // 
            this.btnSpasiGodina.Location = new System.Drawing.Point(372, 28);
            this.btnSpasiGodina.Name = "btnSpasiGodina";
            this.btnSpasiGodina.Size = new System.Drawing.Size(98, 25);
            this.btnSpasiGodina.TabIndex = 5;
            this.btnSpasiGodina.Text = "Sacuvaj";
            this.btnSpasiGodina.UseVisualStyleBackColor = true;
            this.btnSpasiGodina.Click += new System.EventHandler(this.btnSpasiGodina_Click);
            // 
            // dgvGodineStudija
            // 
            this.dgvGodineStudija.AllowUserToAddRows = false;
            this.dgvGodineStudija.AllowUserToDeleteRows = false;
            this.dgvGodineStudija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodineStudija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Aktivna});
            this.dgvGodineStudija.Location = new System.Drawing.Point(12, 81);
            this.dgvGodineStudija.Name = "dgvGodineStudija";
            this.dgvGodineStudija.ReadOnly = true;
            this.dgvGodineStudija.RowHeadersWidth = 51;
            this.dgvGodineStudija.RowTemplate.Height = 24;
            this.dgvGodineStudija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGodineStudija.Size = new System.Drawing.Size(458, 199);
            this.dgvGodineStudija.TabIndex = 6;
            this.dgvGodineStudija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGodineStudija_CellContentClick);
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
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.MinimumWidth = 6;
            this.Aktivna.Name = "Aktivna";
            this.Aktivna.ReadOnly = true;
            this.Aktivna.Width = 125;
            // 
            // frmGodineStudija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 318);
            this.Controls.Add(this.dgvGodineStudija);
            this.Controls.Add(this.btnSpasiGodina);
            this.Controls.Add(this.cbAktivna);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmGodineStudija";
            this.Text = "frmGodineStudija";
            this.Load += new System.EventHandler(this.frmGodineStudija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodineStudija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.CheckBox cbAktivna;
        private System.Windows.Forms.Button btnSpasiGodina;
        private System.Windows.Forms.DataGridView dgvGodineStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
    }
}