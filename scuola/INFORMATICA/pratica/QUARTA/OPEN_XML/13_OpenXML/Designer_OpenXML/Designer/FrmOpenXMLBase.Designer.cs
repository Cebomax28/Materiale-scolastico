
    partial class FrmOpenXMLBase
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
            this.gbImmagine = new System.Windows.Forms.GroupBox();
            this.btnAddImmagine = new System.Windows.Forms.Button();
            this.btnImgPath = new System.Windows.Forms.Button();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddParagrafo = new System.Windows.Forms.Button();
            this.txtParText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTabella = new System.Windows.Forms.Button();
            this.nudColonne = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRighe = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApriFile = new System.Windows.Forms.Button();
            this.gbTitolo = new System.Windows.Forms.GroupBox();
            this.btnAddTitolo = new System.Windows.Forms.Button();
            this.btnAddPie = new System.Windows.Forms.Button();
            this.btnAddIntestazione = new System.Windows.Forms.Button();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtPie = new System.Windows.Forms.TextBox();
            this.txtIntestazione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreaFile = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gbImmagine.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRighe)).BeginInit();
            this.gbTitolo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // ── FORM ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 540);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOpenXMLBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenXML Editor";
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.Load += new System.EventHandler(this.FrmOpenXMLBase_Load);

            // ── groupBox1: Destinazione File ────────────────────────────
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Size = new System.Drawing.Size(484, 124);
            this.groupBox1.Text = "  📁  Destinazione File Word";
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);

            this.txtPath.Location = new System.Drawing.Point(9, 24);
            this.txtPath.Size = new System.Drawing.Size(424, 22);
            this.txtPath.ReadOnly = true;
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtPath.TabIndex = 0;

            this.btnSelectPath.Location = new System.Drawing.Point(440, 23);
            this.btnSelectPath.Size = new System.Drawing.Size(36, 24);
            this.btnSelectPath.Text = "···";
            this.btnSelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.btnSelectPath.ForeColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.btnSelectPath.BackColor = System.Drawing.Color.White;
            this.btnSelectPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSelectPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);

            this.label1.Text = "Nome file:";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 2;

            this.txtName.Location = new System.Drawing.Point(74, 55);
            this.txtName.Size = new System.Drawing.Size(286, 22);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);

            this.btnCreaFile.Location = new System.Drawing.Point(368, 53);
            this.btnCreaFile.Size = new System.Drawing.Size(108, 26);
            this.btnCreaFile.Text = "✦  CREA";
            this.btnCreaFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaFile.FlatAppearance.BorderSize = 0;
            this.btnCreaFile.BackColor = System.Drawing.Color.FromArgb(67, 97, 238);
            this.btnCreaFile.ForeColor = System.Drawing.Color.White;
            this.btnCreaFile.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnCreaFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreaFile.TabIndex = 4;
            this.btnCreaFile.Click += new System.EventHandler(this.btnCreaFile_Click);

            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnSelectPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnCreaFile);
            this.Controls.Add(this.groupBox1);

            // ── gbTitolo: Setting Base ───────────────────────────────────
            this.gbTitolo.Location = new System.Drawing.Point(13, 140);
            this.gbTitolo.Size = new System.Drawing.Size(484, 130);
            this.gbTitolo.Text = "  ⚙  Setting Base";
            this.gbTitolo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.gbTitolo.ForeColor = System.Drawing.Color.FromArgb(56, 193, 152);
            this.gbTitolo.BackColor = System.Drawing.Color.White;
            this.gbTitolo.TabIndex = 8;
            this.gbTitolo.TabStop = false;

            this.label2.Text = "Intestazione:";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 0;

            this.txtIntestazione.Location = new System.Drawing.Point(88, 25);
            this.txtIntestazione.Size = new System.Drawing.Size(240, 22);
            this.txtIntestazione.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtIntestazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIntestazione.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtIntestazione.TabIndex = 3;

            this.btnAddIntestazione.Location = new System.Drawing.Point(336, 23);
            this.btnAddIntestazione.Size = new System.Drawing.Size(140, 26);
            this.btnAddIntestazione.Text = "+ INSERISCI";
            this.btnAddIntestazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIntestazione.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 193, 152);
            this.btnAddIntestazione.ForeColor = System.Drawing.Color.FromArgb(30, 140, 100);
            this.btnAddIntestazione.BackColor = System.Drawing.Color.FromArgb(236, 252, 245);
            this.btnAddIntestazione.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAddIntestazione.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIntestazione.TabIndex = 5;
            this.btnAddIntestazione.Click += new System.EventHandler(this.btnAddIntestazione_Click);

            this.label3.Text = "Piè:";
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 1;

            this.txtPie.Location = new System.Drawing.Point(88, 57);
            this.txtPie.Size = new System.Drawing.Size(240, 22);
            this.txtPie.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPie.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtPie.TabIndex = 4;

            this.btnAddPie.Location = new System.Drawing.Point(336, 55);
            this.btnAddPie.Size = new System.Drawing.Size(140, 26);
            this.btnAddPie.Text = "+ INSERISCI";
            this.btnAddPie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 193, 152);
            this.btnAddPie.ForeColor = System.Drawing.Color.FromArgb(30, 140, 100);
            this.btnAddPie.BackColor = System.Drawing.Color.FromArgb(236, 252, 245);
            this.btnAddPie.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAddPie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPie.TabIndex = 6;
            this.btnAddPie.Click += new System.EventHandler(this.btnAddPie_Click);

            this.label4.Text = "Titolo:";
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 2;

            this.txtTitolo.Location = new System.Drawing.Point(88, 89);
            this.txtTitolo.Size = new System.Drawing.Size(240, 22);
            this.txtTitolo.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtTitolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitolo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtTitolo.TabIndex = 5;

            this.btnAddTitolo.Location = new System.Drawing.Point(336, 87);
            this.btnAddTitolo.Size = new System.Drawing.Size(140, 26);
            this.btnAddTitolo.Text = "+ INSERISCI";
            this.btnAddTitolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTitolo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(56, 193, 152);
            this.btnAddTitolo.ForeColor = System.Drawing.Color.FromArgb(30, 140, 100);
            this.btnAddTitolo.BackColor = System.Drawing.Color.FromArgb(236, 252, 245);
            this.btnAddTitolo.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAddTitolo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTitolo.TabIndex = 7;
            this.btnAddTitolo.Click += new System.EventHandler(this.btnAddTitolo_Click);

            this.gbTitolo.Controls.Add(this.label2);
            this.gbTitolo.Controls.Add(this.txtIntestazione);
            this.gbTitolo.Controls.Add(this.btnAddIntestazione);
            this.gbTitolo.Controls.Add(this.label3);
            this.gbTitolo.Controls.Add(this.txtPie);
            this.gbTitolo.Controls.Add(this.btnAddPie);
            this.gbTitolo.Controls.Add(this.label4);
            this.gbTitolo.Controls.Add(this.txtTitolo);
            this.gbTitolo.Controls.Add(this.btnAddTitolo);
            this.Controls.Add(this.gbTitolo);

            // ── groupBox3: Paragrafo ─────────────────────────────────────
            this.groupBox3.Location = new System.Drawing.Point(13, 278);
            this.groupBox3.Size = new System.Drawing.Size(484, 94);
            this.groupBox3.Text = "  ¶  Paragrafo";
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(245, 124, 0);
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;

            this.txtParText.Location = new System.Drawing.Point(9, 20);
            this.txtParText.Size = new System.Drawing.Size(394, 62);
            this.txtParText.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtParText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtParText.TabIndex = 0;

            this.btnAddParagrafo.Location = new System.Drawing.Point(411, 20);
            this.btnAddParagrafo.Size = new System.Drawing.Size(65, 62);
            this.btnAddParagrafo.Text = "+";
            this.btnAddParagrafo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParagrafo.FlatAppearance.BorderSize = 0;
            this.btnAddParagrafo.BackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            this.btnAddParagrafo.ForeColor = System.Drawing.Color.White;
            this.btnAddParagrafo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnAddParagrafo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddParagrafo.TabIndex = 9;
            this.btnAddParagrafo.Click += new System.EventHandler(this.btnAddParagrafo_Click);

            this.groupBox3.Controls.Add(this.txtParText);
            this.groupBox3.Controls.Add(this.btnAddParagrafo);
            this.Controls.Add(this.groupBox3);

            // ── groupBox2: Tabella ───────────────────────────────────────
            this.groupBox2.Location = new System.Drawing.Point(13, 380);
            this.groupBox2.Size = new System.Drawing.Size(484, 60);
            this.groupBox2.Text = "  ⊞  Tabella";
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(111, 45, 189);
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;

            this.label5.Text = "Righe:";
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 1;

            this.nudRighe.Location = new System.Drawing.Point(52, 21);
            this.nudRighe.Size = new System.Drawing.Size(58, 22);
            this.nudRighe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRighe.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudRighe.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRighe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudRighe.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.nudRighe.TabIndex = 2;

            this.label6.Text = "Colonne:";
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(100, 110, 150);
            this.label6.Location = new System.Drawing.Point(120, 24);
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 3;

            this.nudColonne.Location = new System.Drawing.Point(175, 21);
            this.nudColonne.Size = new System.Drawing.Size(58, 22);
            this.nudColonne.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudColonne.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudColonne.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudColonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudColonne.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.nudColonne.TabIndex = 4;

            this.btnAddTabella.Location = new System.Drawing.Point(336, 19);
            this.btnAddTabella.Size = new System.Drawing.Size(140, 26);
            this.btnAddTabella.Text = "+ INSERISCI";
            this.btnAddTabella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTabella.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(111, 45, 189);
            this.btnAddTabella.ForeColor = System.Drawing.Color.FromArgb(111, 45, 189);
            this.btnAddTabella.BackColor = System.Drawing.Color.FromArgb(245, 240, 255);
            this.btnAddTabella.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAddTabella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTabella.TabIndex = 8;
            this.btnAddTabella.Click += new System.EventHandler(this.btnAddTabella_Click);

            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudRighe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudColonne);
            this.groupBox2.Controls.Add(this.btnAddTabella);
            this.Controls.Add(this.groupBox2);

            // ── gbImmagine ───────────────────────────────────────────────
            this.gbImmagine.Location = new System.Drawing.Point(13, 448);
            this.gbImmagine.Size = new System.Drawing.Size(484, 82);
            this.gbImmagine.Text = "  🖼  Immagine";
            this.gbImmagine.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.gbImmagine.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.gbImmagine.BackColor = System.Drawing.Color.White;
            this.gbImmagine.TabIndex = 11;
            this.gbImmagine.TabStop = false;

            this.txtImgPath.Location = new System.Drawing.Point(9, 24);
            this.txtImgPath.Size = new System.Drawing.Size(388, 22);
            this.txtImgPath.ReadOnly = true;
            this.txtImgPath.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.txtImgPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImgPath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtImgPath.TabIndex = 2;

            this.btnImgPath.Location = new System.Drawing.Point(404, 23);
            this.btnImgPath.Size = new System.Drawing.Size(72, 24);
            this.btnImgPath.Text = "Sfoglia";
            this.btnImgPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnImgPath.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnImgPath.BackColor = System.Drawing.Color.FromArgb(255, 241, 242);
            this.btnImgPath.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnImgPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgPath.TabIndex = 3;
            this.btnImgPath.Click += new System.EventHandler(this.btnImgPath_Click);

            this.btnAddImmagine.Location = new System.Drawing.Point(336, 52);
            this.btnAddImmagine.Size = new System.Drawing.Size(140, 24);
            this.btnAddImmagine.Text = "+ INSERISCI";
            this.btnAddImmagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImmagine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnAddImmagine.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnAddImmagine.BackColor = System.Drawing.Color.FromArgb(255, 241, 242);
            this.btnAddImmagine.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAddImmagine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImmagine.TabIndex = 9;
            this.btnAddImmagine.Click += new System.EventHandler(this.btnAddImmagine_Click);

            this.gbImmagine.Controls.Add(this.txtImgPath);
            this.gbImmagine.Controls.Add(this.btnImgPath);
            this.gbImmagine.Controls.Add(this.btnAddImmagine);
            this.Controls.Add(this.gbImmagine);

            // ── btnApriFile ──────────────────────────────────────────────
            this.btnApriFile.Location = new System.Drawing.Point(13, 538);
            this.btnApriFile.Size = new System.Drawing.Size(484, 38);
            this.btnApriFile.Text = "▶   APRI FILE";
            this.btnApriFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApriFile.FlatAppearance.BorderSize = 0;
            this.btnApriFile.BackColor = System.Drawing.Color.FromArgb(22, 33, 74);
            this.btnApriFile.ForeColor = System.Drawing.Color.White;
            this.btnApriFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnApriFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApriFile.TabIndex = 12;
            this.btnApriFile.Click += new System.EventHandler(this.btnApriFile_Click);
            this.Controls.Add(this.btnApriFile);

            this.gbImmagine.ResumeLayout(false);
            this.gbImmagine.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRighe)).EndInit();
            this.gbTitolo.ResumeLayout(false);
            this.gbTitolo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbImmagine;
        private System.Windows.Forms.Button btnAddImmagine;
        private System.Windows.Forms.Button btnImgPath;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddParagrafo;
        private System.Windows.Forms.RichTextBox txtParText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTabella;
        private System.Windows.Forms.NumericUpDown nudColonne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRighe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApriFile;
        private System.Windows.Forms.GroupBox gbTitolo;
        private System.Windows.Forms.Button btnAddTitolo;
        private System.Windows.Forms.Button btnAddPie;
        private System.Windows.Forms.Button btnAddIntestazione;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtPie;
        private System.Windows.Forms.TextBox txtIntestazione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreaFile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
    }