namespace _14_VideogiochiSQLServer.Views
{
    partial class FrmGiochi
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
            this.grpRicerca = new System.Windows.Forms.GroupBox();
            this.btnResetFiltro = new System.Windows.Forms.Button();
            this.btnCercaGiochi = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.txtGiocoNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpGriglia = new System.Windows.Forms.GroupBox();
            this.dgvGiochi = new System.Windows.Forms.DataGridView();
            this.grpNuovoGioco = new System.Windows.Forms.GroupBox();
            this.btnAddGioco = new System.Windows.Forms.Button();
            this.numAnno = new System.Windows.Forms.NumericUpDown();
            this.lblAnno = new System.Windows.Forms.Label();
            this.txtNewCasa = new System.Windows.Forms.TextBox();
            this.lblCasa = new System.Windows.Forms.Label();
            this.txtNewCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNewTitolo = new System.Windows.Forms.TextBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.grpRicerca.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpGriglia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiochi)).BeginInit();
            this.grpNuovoGioco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnno)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1336, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1336, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Catalogo Giochi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRicerca
            // 
            this.grpRicerca.Controls.Add(this.btnResetFiltro);
            this.grpRicerca.Controls.Add(this.btnCercaGiochi);
            this.grpRicerca.Controls.Add(this.cmbCategoria);
            this.grpRicerca.Controls.Add(this.lblCat);
            this.grpRicerca.Controls.Add(this.txtGiocoNome);
            this.grpRicerca.Controls.Add(this.lblNome);
            this.grpRicerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRicerca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRicerca.Location = new System.Drawing.Point(0, 62);
            this.grpRicerca.Margin = new System.Windows.Forms.Padding(4);
            this.grpRicerca.Name = "grpRicerca";
            this.grpRicerca.Padding = new System.Windows.Forms.Padding(4);
            this.grpRicerca.Size = new System.Drawing.Size(1336, 79);
            this.grpRicerca.TabIndex = 1;
            this.grpRicerca.TabStop = false;
            this.grpRicerca.Text = "Filtri Ricerca";
            // 
            // btnResetFiltro
            // 
            this.btnResetFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetFiltro.Location = new System.Drawing.Point(941, 30);
            this.btnResetFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetFiltro.Name = "btnResetFiltro";
            this.btnResetFiltro.Size = new System.Drawing.Size(160, 34);
            this.btnResetFiltro.TabIndex = 5;
            this.btnResetFiltro.Text = "Tutti";
            this.btnResetFiltro.Click += new System.EventHandler(this.btnResetFiltro_Click);
            // 
            // btnCercaGiochi
            // 
            this.btnCercaGiochi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCercaGiochi.Location = new System.Drawing.Point(771, 30);
            this.btnCercaGiochi.Margin = new System.Windows.Forms.Padding(4);
            this.btnCercaGiochi.Name = "btnCercaGiochi";
            this.btnCercaGiochi.Size = new System.Drawing.Size(160, 34);
            this.btnCercaGiochi.TabIndex = 4;
            this.btnCercaGiochi.Text = "Cerca";
            this.btnCercaGiochi.Click += new System.EventHandler(this.btnCercaGiochi_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.Location = new System.Drawing.Point(509, 32);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(239, 31);
            this.cmbCategoria.TabIndex = 3;
            // 
            // lblCat
            // 
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCat.Location = new System.Drawing.Point(421, 34);
            this.lblCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(80, 25);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Categoria";
            // 
            // txtGiocoNome
            // 
            this.txtGiocoNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiocoNome.Location = new System.Drawing.Point(80, 32);
            this.txtGiocoNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiocoNome.Name = "txtGiocoNome";
            this.txtGiocoNome.Size = new System.Drawing.Size(319, 30);
            this.txtGiocoNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNome.Location = new System.Drawing.Point(11, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Titolo";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpGriglia);
            this.pnlContent.Controls.Add(this.grpNuovoGioco);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 141);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1336, 573);
            this.pnlContent.TabIndex = 2;
            // 
            // grpGriglia
            // 
            this.grpGriglia.Controls.Add(this.dgvGiochi);
            this.grpGriglia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGriglia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGriglia.Location = new System.Drawing.Point(0, 0);
            this.grpGriglia.Margin = new System.Windows.Forms.Padding(4);
            this.grpGriglia.Name = "grpGriglia";
            this.grpGriglia.Padding = new System.Windows.Forms.Padding(4);
            this.grpGriglia.Size = new System.Drawing.Size(949, 573);
            this.grpGriglia.TabIndex = 0;
            this.grpGriglia.TabStop = false;
            this.grpGriglia.Text = "Catalogo";
            // 
            // dgvGiochi
            // 
            this.dgvGiochi.AllowUserToAddRows = false;
            this.dgvGiochi.AllowUserToDeleteRows = false;
            this.dgvGiochi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiochi.ColumnHeadersHeight = 29;
            this.dgvGiochi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiochi.Location = new System.Drawing.Point(4, 27);
            this.dgvGiochi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiochi.Name = "dgvGiochi";
            this.dgvGiochi.ReadOnly = true;
            this.dgvGiochi.RowHeadersWidth = 51;
            this.dgvGiochi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiochi.Size = new System.Drawing.Size(941, 542);
            this.dgvGiochi.TabIndex = 0;
            // 
            // grpNuovoGioco
            // 
            this.grpNuovoGioco.Controls.Add(this.btnAddGioco);
            this.grpNuovoGioco.Controls.Add(this.numAnno);
            this.grpNuovoGioco.Controls.Add(this.lblAnno);
            this.grpNuovoGioco.Controls.Add(this.txtNewCasa);
            this.grpNuovoGioco.Controls.Add(this.lblCasa);
            this.grpNuovoGioco.Controls.Add(this.txtNewCategoria);
            this.grpNuovoGioco.Controls.Add(this.lblCategoria);
            this.grpNuovoGioco.Controls.Add(this.txtNewTitolo);
            this.grpNuovoGioco.Controls.Add(this.lblTitolo);
            this.grpNuovoGioco.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpNuovoGioco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNuovoGioco.Location = new System.Drawing.Point(949, 0);
            this.grpNuovoGioco.Margin = new System.Windows.Forms.Padding(4);
            this.grpNuovoGioco.Name = "grpNuovoGioco";
            this.grpNuovoGioco.Padding = new System.Windows.Forms.Padding(4);
            this.grpNuovoGioco.Size = new System.Drawing.Size(387, 573);
            this.grpNuovoGioco.TabIndex = 1;
            this.grpNuovoGioco.TabStop = false;
            this.grpNuovoGioco.Text = "Nuovo Gioco";
            // 
            // btnAddGioco
            // 
            this.btnAddGioco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddGioco.Location = new System.Drawing.Point(11, 199);
            this.btnAddGioco.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGioco.Name = "btnAddGioco";
            this.btnAddGioco.Size = new System.Drawing.Size(360, 37);
            this.btnAddGioco.TabIndex = 8;
            this.btnAddGioco.Text = "Salva Gioco";
            this.btnAddGioco.Click += new System.EventHandler(this.btnAddGioco_Click);
            // 
            // numAnno
            // 
            this.numAnno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numAnno.Location = new System.Drawing.Point(99, 145);
            this.numAnno.Margin = new System.Windows.Forms.Padding(4);
            this.numAnno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnno.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAnno.Name = "numAnno";
            this.numAnno.Size = new System.Drawing.Size(133, 30);
            this.numAnno.TabIndex = 7;
            this.numAnno.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // lblAnno
            // 
            this.lblAnno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAnno.Location = new System.Drawing.Point(11, 148);
            this.lblAnno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(80, 25);
            this.lblAnno.TabIndex = 6;
            this.lblAnno.Text = "Anno";
            // 
            // txtNewCasa
            // 
            this.txtNewCasa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewCasa.Location = new System.Drawing.Point(99, 108);
            this.txtNewCasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewCasa.Name = "txtNewCasa";
            this.txtNewCasa.Size = new System.Drawing.Size(271, 30);
            this.txtNewCasa.TabIndex = 5;
            // 
            // lblCasa
            // 
            this.lblCasa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCasa.Location = new System.Drawing.Point(11, 111);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(80, 25);
            this.lblCasa.TabIndex = 4;
            this.lblCasa.Text = "Casa Prod.";
            // 
            // txtNewCategoria
            // 
            this.txtNewCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewCategoria.Location = new System.Drawing.Point(99, 71);
            this.txtNewCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewCategoria.Name = "txtNewCategoria";
            this.txtNewCategoria.Size = new System.Drawing.Size(271, 30);
            this.txtNewCategoria.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoria.Location = new System.Drawing.Point(11, 74);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 25);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNewTitolo
            // 
            this.txtNewTitolo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewTitolo.Location = new System.Drawing.Point(99, 34);
            this.txtNewTitolo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewTitolo.Name = "txtNewTitolo";
            this.txtNewTitolo.Size = new System.Drawing.Size(271, 30);
            this.txtNewTitolo.TabIndex = 1;
            // 
            // lblTitolo
            // 
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitolo.Location = new System.Drawing.Point(11, 37);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(80, 25);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Titolo";
            // 
            // FrmGiochi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 714);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.grpRicerca);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1354, 752);
            this.Name = "FrmGiochi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Giochi";
            this.Load += new System.EventHandler(this.FrmGiochi_Load);
            this.pnlTop.ResumeLayout(false);
            this.grpRicerca.ResumeLayout(false);
            this.grpRicerca.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.grpGriglia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiochi)).EndInit();
            this.grpNuovoGioco.ResumeLayout(false);
            this.grpNuovoGioco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnno)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpRicerca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtGiocoNome;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnCercaGiochi;
        private System.Windows.Forms.Button btnResetFiltro;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpGriglia;
        private System.Windows.Forms.DataGridView dgvGiochi;
        private System.Windows.Forms.GroupBox grpNuovoGioco;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtNewTitolo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNewCategoria;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.TextBox txtNewCasa;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.NumericUpDown numAnno;
        private System.Windows.Forms.Button btnAddGioco;
    }
}