namespace DLWMS.WinForms.IB200252
{
    partial class frmStudentiPotvrde
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
            this.txtGen = new System.Windows.Forms.TextBox();
            this.dgvPotvrd = new System.Windows.Forms.DataGridView();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.lblBrojPotvrda = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(13, 32);
            this.txtGen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(142, 22);
            this.txtGen.TabIndex = 3;
            // 
            // dgvPotvrd
            // 
            this.dgvPotvrd.AllowUserToAddRows = false;
            this.dgvPotvrd.AllowUserToDeleteRows = false;
            this.dgvPotvrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Svrha,
            this.Izdata});
            this.dgvPotvrd.Location = new System.Drawing.Point(13, 63);
            this.dgvPotvrd.Name = "dgvPotvrd";
            this.dgvPotvrd.ReadOnly = true;
            this.dgvPotvrd.RowHeadersWidth = 51;
            this.dgvPotvrd.RowTemplate.Height = 24;
            this.dgvPotvrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotvrd.Size = new System.Drawing.Size(775, 326);
            this.dgvPotvrd.TabIndex = 4;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(162, 32);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(103, 23);
            this.btnGenerisi.TabIndex = 5;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.s_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(421, 32);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 25);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(687, 32);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(101, 25);
            this.btnSpasi.TabIndex = 7;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            // 
            // lblBrojPotvrda
            // 
            this.lblBrojPotvrda.AutoSize = true;
            this.lblBrojPotvrda.Location = new System.Drawing.Point(12, 411);
            this.lblBrojPotvrda.Name = "lblBrojPotvrda";
            this.lblBrojPotvrda.Size = new System.Drawing.Size(0, 16);
            this.lblBrojPotvrda.TabIndex = 8;
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
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.MinimumWidth = 6;
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Izdata
            // 
            this.Izdata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.MinimumWidth = 6;
            this.Izdata.Name = "Izdata";
            this.Izdata.ReadOnly = true;
            // 
            // frmStudentiPotvrde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBrojPotvrda);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.dgvPotvrd);
            this.Controls.Add(this.txtGen);
            this.Name = "frmStudentiPotvrde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentiPotvrde";
            this.Load += new System.EventHandler(this.frmStudentiPotvrde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.DataGridView dgvPotvrd;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label lblBrojPotvrda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}