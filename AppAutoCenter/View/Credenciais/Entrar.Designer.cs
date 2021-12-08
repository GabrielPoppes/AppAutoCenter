
namespace AppAutoCenter.View.Credenciais
{
    partial class Entrar
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
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicLogoAutoCenter = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoAutoCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbEmail
            // 
            this.TxbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.TxbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.ForeColor = System.Drawing.Color.White;
            this.TxbEmail.Location = new System.Drawing.Point(317, 221);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(210, 16);
            this.TxbEmail.TabIndex = 1;
            this.TxbEmail.Text = "E-mail";
            this.TxbEmail.Click += new System.EventHandler(this.TxbEmail_Click);
            // 
            // TxbSenha
            // 
            this.TxbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.TxbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.ForeColor = System.Drawing.Color.White;
            this.TxbSenha.Location = new System.Drawing.Point(317, 255);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(210, 16);
            this.TxbSenha.TabIndex = 2;
            this.TxbSenha.Text = "Senha";
            this.TxbSenha.Click += new System.EventHandler(this.TxbSenha_Click);
            this.TxbSenha.TextChanged += new System.EventHandler(this.TxbSenha_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(279, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(279, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 1);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppAutoCenter.Properties.Resources._7252737_lock_security_protection_secure_shield_icon__1_2;
            this.pictureBox3.Location = new System.Drawing.Point(279, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppAutoCenter.Properties.Resources._2024644_login_user_avatar_person_users_icon__1_;
            this.pictureBox2.Location = new System.Drawing.Point(279, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // PicLogoAutoCenter
            // 
            this.PicLogoAutoCenter.Image = global::AppAutoCenter.Properties.Resources._1E2D4B;
            this.PicLogoAutoCenter.Location = new System.Drawing.Point(279, 46);
            this.PicLogoAutoCenter.Name = "PicLogoAutoCenter";
            this.PicLogoAutoCenter.Size = new System.Drawing.Size(248, 150);
            this.PicLogoAutoCenter.TabIndex = 0;
            this.PicLogoAutoCenter.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(124)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(279, 290);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(248, 25);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "ENTRAR";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(279, 321);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(248, 25);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.PicLogoAutoCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoAutoCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogoAutoCenter;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}