namespace _07_Basket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtG1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtG2 = new System.Windows.Forms.TextBox();
            this.lblControllo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTiro = new System.Windows.Forms.Label();
            this.lblGara = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picBasket = new System.Windows.Forms.PictureBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtG1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GIOCATORE 1";
            // 
            // txtG1
            // 
            this.txtG1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtG1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG1.Location = new System.Drawing.Point(6, 20);
            this.txtG1.MaxLength = 20;
            this.txtG1.Name = "txtG1";
            this.txtG1.Size = new System.Drawing.Size(172, 23);
            this.txtG1.TabIndex = 0;
            this.txtG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtG2);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 57);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GIOCATORE 2";
            // 
            // txtG2
            // 
            this.txtG2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtG2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG2.Location = new System.Drawing.Point(6, 20);
            this.txtG2.MaxLength = 20;
            this.txtG2.Name = "txtG2";
            this.txtG2.Size = new System.Drawing.Size(172, 23);
            this.txtG2.TabIndex = 1;
            this.txtG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblControllo
            // 
            this.lblControllo.AutoSize = true;
            this.lblControllo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControllo.Location = new System.Drawing.Point(485, 430);
            this.lblControllo.Name = "lblControllo";
            this.lblControllo.Size = new System.Drawing.Size(118, 29);
            this.lblControllo.TabIndex = 17;
            this.lblControllo.Text = "[lblControllo]";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(508, 133);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 19);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "[lblStatus]";
            // 
            // lblTiro
            // 
            this.lblTiro.AutoSize = true;
            this.lblTiro.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiro.Location = new System.Drawing.Point(365, 12);
            this.lblTiro.Name = "lblTiro";
            this.lblTiro.Size = new System.Drawing.Size(66, 19);
            this.lblTiro.TabIndex = 15;
            this.lblTiro.Text = "[lblTiro]";
            // 
            // lblGara
            // 
            this.lblGara.AutoSize = true;
            this.lblGara.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGara.Location = new System.Drawing.Point(365, 36);
            this.lblGara.Name = "lblGara";
            this.lblGara.Size = new System.Drawing.Size(73, 19);
            this.lblGara.TabIndex = 14;
            this.lblGara.Text = "[lblGara]";
            // 
            // picBall
            // 
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(373, 250);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(58, 59);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 13;
            this.picBall.TabStop = false;
            // 
            // picBasket
            // 
            this.picBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasket.BackgroundImage")));
            this.picBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasket.Location = new System.Drawing.Point(306, 373);
            this.picBasket.Name = "picBasket";
            this.picBasket.Size = new System.Drawing.Size(184, 157);
            this.picBasket.TabIndex = 12;
            this.picBasket.TabStop = false;
            // 
            // btnAvvia
            // 
            this.btnAvvia.BackColor = System.Drawing.Color.Brown;
            this.btnAvvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvvia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvvia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAvvia.Location = new System.Drawing.Point(12, 149);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(184, 28);
            this.btnAvvia.TabIndex = 11;
            this.btnAvvia.Text = "AVVIA GARA";
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblControllo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTiro);
            this.Controls.Add(this.lblGara);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picBasket);
            this.Controls.Add(this.btnAvvia);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket 1 VS 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtG1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtG2;
        private System.Windows.Forms.Label lblControllo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTiro;
        private System.Windows.Forms.Label lblGara;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picBasket;
        private System.Windows.Forms.Button btnAvvia;
    }
}

