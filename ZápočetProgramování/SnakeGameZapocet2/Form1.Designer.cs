namespace SnakeGameZapocet2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.STARTbutton = new System.Windows.Forms.Button();
            this.PHOTObutton = new System.Windows.Forms.Button();
            this.RESTARTbutton = new System.Windows.Forms.Button();
            this.AKTUALNISCORElabell = new System.Windows.Forms.Label();
            this.NEJVYSSISKORElabell = new System.Windows.Forms.Label();
            this.AktualniScore = new System.Windows.Forms.Label();
            this.NejvyssiScore = new System.Windows.Forms.Label();
            this.HraciPlocha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SnakeTimer = new System.Windows.Forms.Timer(this.components);
            this.GAMEOVERlabell = new System.Windows.Forms.Label();
            this.UVODNIlabell = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HraciPlocha)).BeginInit();
            this.SuspendLayout();
            // 
            // STARTbutton
            // 
            this.STARTbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.STARTbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.STARTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.STARTbutton.Location = new System.Drawing.Point(842, 12);
            this.STARTbutton.Name = "STARTbutton";
            this.STARTbutton.Size = new System.Drawing.Size(148, 64);
            this.STARTbutton.TabIndex = 0;
            this.STARTbutton.Text = "START";
            this.STARTbutton.UseVisualStyleBackColor = false;
            this.STARTbutton.Click += new System.EventHandler(this.StartHry);
            // 
            // PHOTObutton
            // 
            this.PHOTObutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PHOTObutton.BackColor = System.Drawing.Color.Fuchsia;
            this.PHOTObutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PHOTObutton.Location = new System.Drawing.Point(842, 82);
            this.PHOTObutton.Name = "PHOTObutton";
            this.PHOTObutton.Size = new System.Drawing.Size(148, 64);
            this.PHOTObutton.TabIndex = 1;
            this.PHOTObutton.Text = "PHOTO";
            this.PHOTObutton.UseVisualStyleBackColor = false;
            this.PHOTObutton.Click += new System.EventHandler(this.UdelejFotku);
            // 
            // RESTARTbutton
            // 
            this.RESTARTbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RESTARTbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.RESTARTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RESTARTbutton.Location = new System.Drawing.Point(842, 152);
            this.RESTARTbutton.Name = "RESTARTbutton";
            this.RESTARTbutton.Size = new System.Drawing.Size(148, 64);
            this.RESTARTbutton.TabIndex = 2;
            this.RESTARTbutton.Text = "RESTART";
            this.RESTARTbutton.UseVisualStyleBackColor = false;
            this.RESTARTbutton.Click += new System.EventHandler(this.RestartHry);
            // 
            // AKTUALNISCORElabell
            // 
            this.AKTUALNISCORElabell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AKTUALNISCORElabell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AKTUALNISCORElabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AKTUALNISCORElabell.Location = new System.Drawing.Point(842, 233);
            this.AKTUALNISCORElabell.Name = "AKTUALNISCORElabell";
            this.AKTUALNISCORElabell.Size = new System.Drawing.Size(148, 60);
            this.AKTUALNISCORElabell.TabIndex = 3;
            this.AKTUALNISCORElabell.Text = "Aktuální skore: ";
            // 
            // NEJVYSSISKORElabell
            // 
            this.NEJVYSSISKORElabell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NEJVYSSISKORElabell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NEJVYSSISKORElabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NEJVYSSISKORElabell.Location = new System.Drawing.Point(842, 305);
            this.NEJVYSSISKORElabell.Name = "NEJVYSSISKORElabell";
            this.NEJVYSSISKORElabell.Size = new System.Drawing.Size(148, 60);
            this.NEJVYSSISKORElabell.TabIndex = 4;
            this.NEJVYSSISKORElabell.Text = "Nejvyšší skore: ";
            // 
            // AktualniScore
            // 
            this.AktualniScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AktualniScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AktualniScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AktualniScore.Location = new System.Drawing.Point(896, 261);
            this.AktualniScore.Name = "AktualniScore";
            this.AktualniScore.Size = new System.Drawing.Size(94, 32);
            this.AktualniScore.TabIndex = 5;
            this.AktualniScore.Text = "0";
            // 
            // NejvyssiScore
            // 
            this.NejvyssiScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NejvyssiScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NejvyssiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NejvyssiScore.Location = new System.Drawing.Point(896, 333);
            this.NejvyssiScore.Name = "NejvyssiScore";
            this.NejvyssiScore.Size = new System.Drawing.Size(94, 32);
            this.NejvyssiScore.TabIndex = 6;
            this.NejvyssiScore.Text = "0";
            // 
            // HraciPlocha
            // 
            this.HraciPlocha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HraciPlocha.BackColor = System.Drawing.Color.RoyalBlue;
            this.HraciPlocha.Location = new System.Drawing.Point(12, 54);
            this.HraciPlocha.Name = "HraciPlocha";
            this.HraciPlocha.Size = new System.Drawing.Size(810, 452);
            this.HraciPlocha.TabIndex = 7;
            this.HraciPlocha.TabStop = false;
            this.HraciPlocha.Paint += new System.Windows.Forms.PaintEventHandler(this.HraciPlochaPaint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "SNAKE GAME ENJOY <3";
            // 
            // SnakeTimer
            // 
            this.SnakeTimer.Interval = 40;
            // 
            // GAMEOVERlabell
            // 
            this.GAMEOVERlabell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GAMEOVERlabell.BackColor = System.Drawing.Color.Navy;
            this.GAMEOVERlabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GAMEOVERlabell.ForeColor = System.Drawing.Color.White;
            this.GAMEOVERlabell.Location = new System.Drawing.Point(138, 143);
            this.GAMEOVERlabell.Name = "GAMEOVERlabell";
            this.GAMEOVERlabell.Size = new System.Drawing.Size(567, 315);
            this.GAMEOVERlabell.TabIndex = 9;
            this.GAMEOVERlabell.Text = "GAME OVER :(\r\nChcte-li pokračovat stiskněte START pro restartování stiskněte REST" +
    "ART. \r\nChcete-li si udělat fotku stikněte PHOTO\r\n\r\n";
            this.GAMEOVERlabell.Visible = false;
            // 
            // UVODNIlabell
            // 
            this.UVODNIlabell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UVODNIlabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UVODNIlabell.Location = new System.Drawing.Point(12, 54);
            this.UVODNIlabell.Name = "UVODNIlabell";
            this.UVODNIlabell.Size = new System.Drawing.Size(810, 452);
            this.UVODNIlabell.TabIndex = 10;
            this.UVODNIlabell.Text = "Pro spuštění hry stiskněte tlačítko START.";
            this.UVODNIlabell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 518);
            this.Controls.Add(this.UVODNIlabell);
            this.Controls.Add(this.GAMEOVERlabell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HraciPlocha);
            this.Controls.Add(this.NejvyssiScore);
            this.Controls.Add(this.AktualniScore);
            this.Controls.Add(this.NEJVYSSISKORElabell);
            this.Controls.Add(this.AKTUALNISCORElabell);
            this.Controls.Add(this.RESTARTbutton);
            this.Controls.Add(this.PHOTObutton);
            this.Controls.Add(this.STARTbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1250, 750);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "Form1";
            this.Text = "SNAKE_GAME";
            this.Load += new System.EventHandler(this.UpdateObrazovky);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.HraciPlocha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button STARTbutton;
        private System.Windows.Forms.Button PHOTObutton;
        private System.Windows.Forms.Button RESTARTbutton;
        private System.Windows.Forms.Label AKTUALNISCORElabell;
        private System.Windows.Forms.Label NEJVYSSISKORElabell;
        private System.Windows.Forms.Label AktualniScore;
        private System.Windows.Forms.Label NejvyssiScore;
        private System.Windows.Forms.PictureBox HraciPlocha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SnakeTimer;
        private System.Windows.Forms.Label GAMEOVERlabell;
        private System.Windows.Forms.Label UVODNIlabell;
    }
}

