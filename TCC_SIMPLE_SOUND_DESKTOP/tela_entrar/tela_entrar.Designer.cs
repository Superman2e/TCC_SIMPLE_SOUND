namespace tela_entrar
{
    partial class tela_entrar
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_email_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(463, 448);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(509, 61);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.TabStop = false;
            this.txt_senha.Text = "SENHA                                                                            " +
    "           ESQUECEU?";
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senha.UseWaitCursor = true;
            this.txt_senha.WordWrap = false;
            // 
            // txt_email_usuario
            // 
            this.txt_email_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_email_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_email_usuario.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_usuario.Location = new System.Drawing.Point(463, 344);
            this.txt_email_usuario.Multiline = true;
            this.txt_email_usuario.Name = "txt_email_usuario";
            this.txt_email_usuario.Size = new System.Drawing.Size(509, 61);
            this.txt_email_usuario.TabIndex = 2;
            this.txt_email_usuario.TabStop = false;
            this.txt_email_usuario.Text = "E-MAIL OU NOME DO USUÁRIO";
            this.txt_email_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email_usuario.UseWaitCursor = true;
            this.txt_email_usuario.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(660, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tela_entrar.Properties.Resources.Captura_de_tela_2024_04_22_112942;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1079, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 65);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tela_entrar.Properties.Resources.Captura_de_tela_2024_04_22_110334;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(463, 560);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tela_entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1382, 797);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email_usuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tela_entrar";
            this.Text = "tela_entrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_email_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

