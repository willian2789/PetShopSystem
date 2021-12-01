
namespace TCM
{
    partial class Cliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_s = new System.Windows.Forms.Label();
            this.rdb_fem = new System.Windows.Forms.RadioButton();
            this.rdb_masc = new System.Windows.Forms.RadioButton();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_cel = new System.Windows.Forms.Label();
            this.lbl_fone = new System.Windows.Forms.Label();
            this.mtxt_cel = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_fone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rdb_inativo = new System.Windows.Forms.RadioButton();
            this.rdb_ativo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pesquisa.Location = new System.Drawing.Point(66, 145);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(223, 30);
            this.lbl_pesquisa.TabIndex = 0;
            this.lbl_pesquisa.Text = "Pesquisa por código";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisa.Location = new System.Drawing.Point(295, 145);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(333, 35);
            this.txt_pesquisa.TabIndex = 1;
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod.Location = new System.Drawing.Point(78, 294);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(87, 30);
            this.lbl_cod.TabIndex = 2;
            this.lbl_cod.Text = "Código";
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod.Location = new System.Drawing.Point(171, 292);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(66, 35);
            this.txt_cod.TabIndex = 3;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cliente.Location = new System.Drawing.Point(243, 294);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(85, 30);
            this.lbl_cliente.TabIndex = 4;
            this.lbl_cliente.Text = "Cliente";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(334, 292);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(306, 35);
            this.txt_nome.TabIndex = 5;
            // 
            // lbl_s
            // 
            this.lbl_s.AutoSize = true;
            this.lbl_s.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_s.Location = new System.Drawing.Point(74, 359);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(80, 30);
            this.lbl_s.TabIndex = 6;
            this.lbl_s.Text = "Sexo : ";
            // 
            // rdb_fem
            // 
            this.rdb_fem.AutoSize = true;
            this.rdb_fem.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_fem.Location = new System.Drawing.Point(160, 357);
            this.rdb_fem.Name = "rdb_fem";
            this.rdb_fem.Size = new System.Drawing.Size(125, 34);
            this.rdb_fem.TabIndex = 7;
            this.rdb_fem.TabStop = true;
            this.rdb_fem.Text = "Feminino";
            this.rdb_fem.UseVisualStyleBackColor = true;
            // 
            // rdb_masc
            // 
            this.rdb_masc.AutoSize = true;
            this.rdb_masc.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_masc.Location = new System.Drawing.Point(287, 359);
            this.rdb_masc.Name = "rdb_masc";
            this.rdb_masc.Size = new System.Drawing.Size(136, 34);
            this.rdb_masc.TabIndex = 8;
            this.rdb_masc.TabStop = true;
            this.rdb_masc.Text = "Masculino";
            this.rdb_masc.UseVisualStyleBackColor = true;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpf.Location = new System.Drawing.Point(429, 359);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(52, 30);
            this.lbl_cpf.TabIndex = 9;
            this.lbl_cpf.Text = "CPF";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cpf.Location = new System.Drawing.Point(490, 355);
            this.mtxt_cpf.Mask = "000.000.000-00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(150, 35);
            this.mtxt_cpf.TabIndex = 10;
            this.mtxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(78, 421);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 30);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "E-mail";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(205, 419);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(435, 35);
            this.txt_email.TabIndex = 12;
            // 
            // lbl_cel
            // 
            this.lbl_cel.AutoSize = true;
            this.lbl_cel.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cel.Location = new System.Drawing.Point(92, 492);
            this.lbl_cel.Name = "lbl_cel";
            this.lbl_cel.Size = new System.Drawing.Size(85, 30);
            this.lbl_cel.TabIndex = 17;
            this.lbl_cel.Text = "Celular";
            // 
            // lbl_fone
            // 
            this.lbl_fone.AutoSize = true;
            this.lbl_fone.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fone.Location = new System.Drawing.Point(377, 487);
            this.lbl_fone.Name = "lbl_fone";
            this.lbl_fone.Size = new System.Drawing.Size(62, 30);
            this.lbl_fone.TabIndex = 18;
            this.lbl_fone.Text = "Fone";
            // 
            // mtxt_cel
            // 
            this.mtxt_cel.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cel.Location = new System.Drawing.Point(183, 487);
            this.mtxt_cel.Mask = "00000 - 0000";
            this.mtxt_cel.Name = "mtxt_cel";
            this.mtxt_cel.Size = new System.Drawing.Size(140, 35);
            this.mtxt_cel.TabIndex = 19;
            this.mtxt_cel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxt_fone
            // 
            this.mtxt_fone.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_fone.Location = new System.Drawing.Point(456, 487);
            this.mtxt_fone.Mask = "00000 - 0000";
            this.mtxt_fone.Name = "mtxt_fone";
            this.mtxt_fone.Size = new System.Drawing.Size(142, 35);
            this.mtxt_fone.TabIndex = 20;
            this.mtxt_fone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_.Location = new System.Drawing.Point(57, 175);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(598, 30);
            this.lbl_.TabIndex = 22;
            this.lbl_.Text = "_________________________________________________________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btn_consulta);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_alterar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 38);
            this.panel1.TabIndex = 23;
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_consulta.FlatAppearance.BorderSize = 0;
            this.btn_consulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consulta.Image = global::TCM.Properties.Resources.icons8_search_961;
            this.btn_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta.Location = new System.Drawing.Point(0, -1);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(155, 39);
            this.btn_consulta.TabIndex = 24;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salvar.Image = global::TCM.Properties.Resources.icons8_save_602;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(149, -1);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(145, 39);
            this.btn_salvar.TabIndex = 25;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_alterar.Image = global::TCM.Properties.Resources.icons8_change_601;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(291, 0);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(139, 39);
            this.btn_alterar.TabIndex = 26;
            this.btn_alterar.Text = "Aterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.Image = global::TCM.Properties.Resources.icons8_delete_643;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(429, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(154, 39);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_excluir.Image = global::TCM.Properties.Resources.icons8_delete_bin_502;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(581, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(150, 39);
            this.btn_excluir.TabIndex = 28;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rdb_inativo);
            this.gb_status.Controls.Add(this.rdb_ativo);
            this.gb_status.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_status.Location = new System.Drawing.Point(78, 208);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(562, 65);
            this.gb_status.TabIndex = 24;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status do cliente ";
            // 
            // rdb_inativo
            // 
            this.rdb_inativo.AutoSize = true;
            this.rdb_inativo.Location = new System.Drawing.Point(334, 27);
            this.rdb_inativo.Name = "rdb_inativo";
            this.rdb_inativo.Size = new System.Drawing.Size(96, 32);
            this.rdb_inativo.TabIndex = 1;
            this.rdb_inativo.Text = "inativo";
            this.rdb_inativo.UseVisualStyleBackColor = true;
            // 
            // rdb_ativo
            // 
            this.rdb_ativo.AutoSize = true;
            this.rdb_ativo.Checked = true;
            this.rdb_ativo.Location = new System.Drawing.Point(239, 27);
            this.rdb_ativo.Name = "rdb_ativo";
            this.rdb_ativo.Size = new System.Drawing.Size(78, 32);
            this.rdb_ativo.TabIndex = 0;
            this.rdb_ativo.TabStop = true;
            this.rdb_ativo.Text = "ativo";
            this.rdb_ativo.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.mtxt_fone);
            this.Controls.Add(this.mtxt_cel);
            this.Controls.Add(this.lbl_fone);
            this.Controls.Add(this.lbl_cel);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.rdb_masc);
            this.Controls.Add(this.rdb_fem);
            this.Controls.Add(this.lbl_s);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.lbl_pesquisa);
            this.Name = "Cliente";
            this.Size = new System.Drawing.Size(731, 610);
            this.panel1.ResumeLayout(false);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.RadioButton rdb_fem;
        private System.Windows.Forms.RadioButton rdb_masc;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_cel;
        private System.Windows.Forms.Label lbl_fone;
        private System.Windows.Forms.MaskedTextBox mtxt_cel;
        private System.Windows.Forms.MaskedTextBox mtxt_fone;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rdb_inativo;
        private System.Windows.Forms.RadioButton rdb_ativo;
    }
}
