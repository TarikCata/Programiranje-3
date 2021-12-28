namespace DLWMS.WinForms.IB200252
{
    partial class frmKoriscniciIspitiScan
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
            this.dgvIspiti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentIme = new System.Windows.Forms.Label();
            this.btnDodajScan = new System.Windows.Forms.Button();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Scan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIspiti
            // 
            this.dgvIspiti.AllowUserToAddRows = false;
            this.dgvIspiti.AllowUserToDeleteRows = false;
            this.dgvIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.Scan,
            this.Brisi});
            this.dgvIspiti.Location = new System.Drawing.Point(12, 104);
            this.dgvIspiti.Name = "dgvIspiti";
            this.dgvIspiti.ReadOnly = true;
            this.dgvIspiti.RowHeadersWidth = 51;
            this.dgvIspiti.RowTemplate.Height = 24;
            this.dgvIspiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIspiti.Size = new System.Drawing.Size(776, 265);
            this.dgvIspiti.TabIndex = 0;
            this.dgvIspiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellContentClick);
            this.dgvIspiti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregleda ispita za: ";
            // 
            // lblStudentIme
            // 
            this.lblStudentIme.AutoSize = true;
            this.lblStudentIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIme.Location = new System.Drawing.Point(235, 39);
            this.lblStudentIme.Name = "lblStudentIme";
            this.lblStudentIme.Size = new System.Drawing.Size(0, 29);
            this.lblStudentIme.TabIndex = 2;
            // 
            // btnDodajScan
            // 
            this.btnDodajScan.Location = new System.Drawing.Point(641, 40);
            this.btnDodajScan.Name = "btnDodajScan";
            this.btnDodajScan.Size = new System.Drawing.Size(147, 34);
            this.btnDodajScan.TabIndex = 3;
            this.btnDodajScan.Text = "Dodaj Scan Ispita";
            this.btnDodajScan.UseVisualStyleBackColor = true;
            this.btnDodajScan.Click += new System.EventHandler(this.btnDodajScan_Click);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Premdet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varao";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            this.Varanje.Width = 125;
            // 
            // Scan
            // 
            this.Scan.DataPropertyName = "Scan";
            this.Scan.HeaderText = "Scan";
            this.Scan.MinimumWidth = 6;
            this.Scan.Name = "Scan";
            this.Scan.ReadOnly = true;
            this.Scan.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Brisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Brisi.Text = "Brisi";
            this.Brisi.ToolTipText = "Brisi";
            this.Brisi.Width = 125;
            // 
            // frmKoriscniciIspitiScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.btnDodajScan);
            this.Controls.Add(this.lblStudentIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIspiti);
            this.Name = "frmKoriscniciIspitiScan";
            this.Text = "frmKoriscniciIspitiScan";
            this.Load += new System.EventHandler(this.frmKoriscniciIspitiScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIspiti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentIme;
        private System.Windows.Forms.Button btnDodajScan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scan;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}