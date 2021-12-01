
namespace TCM
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lbl_imagem = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(198)))), ((int)(((byte)(113)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Btn_sair);
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 62);
            this.panel1.TabIndex = 0;
            // 
            // Btn_sair
            // 
            this.Btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(198)))), ((int)(((byte)(113)))));
            this.Btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_sair.FlatAppearance.BorderSize = 0;
            this.Btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sair.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_sair.ForeColor = System.Drawing.Color.White;
            this.Btn_sair.Location = new System.Drawing.Point(357, 0);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(62, 62);
            this.Btn_sair.TabIndex = 6;
            this.Btn_sair.Text = "X";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_login.Location = new System.Drawing.Point(146, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(127, 54);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.Location = new System.Drawing.Point(132, 357);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(164, 33);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(132, 308);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(196, 31);
            this.txt_usuario.TabIndex = 2;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(198)))), ((int)(((byte)(113)))));
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.Location = new System.Drawing.Point(146, 440);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(131, 41);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = " Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lbl_imagem
            // 
            this.lbl_imagem.Image = global::TCM.Properties.Resources.login2;
            this.lbl_imagem.Location = new System.Drawing.Point(108, 76);
            this.lbl_imagem.Name = "lbl_imagem";
            this.lbl_imagem.Size = new System.Drawing.Size(197, 187);
            this.lbl_imagem.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.Location = new System.Drawing.Point(35, 308);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(91, 25);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "Usuario :";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_senha.Location = new System.Drawing.Point(35, 357);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(76, 25);
            this.lbl_senha.TabIndex = 5;
            this.lbl_senha.Text = "Senha :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 514);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_imagem);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label lbl_imagem;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button Btn_sair;
    }
}

