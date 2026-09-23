namespace _14_VideogiochiSQLServer.Views
{
    partial class FrmPartite
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.grpNuovaPartita = new System.Windows.Forms.GroupBox();
            this.btnSalvaPartita = new System.Windows.Forms.Button();
            this.numNPPunteggio = new System.Windows.Forms.NumericUpDown();
            this.lblNPPunteggio = new System.Windows.Forms.Label();
            this.dtpNPData = new System.Windows.Forms.DateTimePicker();
            this.lblNPData = new System.Windows.Forms.Label();
            this.cmbNPGioco = new System.Windows.Forms.ComboBox();
            this.lblNPGioco = new System.Windows.Forms.Label();
            this.cmbNPGiocatore = new System.Windows.Forms.ComboBox();
            this.lblNPGiocatore = new System.Windows.Forms.Label();
            this.grpFiltri = new System.Windows.Forms.GroupBox();
            this.btnTutte = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.cmbFiltGioco = new System.Windows.Forms.ComboBox();
            this.lblFiltGioco = new System.Windows.Forms.Label();
            this.cmbFiltGiocatore = new System.Windows.Forms.ComboBox();
            this.lblFiltGioc = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvPartite = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.grpNuovaPartita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNPPunteggio)).BeginInit();
            this.grpFiltri.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1416, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1416, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Storico Partite";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.grpNuovaPartita);
            this.pnlControls.Controls.Add(this.grpFiltri);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 62);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1416, 228);
            this.pnlControls.TabIndex = 1;
            // 
            // grpNuovaPartita
            // 
            this.grpNuovaPartita.Controls.Add(this.btnSalvaPartita);
            this.grpNuovaPartita.Controls.Add(this.numNPPunteggio);
            this.grpNuovaPartita.Controls.Add(this.lblNPPunteggio);
            this.grpNuovaPartita.Controls.Add(this.dtpNPData);
            this.grpNuovaPartita.Controls.Add(this.lblNPData);
            this.grpNuovaPartita.Controls.Add(this.cmbNPGioco);
            this.grpNuovaPartita.Controls.Add(this.lblNPGioco);
            this.grpNuovaPartita.Controls.Add(this.cmbNPGiocatore);
            this.grpNuovaPartita.Controls.Add(this.lblNPGiocatore);
            this.grpNuovaPartita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNuovaPartita.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNuovaPartita.Location = new System.Drawing.Point(707, 0);
            this.grpNuovaPartita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuovaPartita.Name = "grpNuovaPartita";
            this.grpNuovaPartita.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuovaPartita.Size = new System.Drawing.Size(709, 228);
            this.grpNuovaPartita.TabIndex = 1;
            this.grpNuovaPartita.TabStop = false;
            this.grpNuovaPartita.Text = "Nuova Partita";
            // 
            // btnSalvaPartita
            // 
            this.btnSalvaPartita.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvaPartita.Location = new System.Drawing.Point(112, 192);
            this.btnSalvaPartita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvaPartita.Name = "btnSalvaPartita";
            this.btnSalvaPartita.Size = new System.Drawing.Size(267, 37);
            this.btnSalvaPartita.TabIndex = 8;
            this.btnSalvaPartita.Text = "Registra Partita";
            this.btnSalvaPartita.Click += new System.EventHandler(this.btnSalvaPartita_Click);
            // 
            // numNPPunteggio
            // 
            this.numNPPunteggio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numNPPunteggio.Location = new System.Drawing.Point(112, 153);
            this.numNPPunteggio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNPPunteggio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numNPPunteggio.Name = "numNPPunteggio";
            this.numNPPunteggio.Size = new System.Drawing.Size(160, 30);
            this.numNPPunteggio.TabIndex = 7;
            this.numNPPunteggio.ValueChanged += new System.EventHandler(this.numNPPunteggio_ValueChanged);
            // 
            // lblNPPunteggio
            // 
            this.lblNPPunteggio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNPPunteggio.Location = new System.Drawing.Point(11, 155);
            this.lblNPPunteggio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNPPunteggio.Name = "lblNPPunteggio";
            this.lblNPPunteggio.Size = new System.Drawing.Size(93, 25);
            this.lblNPPunteggio.TabIndex = 6;
            this.lblNPPunteggio.Text = "Punteggio";
            // 
            // dtpNPData
            // 
            this.dtpNPData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNPData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNPData.Location = new System.Drawing.Point(112, 113);
            this.dtpNPData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNPData.Name = "dtpNPData";
            this.dtpNPData.Size = new System.Drawing.Size(265, 30);
            this.dtpNPData.TabIndex = 5;
            this.dtpNPData.ValueChanged += new System.EventHandler(this.dtpNPData_ValueChanged);
            // 
            // lblNPData
            // 
            this.lblNPData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNPData.Location = new System.Drawing.Point(11, 116);
            this.lblNPData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNPData.Name = "lblNPData";
            this.lblNPData.Size = new System.Drawing.Size(93, 25);
            this.lblNPData.TabIndex = 4;
            this.lblNPData.Text = "Data";
            // 
            // cmbNPGioco
            // 
            this.cmbNPGioco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPGioco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNPGioco.Location = new System.Drawing.Point(112, 74);
            this.cmbNPGioco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNPGioco.Name = "cmbNPGioco";
            this.cmbNPGioco.Size = new System.Drawing.Size(265, 31);
            this.cmbNPGioco.TabIndex = 3;
            this.cmbNPGioco.SelectedIndexChanged += new System.EventHandler(this.cmbNPGioco_SelectedIndexChanged);
            // 
            // lblNPGioco
            // 
            this.lblNPGioco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNPGioco.Location = new System.Drawing.Point(11, 76);
            this.lblNPGioco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNPGioco.Name = "lblNPGioco";
            this.lblNPGioco.Size = new System.Drawing.Size(93, 25);
            this.lblNPGioco.TabIndex = 2;
            this.lblNPGioco.Text = "Gioco";
            // 
            // cmbNPGiocatore
            // 
            this.cmbNPGiocatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPGiocatore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNPGiocatore.Location = new System.Drawing.Point(112, 34);
            this.cmbNPGiocatore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNPGiocatore.Name = "cmbNPGiocatore";
            this.cmbNPGiocatore.Size = new System.Drawing.Size(265, 31);
            this.cmbNPGiocatore.TabIndex = 1;
            this.cmbNPGiocatore.SelectedIndexChanged += new System.EventHandler(this.cmbNPGiocatore_SelectedIndexChanged);
            // 
            // lblNPGiocatore
            // 
            this.lblNPGiocatore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNPGiocatore.Location = new System.Drawing.Point(11, 37);
            this.lblNPGiocatore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNPGiocatore.Name = "lblNPGiocatore";
            this.lblNPGiocatore.Size = new System.Drawing.Size(93, 25);
            this.lblNPGiocatore.TabIndex = 0;
            this.lblNPGiocatore.Text = "Giocatore";
            // 
            // grpFiltri
            // 
            this.grpFiltri.Controls.Add(this.btnTutte);
            this.grpFiltri.Controls.Add(this.btnTop10);
            this.grpFiltri.Controls.Add(this.btnFiltra);
            this.grpFiltri.Controls.Add(this.cmbFiltGioco);
            this.grpFiltri.Controls.Add(this.lblFiltGioco);
            this.grpFiltri.Controls.Add(this.cmbFiltGiocatore);
            this.grpFiltri.Controls.Add(this.lblFiltGioc);
            this.grpFiltri.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpFiltri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpFiltri.Location = new System.Drawing.Point(0, 0);
            this.grpFiltri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltri.Name = "grpFiltri";
            this.grpFiltri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltri.Size = new System.Drawing.Size(707, 228);
            this.grpFiltri.TabIndex = 0;
            this.grpFiltri.TabStop = false;
            this.grpFiltri.Text = "Filtri";
            // 
            // btnTutte
            // 
            this.btnTutte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTutte.Location = new System.Drawing.Point(421, 130);
            this.btnTutte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTutte.Name = "btnTutte";
            this.btnTutte.Size = new System.Drawing.Size(197, 37);
            this.btnTutte.TabIndex = 6;
            this.btnTutte.Text = "Tutte";
            this.btnTutte.Click += new System.EventHandler(this.btnTutte_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTop10.Location = new System.Drawing.Point(216, 130);
            this.btnTop10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(197, 37);
            this.btnTop10.TabIndex = 5;
            this.btnTop10.Text = "Top 10 Punteggi";
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnFiltra
            // 
            this.btnFiltra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltra.Location = new System.Drawing.Point(11, 130);
            this.btnFiltra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(197, 37);
            this.btnFiltra.TabIndex = 4;
            this.btnFiltra.Text = "Applica Filtri";
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // cmbFiltGioco
            // 
            this.cmbFiltGioco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltGioco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltGioco.Location = new System.Drawing.Point(112, 74);
            this.cmbFiltGioco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltGioco.Name = "cmbFiltGioco";
            this.cmbFiltGioco.Size = new System.Drawing.Size(265, 31);
            this.cmbFiltGioco.TabIndex = 3;
            // 
            // lblFiltGioco
            // 
            this.lblFiltGioco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFiltGioco.Location = new System.Drawing.Point(11, 76);
            this.lblFiltGioco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltGioco.Name = "lblFiltGioco";
            this.lblFiltGioco.Size = new System.Drawing.Size(93, 25);
            this.lblFiltGioco.TabIndex = 2;
            this.lblFiltGioco.Text = "Gioco";
            // 
            // cmbFiltGiocatore
            // 
            this.cmbFiltGiocatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltGiocatore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltGiocatore.Location = new System.Drawing.Point(112, 34);
            this.cmbFiltGiocatore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltGiocatore.Name = "cmbFiltGiocatore";
            this.cmbFiltGiocatore.Size = new System.Drawing.Size(265, 31);
            this.cmbFiltGiocatore.TabIndex = 1;
            // 
            // lblFiltGioc
            // 
            this.lblFiltGioc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFiltGioc.Location = new System.Drawing.Point(11, 37);
            this.lblFiltGioc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltGioc.Name = "lblFiltGioc";
            this.lblFiltGioc.Size = new System.Drawing.Size(93, 25);
            this.lblFiltGioc.TabIndex = 0;
            this.lblFiltGioc.Text = "Giocatore";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvPartite);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 290);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnlGrid.Size = new System.Drawing.Size(1416, 473);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvPartite
            // 
            this.dgvPartite.AllowUserToAddRows = false;
            this.dgvPartite.AllowUserToDeleteRows = false;
            this.dgvPartite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPartite.ColumnHeadersHeight = 29;
            this.dgvPartite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartite.Location = new System.Drawing.Point(8, 7);
            this.dgvPartite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPartite.Name = "dgvPartite";
            this.dgvPartite.ReadOnly = true;
            this.dgvPartite.RowHeadersWidth = 51;
            this.dgvPartite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartite.Size = new System.Drawing.Size(1400, 459);
            this.dgvPartite.TabIndex = 0;
            // 
            // FrmPartite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 763);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1434, 801);
            this.Name = "FrmPartite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storico Partite";
            this.Load += new System.EventHandler(this.FrmPartite_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.grpNuovaPartita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNPPunteggio)).EndInit();
            this.grpFiltri.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.GroupBox grpFiltri;
        private System.Windows.Forms.Label lblFiltGioc;
        private System.Windows.Forms.ComboBox cmbFiltGiocatore;
        private System.Windows.Forms.Label lblFiltGioco;
        private System.Windows.Forms.ComboBox cmbFiltGioco;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnTutte;
        private System.Windows.Forms.GroupBox grpNuovaPartita;
        private System.Windows.Forms.Label lblNPGiocatore;
        private System.Windows.Forms.ComboBox cmbNPGiocatore;
        private System.Windows.Forms.Label lblNPGioco;
        private System.Windows.Forms.ComboBox cmbNPGioco;
        private System.Windows.Forms.Label lblNPData;
        private System.Windows.Forms.DateTimePicker dtpNPData;
        private System.Windows.Forms.Label lblNPPunteggio;
        private System.Windows.Forms.NumericUpDown numNPPunteggio;
        private System.Windows.Forms.Button btnSalvaPartita;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvPartite;
    }
}