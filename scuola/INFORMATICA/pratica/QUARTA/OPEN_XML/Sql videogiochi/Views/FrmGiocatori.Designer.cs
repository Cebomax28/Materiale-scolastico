namespace _14_VideogiochiSQLServer.Views
{
    partial class FrmGiocatori
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpModifica = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.lblEmailUpd = new System.Windows.Forms.Label();
            this.txtUpdNickname = new System.Windows.Forms.TextBox();
            this.lblNickUpd = new System.Windows.Forms.Label();
            this.grpNuovo = new System.Windows.Forms.GroupBox();
            this.btnAddGiocatore = new System.Windows.Forms.Button();
            this.dtpAddDataN = new System.Windows.Forms.DateTimePicker();
            this.lblDataN = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtAddCogn = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvGiocatori = new System.Windows.Forms.DataGridView();
            this.btnCercaNick = new System.Windows.Forms.Button();
            this.txtCercaNick = new System.Windows.Forms.TextBox();
            this.lblElenco = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.grpModifica.SuspendLayout();
            this.grpNuovo.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiocatori)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grpModifica);
            this.pnlLeft.Controls.Add(this.grpNuovo);
            this.pnlLeft.Controls.Add(this.lblPanelTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(340, 581);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpModifica
            // 
            this.grpModifica.Controls.Add(this.btnDelete);
            this.grpModifica.Controls.Add(this.btnUpdate);
            this.grpModifica.Controls.Add(this.txtUpdEmail);
            this.grpModifica.Controls.Add(this.lblEmailUpd);
            this.grpModifica.Controls.Add(this.txtUpdNickname);
            this.grpModifica.Controls.Add(this.lblNickUpd);
            this.grpModifica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpModifica.Location = new System.Drawing.Point(8, 320);
            this.grpModifica.Name = "grpModifica";
            this.grpModifica.Size = new System.Drawing.Size(322, 140);
            this.grpModifica.TabIndex = 2;
            this.grpModifica.TabStop = false;
            this.grpModifica.Text = "Modifica / Elimina selezionato";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(162, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(8, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Aggiorna";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUpdEmail.Location = new System.Drawing.Point(86, 56);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(224, 25);
            this.txtUpdEmail.TabIndex = 3;
            // 
            // lblEmailUpd
            // 
            this.lblEmailUpd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailUpd.Location = new System.Drawing.Point(8, 58);
            this.lblEmailUpd.Name = "lblEmailUpd";
            this.lblEmailUpd.Size = new System.Drawing.Size(72, 20);
            this.lblEmailUpd.TabIndex = 2;
            this.lblEmailUpd.Text = "Email";
            // 
            // txtUpdNickname
            // 
            this.txtUpdNickname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUpdNickname.Location = new System.Drawing.Point(86, 26);
            this.txtUpdNickname.Name = "txtUpdNickname";
            this.txtUpdNickname.Size = new System.Drawing.Size(224, 25);
            this.txtUpdNickname.TabIndex = 1;
            // 
            // lblNickUpd
            // 
            this.lblNickUpd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNickUpd.Location = new System.Drawing.Point(8, 28);
            this.lblNickUpd.Name = "lblNickUpd";
            this.lblNickUpd.Size = new System.Drawing.Size(72, 20);
            this.lblNickUpd.TabIndex = 0;
            this.lblNickUpd.Text = "Nickname";
            // 
            // grpNuovo
            // 
            this.grpNuovo.Controls.Add(this.btnAddGiocatore);
            this.grpNuovo.Controls.Add(this.dtpAddDataN);
            this.grpNuovo.Controls.Add(this.lblDataN);
            this.grpNuovo.Controls.Add(this.txtAddEmail);
            this.grpNuovo.Controls.Add(this.lblEmail);
            this.grpNuovo.Controls.Add(this.txtAddNickname);
            this.grpNuovo.Controls.Add(this.lblNickname);
            this.grpNuovo.Controls.Add(this.txtAddCogn);
            this.grpNuovo.Controls.Add(this.lblCognome);
            this.grpNuovo.Controls.Add(this.txtAddNome);
            this.grpNuovo.Controls.Add(this.lblNome);
            this.grpNuovo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNuovo.Location = new System.Drawing.Point(8, 42);
            this.grpNuovo.Name = "grpNuovo";
            this.grpNuovo.Size = new System.Drawing.Size(322, 268);
            this.grpNuovo.TabIndex = 1;
            this.grpNuovo.TabStop = false;
            this.grpNuovo.Text = "Nuovo Giocatore";
            // 
            // btnAddGiocatore
            // 
            this.btnAddGiocatore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddGiocatore.Location = new System.Drawing.Point(86, 226);
            this.btnAddGiocatore.Name = "btnAddGiocatore";
            this.btnAddGiocatore.Size = new System.Drawing.Size(224, 30);
            this.btnAddGiocatore.TabIndex = 10;
            this.btnAddGiocatore.Text = "Aggiungi Giocatore";
            this.btnAddGiocatore.Click += new System.EventHandler(this.btnAddGiocatore_Click);
            // 
            // dtpAddDataN
            // 
            this.dtpAddDataN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpAddDataN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddDataN.Location = new System.Drawing.Point(86, 146);
            this.dtpAddDataN.Name = "dtpAddDataN";
            this.dtpAddDataN.Size = new System.Drawing.Size(224, 25);
            this.dtpAddDataN.TabIndex = 9;
            // 
            // lblDataN
            // 
            this.lblDataN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDataN.Location = new System.Drawing.Point(8, 148);
            this.lblDataN.Name = "lblDataN";
            this.lblDataN.Size = new System.Drawing.Size(72, 20);
            this.lblDataN.TabIndex = 8;
            this.lblDataN.Text = "Nascita";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddEmail.Location = new System.Drawing.Point(86, 116);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(224, 25);
            this.txtAddEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(8, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtAddNickname
            // 
            this.txtAddNickname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddNickname.Location = new System.Drawing.Point(86, 86);
            this.txtAddNickname.Name = "txtAddNickname";
            this.txtAddNickname.Size = new System.Drawing.Size(224, 25);
            this.txtAddNickname.TabIndex = 5;
            // 
            // lblNickname
            // 
            this.lblNickname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNickname.Location = new System.Drawing.Point(8, 88);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(72, 20);
            this.lblNickname.TabIndex = 4;
            this.lblNickname.Text = "Nickname";
            // 
            // txtAddCogn
            // 
            this.txtAddCogn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddCogn.Location = new System.Drawing.Point(86, 56);
            this.txtAddCogn.Name = "txtAddCogn";
            this.txtAddCogn.Size = new System.Drawing.Size(224, 25);
            this.txtAddCogn.TabIndex = 3;
            // 
            // lblCognome
            // 
            this.lblCognome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCognome.Location = new System.Drawing.Point(8, 58);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(72, 20);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "Cognome";
            // 
            // txtAddNome
            // 
            this.txtAddNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddNome.Location = new System.Drawing.Point(86, 26);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(224, 25);
            this.txtAddNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNome.Location = new System.Drawing.Point(8, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(340, 36);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "Gestione Giocatori";
            this.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvGiocatori);
            this.pnlRight.Controls.Add(this.btnCercaNick);
            this.pnlRight.Controls.Add(this.txtCercaNick);
            this.pnlRight.Controls.Add(this.lblElenco);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(340, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(8);
            this.pnlRight.Size = new System.Drawing.Size(444, 581);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvGiocatori
            // 
            this.dgvGiocatori.AllowUserToAddRows = false;
            this.dgvGiocatori.AllowUserToDeleteRows = false;
            this.dgvGiocatori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiocatori.Location = new System.Drawing.Point(8, 74);
            this.dgvGiocatori.Name = "dgvGiocatori";
            this.dgvGiocatori.ReadOnly = true;
            this.dgvGiocatori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiocatori.Size = new System.Drawing.Size(428, 496);
            this.dgvGiocatori.TabIndex = 3;
            this.dgvGiocatori.SelectionChanged += new System.EventHandler(this.dgvGiocatori_SelectionChanged);
            // 
            // btnCercaNick
            // 
            this.btnCercaNick.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCercaNick.Location = new System.Drawing.Point(316, 38);
            this.btnCercaNick.Name = "btnCercaNick";
            this.btnCercaNick.Size = new System.Drawing.Size(120, 28);
            this.btnCercaNick.TabIndex = 2;
            this.btnCercaNick.Text = "Cerca";
            this.btnCercaNick.Click += new System.EventHandler(this.btnCercaNick_Click);
            // 
            // txtCercaNick
            // 
            this.txtCercaNick.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCercaNick.Location = new System.Drawing.Point(8, 40);
            this.txtCercaNick.Name = "txtCercaNick";
            this.txtCercaNick.Size = new System.Drawing.Size(300, 25);
            this.txtCercaNick.TabIndex = 1;
            // 
            // lblElenco
            // 
            this.lblElenco.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblElenco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblElenco.Location = new System.Drawing.Point(8, 8);
            this.lblElenco.Name = "lblElenco";
            this.lblElenco.Size = new System.Drawing.Size(428, 24);
            this.lblElenco.TabIndex = 0;
            this.lblElenco.Text = "Cerca per Nickname";
            // 
            // FrmGiocatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.MinimumSize = new System.Drawing.Size(800, 620);
            this.Name = "FrmGiocatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giocatori";
            this.pnlLeft.ResumeLayout(false);
            this.grpModifica.ResumeLayout(false);
            this.grpModifica.PerformLayout();
            this.grpNuovo.ResumeLayout(false);
            this.grpNuovo.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiocatori)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.GroupBox grpNuovo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtAddCogn;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txtAddNickname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblDataN;
        private System.Windows.Forms.DateTimePicker dtpAddDataN;
        private System.Windows.Forms.Button btnAddGiocatore;
        private System.Windows.Forms.GroupBox grpModifica;
        private System.Windows.Forms.Label lblNickUpd;
        private System.Windows.Forms.TextBox txtUpdNickname;
        private System.Windows.Forms.Label lblEmailUpd;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblElenco;
        private System.Windows.Forms.TextBox txtCercaNick;
        private System.Windows.Forms.Button btnCercaNick;
        private System.Windows.Forms.DataGridView dgvGiocatori;
    }
}