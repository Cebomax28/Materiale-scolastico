namespace Gara_di_nuoto
{
    partial class frmMain
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
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEsito = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEliminati = new System.Windows.Forms.Label();
            this.lblAtleti = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAvvia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(34, 20);
            this.txtA1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA1.Name = "txtA1";
            this.txtA1.ReadOnly = true;
            this.txtA1.Size = new System.Drawing.Size(123, 27);
            this.txtA1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gara_di_nuoto.Properties.Resources.imgNuoto;
            this.pictureBox1.Location = new System.Drawing.Point(17, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 618);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtA4
            // 
            this.txtA4.Location = new System.Drawing.Point(504, 20);
            this.txtA4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA4.Name = "txtA4";
            this.txtA4.ReadOnly = true;
            this.txtA4.Size = new System.Drawing.Size(123, 27);
            this.txtA4.TabIndex = 5;
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(349, 20);
            this.txtA3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA3.Name = "txtA3";
            this.txtA3.ReadOnly = true;
            this.txtA3.Size = new System.Drawing.Size(123, 27);
            this.txtA3.TabIndex = 6;
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(189, 20);
            this.txtA2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA2.Name = "txtA2";
            this.txtA2.ReadOnly = true;
            this.txtA2.Size = new System.Drawing.Size(123, 27);
            this.txtA2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEsito);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(653, 415);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(286, 256);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BATTERIA FINALISTI";
            // 
            // lblEsito
            // 
            this.lblEsito.AutoSize = true;
            this.lblEsito.Location = new System.Drawing.Point(5, 22);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Size = new System.Drawing.Size(59, 16);
            this.lblEsito.TabIndex = 14;
            this.lblEsito.Text = "[lblEsito]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEliminati);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(943, 415);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(286, 256);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINATI";
            // 
            // lblEliminati
            // 
            this.lblEliminati.AutoSize = true;
            this.lblEliminati.Location = new System.Drawing.Point(5, 22);
            this.lblEliminati.Name = "lblEliminati";
            this.lblEliminati.Size = new System.Drawing.Size(79, 16);
            this.lblEliminati.TabIndex = 13;
            this.lblEliminati.Text = "[lblEliminati]";
            // 
            // lblAtleti
            // 
            this.lblAtleti.AutoSize = true;
            this.lblAtleti.Location = new System.Drawing.Point(671, 25);
            this.lblAtleti.Name = "lblAtleti";
            this.lblAtleti.Size = new System.Drawing.Size(74, 20);
            this.lblAtleti.TabIndex = 10;
            this.lblAtleti.Text = "[lblAtleti]";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.Blue;
            this.lblTurno.Location = new System.Drawing.Point(654, 358);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(79, 20);
            this.lblTurno.TabIndex = 11;
            this.lblTurno.Text = "[lblTurno]";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(656, 393);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "[lblStatus]";
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(1069, 2);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(284, 168);
            this.btnAvvia.TabIndex = 13;
            this.btnAvvia.Text = "AVVIA";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 685);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblAtleti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.txtA4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtA1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "PISCINA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtA4;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAtleti;
        private System.Windows.Forms.Label lblEsito;
        private System.Windows.Forms.Label lblEliminati;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAvvia;
    }
}

