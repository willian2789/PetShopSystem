
namespace TCM
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_usuario_logado = new System.Windows.Forms.Label();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_delivery = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_serviço = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_pets = new System.Windows.Forms.Button();
            this.inicio = new TCM.Inicio();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.lbl_usuario_logado);
            this.panel1.Controls.Add(this.btn_finalizar);
            this.panel1.Controls.Add(this.btn_delivery);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_inicio);
            this.panel1.Controls.Add(this.btn_serviço);
            this.panel1.Controls.Add(this.btn_cliente);
            this.panel1.Controls.Add(this.btn_pets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 610);
            this.panel1.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_usuario.Location = new System.Drawing.Point(0, 499);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(182, 30);
            this.lbl_usuario.TabIndex = 13;
            this.lbl_usuario.Text = "Usuario logado :";
            // 
            // lbl_usuario_logado
            // 
            this.lbl_usuario_logado.AutoSize = true;
            this.lbl_usuario_logado.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario_logado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_usuario_logado.Location = new System.Drawing.Point(0, 547);
            this.lbl_usuario_logado.Name = "lbl_usuario_logado";
            this.lbl_usuario_logado.Size = new System.Drawing.Size(48, 25);
            this.lbl_usuario_logado.TabIndex = 11;
            this.lbl_usuario_logado.Text = "XXX";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatAppearance.BorderSize = 0;
            this.btn_finalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_finalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_finalizar.Image")));
            this.btn_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finalizar.Location = new System.Drawing.Point(0, 354);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(240, 43);
            this.btn_finalizar.TabIndex = 8;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_delivery
            // 
            this.btn_delivery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_delivery.FlatAppearance.BorderSize = 0;
            this.btn_delivery.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_delivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivery.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_delivery.Image = ((System.Drawing.Image)(resources.GetObject("btn_delivery.Image")));
            this.btn_delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delivery.Location = new System.Drawing.Point(0, 309);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Size = new System.Drawing.Size(240, 45);
            this.btn_delivery.TabIndex = 6;
            this.btn_delivery.Text = "Delivery";
            this.btn_delivery.UseVisualStyleBackColor = true;
            this.btn_delivery.Click += new System.EventHandler(this.btn_delivery_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sair.Image = global::TCM.Properties.Resources.icons8_power_off_button_503;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(0, 397);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(240, 45);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_inicio.Location = new System.Drawing.Point(0, 48);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(240, 49);
            this.btn_inicio.TabIndex = 1;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_serviço
            // 
            this.btn_serviço.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_serviço.FlatAppearance.BorderSize = 0;
            this.btn_serviço.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_serviço.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_serviço.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_serviço.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serviço.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_serviço.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_serviço.Image = ((System.Drawing.Image)(resources.GetObject("btn_serviço.Image")));
            this.btn_serviço.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_serviço.Location = new System.Drawing.Point(0, 266);
            this.btn_serviço.Name = "btn_serviço";
            this.btn_serviço.Size = new System.Drawing.Size(243, 43);
            this.btn_serviço.TabIndex = 4;
            this.btn_serviço.Text = "Serviços";
            this.btn_serviço.UseVisualStyleBackColor = true;
            this.btn_serviço.Click += new System.EventHandler(this.btn_serviço_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cliente.Image = global::TCM.Properties.Resources.icons8_user_account_501;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(0, 191);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(240, 38);
            this.btn_cliente.TabIndex = 2;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_pets
            // 
            this.btn_pets.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pets.FlatAppearance.BorderSize = 0;
            this.btn_pets.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_pets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_pets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pets.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_pets.Image = global::TCM.Properties.Resources.icons8_pets_504;
            this.btn_pets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pets.Location = new System.Drawing.Point(0, 229);
            this.btn_pets.Name = "btn_pets";
            this.btn_pets.Size = new System.Drawing.Size(240, 37);
            this.btn_pets.TabIndex = 3;
            this.btn_pets.Text = "Pets";
            this.btn_pets.UseVisualStyleBackColor = true;
            this.btn_pets.Click += new System.EventHandler(this.btn_pets_Click);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(232, 0);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(731, 610);
            this.inicio.TabIndex = 2;
            this.inicio.Load += new System.EventHandler(this.inicio_Load);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 610);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_serviço;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_pets;
        private System.Windows.Forms.Button btn_delivery;
        private Inicio inicio;
        private Cliente cliente;
        private Pets pets;
        private Serviços serviços;
        private System.Windows.Forms.Button btn_finalizar;
        private Delivery delivery;
        private System.Windows.Forms.Label lbl_usuario_logado;
        private System.Windows.Forms.Label lbl_usuario;
    }
}