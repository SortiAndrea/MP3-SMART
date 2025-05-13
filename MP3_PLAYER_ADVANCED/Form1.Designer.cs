namespace MP3_PLAYER_ADVANCED
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCanzoni = new System.Windows.Forms.ListBox();
            this.btnCaricaFile = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.lbLyrics = new System.Windows.Forms.ListBox();
            this.btnCaricaPlaylist = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApriForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCanzoni
            // 
            this.lbCanzoni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanzoni.FormattingEnabled = true;
            this.lbCanzoni.ItemHeight = 20;
            this.lbCanzoni.Location = new System.Drawing.Point(12, 121);
            this.lbCanzoni.Name = "lbCanzoni";
            this.lbCanzoni.Size = new System.Drawing.Size(321, 144);
            this.lbCanzoni.TabIndex = 1;
            this.lbCanzoni.SelectedIndexChanged += new System.EventHandler(this.lbCanzoni_SelectedIndexChanged);
            // 
            // btnCaricaFile
            // 
            this.btnCaricaFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaFile.Location = new System.Drawing.Point(12, 271);
            this.btnCaricaFile.Name = "btnCaricaFile";
            this.btnCaricaFile.Size = new System.Drawing.Size(159, 67);
            this.btnCaricaFile.TabIndex = 2;
            this.btnCaricaFile.Text = "CARICA FILE";
            this.btnCaricaFile.UseVisualStyleBackColor = true;
            this.btnCaricaFile.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(940, 121);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(483, 384);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bigLabel1.Location = new System.Drawing.Point(525, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(358, 81);
            this.bigLabel1.TabIndex = 3;
            this.bigLabel1.Text = "Mp3-Smart";
            // 
            // lbLyrics
            // 
            this.lbLyrics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLyrics.FormattingEnabled = true;
            this.lbLyrics.HorizontalScrollbar = true;
            this.lbLyrics.ItemHeight = 20;
            this.lbLyrics.Location = new System.Drawing.Point(339, 121);
            this.lbLyrics.Name = "lbLyrics";
            this.lbLyrics.Size = new System.Drawing.Size(595, 384);
            this.lbLyrics.TabIndex = 4;
            // 
            // btnCaricaPlaylist
            // 
            this.btnCaricaPlaylist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaPlaylist.Location = new System.Drawing.Point(174, 271);
            this.btnCaricaPlaylist.Name = "btnCaricaPlaylist";
            this.btnCaricaPlaylist.Size = new System.Drawing.Size(159, 67);
            this.btnCaricaPlaylist.TabIndex = 5;
            this.btnCaricaPlaylist.Text = "CARICA PLAYLIST";
            this.btnCaricaPlaylist.UseVisualStyleBackColor = true;
            this.btnCaricaPlaylist.Click += new System.EventHandler(this.btnCaricaPlaylist_Click_1);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(12, 456);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(321, 50);
            this.btnElimina.TabIndex = 6;
            this.btnElimina.Text = "CANCELLA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(12, 344);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(321, 50);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "SALVA PLAYLIST";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApriForm2
            // 
            this.btnApriForm2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApriForm2.Location = new System.Drawing.Point(12, 400);
            this.btnApriForm2.Name = "btnApriForm2";
            this.btnApriForm2.Size = new System.Drawing.Size(321, 50);
            this.btnApriForm2.TabIndex = 8;
            this.btnApriForm2.Text = "CERCA MANUALMENTE LYRICS";
            this.btnApriForm2.UseVisualStyleBackColor = true;
            this.btnApriForm2.Click += new System.EventHandler(this.btnApriForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1435, 518);
            this.Controls.Add(this.btnApriForm2);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnCaricaPlaylist);
            this.Controls.Add(this.lbLyrics);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.btnCaricaFile);
            this.Controls.Add(this.lbCanzoni);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "MP3-SMART";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox lbCanzoni;
        private System.Windows.Forms.Button btnCaricaFile;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.ListBox lbLyrics;
        private System.Windows.Forms.Button btnCaricaPlaylist;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApriForm2;
    }
}

