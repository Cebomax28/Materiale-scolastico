namespace _08_Bowling
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.nUDpartecipanti = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.txtPunteggio = new System.Windows.Forms.TextBox();
            this.lblEsito = new System.Windows.Forms.Label();
            this.lblPunti4 = new System.Windows.Forms.Label();
            this.lblGioc4 = new System.Windows.Forms.Label();
            this.picB4 = new System.Windows.Forms.PictureBox();
            this.lblPunti3 = new System.Windows.Forms.Label();
            this.lblGioc3 = new System.Windows.Forms.Label();
            this.picB3 = new System.Windows.Forms.PictureBox();
            this.lblPunti2 = new System.Windows.Forms.Label();
            this.lblGioc2 = new System.Windows.Forms.Label();
            this.picB2 = new System.Windows.Forms.PictureBox();
            this.lblPunti1 = new System.Windows.Forms.Label();
            this.lblGioc1 = new System.Windows.Forms.Label();
            this.picB1 = new System.Windows.Forms.PictureBox();
            this.picBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDpartecipanti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBG)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDpartecipanti
            // 
            this.nUDpartecipanti.Location = new System.Drawing.Point(49, 22);
            this.nUDpartecipanti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDpartecipanti.Name = "nUDpartecipanti";
            this.nUDpartecipanti.Size = new System.Drawing.Size(120, 23);
            this.nUDpartecipanti.TabIndex = 0;
            this.nUDpartecipanti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDpartecipanti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUDpartecipanti);
            this.groupBox1.Location = new System.Drawing.Point(597, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 63);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partecipanti";
            // 
            // btnAvvia
            // 
            this.btnAvvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvvia.Location = new System.Drawing.Point(597, 80);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(217, 37);
            this.btnAvvia.TabIndex = 32;
            this.btnAvvia.Text = "Avvia Torneo";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // txtPunteggio
            // 
            this.txtPunteggio.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunteggio.Location = new System.Drawing.Point(597, 209);
            this.txtPunteggio.Multiline = true;
            this.txtPunteggio.Name = "txtPunteggio";
            this.txtPunteggio.ReadOnly = true;
            this.txtPunteggio.Size = new System.Drawing.Size(217, 344);
            this.txtPunteggio.TabIndex = 31;
            // 
            // lblEsito
            // 
            this.lblEsito.AutoSize = true;
            this.lblEsito.Location = new System.Drawing.Point(594, 120);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Size = new System.Drawing.Size(59, 16);
            this.lblEsito.TabIndex = 30;
            this.lblEsito.Text = "[lblEsito]";
            // 
            // lblPunti4
            // 
            this.lblPunti4.AutoSize = true;
            this.lblPunti4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti4.Location = new System.Drawing.Point(458, 475);
            this.lblPunti4.Name = "lblPunti4";
            this.lblPunti4.Size = new System.Drawing.Size(84, 19);
            this.lblPunti4.TabIndex = 29;
            this.lblPunti4.Text = "[lblPunti4]";
            // 
            // lblGioc4
            // 
            this.lblGioc4.AutoSize = true;
            this.lblGioc4.BackColor = System.Drawing.Color.PaleGreen;
            this.lblGioc4.Location = new System.Drawing.Point(458, 431);
            this.lblGioc4.Name = "lblGioc4";
            this.lblGioc4.Size = new System.Drawing.Size(61, 16);
            this.lblGioc4.TabIndex = 28;
            this.lblGioc4.Text = "[lblGioc4]";
            // 
            // picB4
            // 
            this.picB4.Image = ((System.Drawing.Image)(resources.GetObject("picB4.Image")));
            this.picB4.Location = new System.Drawing.Point(403, 475);
            this.picB4.Name = "picB4";
            this.picB4.Size = new System.Drawing.Size(40, 30);
            this.picB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB4.TabIndex = 27;
            this.picB4.TabStop = false;
            // 
            // lblPunti3
            // 
            this.lblPunti3.AutoSize = true;
            this.lblPunti3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti3.Location = new System.Drawing.Point(458, 327);
            this.lblPunti3.Name = "lblPunti3";
            this.lblPunti3.Size = new System.Drawing.Size(83, 19);
            this.lblPunti3.TabIndex = 26;
            this.lblPunti3.Text = "[lblPunti3]";
            // 
            // lblGioc3
            // 
            this.lblGioc3.AutoSize = true;
            this.lblGioc3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblGioc3.Location = new System.Drawing.Point(458, 283);
            this.lblGioc3.Name = "lblGioc3";
            this.lblGioc3.Size = new System.Drawing.Size(61, 16);
            this.lblGioc3.TabIndex = 25;
            this.lblGioc3.Text = "[lblGioc3]";
            // 
            // picB3
            // 
            this.picB3.Image = ((System.Drawing.Image)(resources.GetObject("picB3.Image")));
            this.picB3.Location = new System.Drawing.Point(403, 327);
            this.picB3.Name = "picB3";
            this.picB3.Size = new System.Drawing.Size(40, 30);
            this.picB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB3.TabIndex = 24;
            this.picB3.TabStop = false;
            // 
            // lblPunti2
            // 
            this.lblPunti2.AutoSize = true;
            this.lblPunti2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti2.Location = new System.Drawing.Point(458, 195);
            this.lblPunti2.Name = "lblPunti2";
            this.lblPunti2.Size = new System.Drawing.Size(83, 19);
            this.lblPunti2.TabIndex = 23;
            this.lblPunti2.Text = "[lblPunti2]";
            // 
            // lblGioc2
            // 
            this.lblGioc2.AutoSize = true;
            this.lblGioc2.BackColor = System.Drawing.Color.Khaki;
            this.lblGioc2.Location = new System.Drawing.Point(458, 151);
            this.lblGioc2.Name = "lblGioc2";
            this.lblGioc2.Size = new System.Drawing.Size(61, 16);
            this.lblGioc2.TabIndex = 22;
            this.lblGioc2.Text = "[lblGioc2]";
            // 
            // picB2
            // 
            this.picB2.Image = ((System.Drawing.Image)(resources.GetObject("picB2.Image")));
            this.picB2.Location = new System.Drawing.Point(403, 195);
            this.picB2.Name = "picB2";
            this.picB2.Size = new System.Drawing.Size(40, 30);
            this.picB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB2.TabIndex = 21;
            this.picB2.TabStop = false;
            // 
            // lblPunti1
            // 
            this.lblPunti1.AutoSize = true;
            this.lblPunti1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunti1.Location = new System.Drawing.Point(458, 55);
            this.lblPunti1.Name = "lblPunti1";
            this.lblPunti1.Size = new System.Drawing.Size(80, 19);
            this.lblPunti1.TabIndex = 20;
            this.lblPunti1.Text = "[lblPunti1]";
            // 
            // lblGioc1
            // 
            this.lblGioc1.AutoSize = true;
            this.lblGioc1.BackColor = System.Drawing.Color.Coral;
            this.lblGioc1.Location = new System.Drawing.Point(458, 10);
            this.lblGioc1.Name = "lblGioc1";
            this.lblGioc1.Size = new System.Drawing.Size(58, 16);
            this.lblGioc1.TabIndex = 19;
            this.lblGioc1.Text = "[lblGioc1]";
            // 
            // picB1
            // 
            this.picB1.Image = ((System.Drawing.Image)(resources.GetObject("picB1.Image")));
            this.picB1.Location = new System.Drawing.Point(403, 55);
            this.picB1.Name = "picB1";
            this.picB1.Size = new System.Drawing.Size(40, 30);
            this.picB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB1.TabIndex = 18;
            this.picB1.TabStop = false;
            // 
            // picBG
            // 
            this.picBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBG.BackgroundImage")));
            this.picBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBG.Location = new System.Drawing.Point(4, 2);
            this.picBG.Name = "picBG";
            this.picBG.Size = new System.Drawing.Size(587, 562);
            this.picBG.TabIndex = 17;
            this.picBG.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.txtPunteggio);
            this.Controls.Add(this.lblEsito);
            this.Controls.Add(this.lblPunti4);
            this.Controls.Add(this.lblGioc4);
            this.Controls.Add(this.picB4);
            this.Controls.Add(this.lblPunti3);
            this.Controls.Add(this.lblGioc3);
            this.Controls.Add(this.picB3);
            this.Controls.Add(this.lblPunti2);
            this.Controls.Add(this.lblGioc2);
            this.Controls.Add(this.picB2);
            this.Controls.Add(this.lblPunti1);
            this.Controls.Add(this.lblGioc1);
            this.Controls.Add(this.picB1);
            this.Controls.Add(this.picBG);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TORNEO BOWLING";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDpartecipanti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDpartecipanti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.TextBox txtPunteggio;
        private System.Windows.Forms.Label lblEsito;
        private System.Windows.Forms.Label lblPunti4;
        private System.Windows.Forms.Label lblGioc4;
        private System.Windows.Forms.PictureBox picB4;
        private System.Windows.Forms.Label lblPunti3;
        private System.Windows.Forms.Label lblGioc3;
        private System.Windows.Forms.PictureBox picB3;
        private System.Windows.Forms.Label lblPunti2;
        private System.Windows.Forms.Label lblGioc2;
        private System.Windows.Forms.PictureBox picB2;
        private System.Windows.Forms.Label lblPunti1;
        private System.Windows.Forms.Label lblGioc1;
        private System.Windows.Forms.PictureBox picB1;
        private System.Windows.Forms.PictureBox picBG;
    }
}

