
    partial class FrmOpenXMLSegnalibri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCreaPagelle = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIndirizzoR = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCittaR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDataN = new System.Windows.Forms.DateTimePicker();
            this.btnAddStudente = new System.Windows.Forms.Button();
            this.txtCittaN = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCogn = new System.Windows.Forms.TextBox();
            this.txtMatr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminaAlunni = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();

            // ── groupBox4 (contenitore principale) ──────────────────────
            this.groupBox4.Controls.Add(this.btnEliminaAlunni);
            this.groupBox4.Controls.Add(this.btnCreaPagelle);
            this.groupBox4.Controls.Add(this.dgv);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 484);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestione Segnalibri";
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);

            // ── btnCreaPagelle ───────────────────────────────────────────
            this.btnCreaPagelle.Location = new System.Drawing.Point(612, 446);
            this.btnCreaPagelle.Name = "btnCreaPagelle";
            this.btnCreaPagelle.Size = new System.Drawing.Size(130, 32);
            this.btnCreaPagelle.TabIndex = 9;
            this.btnCreaPagelle.Text = "▶  Crea Pagelle";
            this.btnCreaPagelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreaPagelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreaPagelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaPagelle.FlatAppearance.BorderSize = 0;
            this.btnCreaPagelle.BackColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.btnCreaPagelle.ForeColor = System.Drawing.Color.White;
            this.btnCreaPagelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCreaPagelle.UseVisualStyleBackColor = false;
            this.btnCreaPagelle.Click += new System.EventHandler(this.btnCreaPagelle_Click);

            // ── dgv ──────────────────────────────────────────────────────
            this.dgv.Location = new System.Drawing.Point(6, 242);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(736, 198);
            this.dgv.TabIndex = 1;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(243, 244, 248);
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 50, 80);
            this.dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 220, 255);
            this.dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 248);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(220, 224, 235);
            this.dgv.RowHeadersVisible = false;
            this.dgv.EnableHeadersVisualStyles = false;

            // ── groupBox5 (Nuovo Studente) ───────────────────────────────
            this.groupBox5.Controls.Add(this.cmbClasse);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtIndirizzoR);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtCittaR);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.dtpDataN);
            this.groupBox5.Controls.Add(this.btnAddStudente);
            this.groupBox5.Controls.Add(this.txtCittaN);
            this.groupBox5.Controls.Add(this.txtNome);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtCogn);
            this.groupBox5.Controls.Add(this.txtMatr);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(6, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(736, 211);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nuovo Studente";
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);

            // ── cmbClasse ────────────────────────────────────────────────
            this.cmbClasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.ItemHeight = 13;
            this.cmbClasse.Location = new System.Drawing.Point(90, 171);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(60, 21);
            this.cmbClasse.TabIndex = 7;
            this.cmbClasse.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cmbClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClasse.BackColor = System.Drawing.Color.White;
            this.cmbClasse.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);

            // ── label14 ──────────────────────────────────────────────────
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Classe:";
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── txtIndirizzoR ────────────────────────────────────────────
            this.txtIndirizzoR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndirizzoR.Location = new System.Drawing.Point(388, 136);
            this.txtIndirizzoR.Name = "txtIndirizzoR";
            this.txtIndirizzoR.Size = new System.Drawing.Size(159, 22);
            this.txtIndirizzoR.TabIndex = 6;
            this.txtIndirizzoR.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtIndirizzoR.BackColor = System.Drawing.Color.White;
            this.txtIndirizzoR.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.txtIndirizzoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── label13 ──────────────────────────────────────────────────
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Indirizzo [Via, Civ]:";
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── txtCittaR ────────────────────────────────────────────────
            this.txtCittaR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCittaR.Location = new System.Drawing.Point(90, 135);
            this.txtCittaR.Name = "txtCittaR";
            this.txtCittaR.Size = new System.Drawing.Size(166, 22);
            this.txtCittaR.TabIndex = 5;
            this.txtCittaR.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtCittaR.BackColor = System.Drawing.Color.White;
            this.txtCittaR.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.txtCittaR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── label12 ──────────────────────────────────────────────────
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Residente a:";
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── label11 ──────────────────────────────────────────────────
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "a:";
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── dtpDataN ─────────────────────────────────────────────────
            this.dtpDataN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataN.Location = new System.Drawing.Point(90, 95);
            this.dtpDataN.Name = "dtpDataN";
            this.dtpDataN.Size = new System.Drawing.Size(166, 22);
            this.dtpDataN.TabIndex = 3;
            this.dtpDataN.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dtpDataN.CalendarForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.dtpDataN.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDataN.CalendarTitleBackColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.dtpDataN.CalendarTitleForeColor = System.Drawing.Color.White;

            // ── btnAddStudente ───────────────────────────────────────────
            this.btnAddStudente.Location = new System.Drawing.Point(517, 168);
            this.btnAddStudente.Name = "btnAddStudente";
            this.btnAddStudente.Size = new System.Drawing.Size(32, 32);
            this.btnAddStudente.TabIndex = 8;
            this.btnAddStudente.Text = "+";
            this.btnAddStudente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStudente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudente.FlatAppearance.BorderSize = 0;
            this.btnAddStudente.BackColor = System.Drawing.Color.FromArgb(56, 193, 152);
            this.btnAddStudente.ForeColor = System.Drawing.Color.White;
            this.btnAddStudente.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnAddStudente.UseVisualStyleBackColor = false;
            this.btnAddStudente.Click += new System.EventHandler(this.btnAddStudente_Click);

            // ── txtCittaN ────────────────────────────────────────────────
            this.txtCittaN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCittaN.Location = new System.Drawing.Point(388, 95);
            this.txtCittaN.Name = "txtCittaN";
            this.txtCittaN.Size = new System.Drawing.Size(159, 22);
            this.txtCittaN.TabIndex = 4;
            this.txtCittaN.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtCittaN.BackColor = System.Drawing.Color.White;
            this.txtCittaN.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.txtCittaN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── txtNome ──────────────────────────────────────────────────
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(388, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── label9 ───────────────────────────────────────────────────
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nata/o il:";
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── label10 ──────────────────────────────────────────────────
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nome:";
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── txtCogn ──────────────────────────────────────────────────
            this.txtCogn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCogn.Location = new System.Drawing.Point(90, 65);
            this.txtCogn.Name = "txtCogn";
            this.txtCogn.Size = new System.Drawing.Size(166, 22);
            this.txtCogn.TabIndex = 1;
            this.txtCogn.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtCogn.BackColor = System.Drawing.Color.White;
            this.txtCogn.ForeColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.txtCogn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── txtMatr ──────────────────────────────────────────────────
            this.txtMatr.Location = new System.Drawing.Point(90, 34);
            this.txtMatr.Name = "txtMatr";
            this.txtMatr.ReadOnly = true;
            this.txtMatr.Size = new System.Drawing.Size(166, 22);
            this.txtMatr.TabIndex = 0;
            this.txtMatr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMatr.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtMatr.BackColor = System.Drawing.Color.FromArgb(235, 237, 245);
            this.txtMatr.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.txtMatr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ── label8 ───────────────────────────────────────────────────
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cognome:";
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── label7 ───────────────────────────────────────────────────
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Matricola:";
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);

            // ── btnEliminaAlunni ─────────────────────────────────────────
            this.btnEliminaAlunni.Location = new System.Drawing.Point(6, 446);
            this.btnEliminaAlunni.Name = "btnEliminaAlunni";
            this.btnEliminaAlunni.Size = new System.Drawing.Size(150, 32);
            this.btnEliminaAlunni.TabIndex = 10;
            this.btnEliminaAlunni.Text = "✕  Elimina Alunni";
            this.btnEliminaAlunni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminaAlunni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaAlunni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaAlunni.FlatAppearance.BorderSize = 0;
            this.btnEliminaAlunni.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnEliminaAlunni.ForeColor = System.Drawing.Color.White;
            this.btnEliminaAlunni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnEliminaAlunni.UseVisualStyleBackColor = false;
            this.btnEliminaAlunni.Click += new System.EventHandler(this.btnEliminaAlunni_Click);

            // ── FrmOpenXMLSegnalibri ─────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 508);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmOpenXMLSegnalibri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenXML: Bookmarks";
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.Load += new System.EventHandler(this.FrmOpenXMLSegnalibri_Load);

            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIndirizzoR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCittaR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDataN;
        private System.Windows.Forms.Button btnAddStudente;
        private System.Windows.Forms.TextBox txtCittaN;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCogn;
        private System.Windows.Forms.TextBox txtMatr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreaPagelle;
        private System.Windows.Forms.Button btnEliminaAlunni;
    }