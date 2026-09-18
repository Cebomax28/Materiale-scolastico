namespace _13_OpenXML
{

    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnOpenXmlBase = new System.Windows.Forms.Button();
            this.btnOpenXmlSegnalibri = new System.Windows.Forms.Button();
            this.btnOpenXmlSegnalibriNoCls = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlBackground.Controls.Add(this.pnlCard);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(440, 320);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.pnlDivider);
            this.pnlCard.Controls.Add(this.btnOpenXmlBase);
            this.pnlCard.Controls.Add(this.btnOpenXmlSegnalibri);
            this.pnlCard.Controls.Add(this.btnOpenXmlSegnalibriNoCls);
            this.pnlCard.Location = new System.Drawing.Point(28, 24);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(384, 272);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚙  Open XML";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(197, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Seleziona un\'operazione da eseguire";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlDivider.Location = new System.Drawing.Point(20, 68);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(344, 1);
            this.pnlDivider.TabIndex = 2;
            // 
            // btnOpenXmlBase
            // 
            this.btnOpenXmlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnOpenXmlBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenXmlBase.FlatAppearance.BorderSize = 0;
            this.btnOpenXmlBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnOpenXmlBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnOpenXmlBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenXmlBase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenXmlBase.ForeColor = System.Drawing.Color.White;
            this.btnOpenXmlBase.Location = new System.Drawing.Point(20, 82);
            this.btnOpenXmlBase.Name = "btnOpenXmlBase";
            this.btnOpenXmlBase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOpenXmlBase.Size = new System.Drawing.Size(344, 48);
            this.btnOpenXmlBase.TabIndex = 0;
            this.btnOpenXmlBase.Text = "▶   Open XML  —  Base";
            this.btnOpenXmlBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenXmlBase.UseVisualStyleBackColor = false;
            this.btnOpenXmlBase.Click += new System.EventHandler(this.btnOpenXmlBase_Click);
            // 
            // btnOpenXmlSegnalibri
            // 
            this.btnOpenXmlSegnalibri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(163)))), ((int)(((byte)(151)))));
            this.btnOpenXmlSegnalibri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenXmlSegnalibri.FlatAppearance.BorderSize = 0;
            this.btnOpenXmlSegnalibri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnOpenXmlSegnalibri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnOpenXmlSegnalibri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenXmlSegnalibri.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenXmlSegnalibri.ForeColor = System.Drawing.Color.White;
            this.btnOpenXmlSegnalibri.Location = new System.Drawing.Point(20, 142);
            this.btnOpenXmlSegnalibri.Name = "btnOpenXmlSegnalibri";
            this.btnOpenXmlSegnalibri.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOpenXmlSegnalibri.Size = new System.Drawing.Size(344, 48);
            this.btnOpenXmlSegnalibri.TabIndex = 1;
            this.btnOpenXmlSegnalibri.Text = "🔖   Open XML  —  Segnalibri";
            this.btnOpenXmlSegnalibri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenXmlSegnalibri.UseVisualStyleBackColor = false;
            this.btnOpenXmlSegnalibri.Click += new System.EventHandler(this.btnOpenXmlSegnalibri_Click);
            // 
            // btnOpenXmlSegnalibriNoCls
            // 
            this.btnOpenXmlSegnalibriNoCls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btnOpenXmlSegnalibriNoCls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenXmlSegnalibriNoCls.FlatAppearance.BorderSize = 0;
            this.btnOpenXmlSegnalibriNoCls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.btnOpenXmlSegnalibriNoCls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnOpenXmlSegnalibriNoCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenXmlSegnalibriNoCls.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenXmlSegnalibriNoCls.ForeColor = System.Drawing.Color.White;
            this.btnOpenXmlSegnalibriNoCls.Location = new System.Drawing.Point(20, 202);
            this.btnOpenXmlSegnalibriNoCls.Name = "btnOpenXmlSegnalibriNoCls";
            this.btnOpenXmlSegnalibriNoCls.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOpenXmlSegnalibriNoCls.Size = new System.Drawing.Size(344, 48);
            this.btnOpenXmlSegnalibriNoCls.TabIndex = 2;
            this.btnOpenXmlSegnalibriNoCls.Text = "🔖   Open XML — Segnalibri  —  No ClsSQLServer";
            this.btnOpenXmlSegnalibriNoCls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenXmlSegnalibriNoCls.UseVisualStyleBackColor = false;
            this.btnOpenXmlSegnalibriNoCls.Click += new System.EventHandler(this.btnOpenXmlSegnalibriNoCls_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open XML";
            this.pnlBackground.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Helper: rounded card via Paint ────────────────────────────
        private void pnlCard_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // subtle inner glow / border
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(51, 65, 85), 1f))
            {
                var rect = new System.Drawing.Rectangle(0, 0,
                    pnlCard.Width - 1, pnlCard.Height - 1);
                int r = 10;
                var path = RoundedRect(rect, r);
                // clip the panel to rounded shape
                pnlCard.Region = new System.Drawing.Region(path);
                g.DrawPath(pen, path);
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(
            System.Drawing.Rectangle bounds, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnOpenXmlBase;
        private System.Windows.Forms.Button btnOpenXmlSegnalibri;
        private System.Windows.Forms.Button btnOpenXmlSegnalibriNoCls;
    }
}

