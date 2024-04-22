namespace TCC_SIMPLE_SOUND
{
    partial class tela_splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_splash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_splash
            // 
            this.lbl_splash.AutoSize = true;
            this.lbl_splash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_splash.Font = new System.Drawing.Font("Bodoni MT Black", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_splash.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_splash.Location = new System.Drawing.Point(467, 266);
            this.lbl_splash.Name = "lbl_splash";
            this.lbl_splash.Size = new System.Drawing.Size(495, 220);
            this.lbl_splash.TabIndex = 0;
            this.lbl_splash.Text = "SIMPLE \r\nSOUNDS";
            this.lbl_splash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tela_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1382, 797);
            this.Controls.Add(this.lbl_splash);
            this.Name = "tela_splash";
            this.Text = "splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_splash;
    }
}

