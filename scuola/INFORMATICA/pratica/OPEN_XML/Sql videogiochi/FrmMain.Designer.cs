namespace _14_VideogiochiSQLServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowGiocatori = new System.Windows.Forms.Button();
            this.btnShowGiochi = new System.Windows.Forms.Button();
            this.btnShowPartite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONE VIDEOGIOCHI";
            // 
            // btnShowGiocatori
            // 
            this.btnShowGiocatori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowGiocatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGiocatori.Location = new System.Drawing.Point(12, 96);
            this.btnShowGiocatori.Name = "btnShowGiocatori";
            this.btnShowGiocatori.Size = new System.Drawing.Size(174, 108);
            this.btnShowGiocatori.TabIndex = 1;
            this.btnShowGiocatori.Text = "Giocatori";
            this.btnShowGiocatori.UseVisualStyleBackColor = true;
            this.btnShowGiocatori.Click += new System.EventHandler(this.btnShowGiocatori_Click);
            // 
            // btnShowGiochi
            // 
            this.btnShowGiochi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowGiochi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGiochi.Location = new System.Drawing.Point(192, 96);
            this.btnShowGiochi.Name = "btnShowGiochi";
            this.btnShowGiochi.Size = new System.Drawing.Size(174, 108);
            this.btnShowGiochi.TabIndex = 2;
            this.btnShowGiochi.Text = "Giochi";
            this.btnShowGiochi.UseVisualStyleBackColor = true;
            this.btnShowGiochi.Click += new System.EventHandler(this.btnShowGiochi_Click);
            // 
            // btnShowPartite
            // 
            this.btnShowPartite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPartite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPartite.Location = new System.Drawing.Point(372, 96);
            this.btnShowPartite.Name = "btnShowPartite";
            this.btnShowPartite.Size = new System.Drawing.Size(174, 108);
            this.btnShowPartite.TabIndex = 3;
            this.btnShowPartite.Text = "Partite";
            this.btnShowPartite.UseVisualStyleBackColor = true;
            this.btnShowPartite.Click += new System.EventHandler(this.btnShowPartite_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 232);
            this.Controls.Add(this.btnShowPartite);
            this.Controls.Add(this.btnShowGiochi);
            this.Controls.Add(this.btnShowGiocatori);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Giochi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowGiocatori;
        private System.Windows.Forms.Button btnShowGiochi;
        private System.Windows.Forms.Button btnShowPartite;
    }
}

