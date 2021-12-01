
namespace TCM
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.p_cima = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.lbl_cod_serviço = new System.Windows.Forms.Label();
            this.txt_cod_serviço = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.mtxt_data_saida = new System.Windows.Forms.MaskedTextBox();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.txt_comp = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.mtxt_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.p_cima.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_cima
            // 
            this.p_cima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.p_cima.Controls.Add(this.btn_excluir);
            this.p_cima.Controls.Add(this.btn_consultar);
            this.p_cima.Controls.Add(this.btn_cancelar);
            this.p_cima.Controls.Add(this.btn_cadastrar);
            this.p_cima.Controls.Add(this.btn_alterar);
            this.p_cima.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_cima.Location = new System.Drawing.Point(0, 0);
            this.p_cima.Name = "p_cima";
            this.p_cima.Size = new System.Drawing.Size(731, 39);
            this.p_cima.TabIndex = 0;
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
            this.btn_excluir.Image = global::TCM.Properties.Resources.icons8_delete_bin_507;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(592, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(139, 41);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click_1);
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_consultar.Image = global::TCM.Properties.Resources.icons8_search_966;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.Location = new System.Drawing.Point(0, 0);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(154, 39);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
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
            this.btn_cancelar.Image = global::TCM.Properties.Resources.icons8_delete_648;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(448, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(144, 39);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(154, 0);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(160, 39);
            this.btn_cadastrar.TabIndex = 2;
            this.btn_cadastrar.Text = "Finalizar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
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
            this.btn_alterar.Image = global::TCM.Properties.Resources.icons8_change_606;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(314, 0);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(134, 39);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod.Location = new System.Drawing.Point(64, 130);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(176, 30);
            this.lbl_cod.TabIndex = 1;
            this.lbl_cod.Text = "Codigo delivery";
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod.Location = new System.Drawing.Point(269, 128);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(71, 35);
            this.txt_cod.TabIndex = 2;
            // 
            // lbl_cod_serviço
            // 
            this.lbl_cod_serviço.AutoSize = true;
            this.lbl_cod_serviço.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod_serviço.Location = new System.Drawing.Point(367, 128);
            this.lbl_cod_serviço.Name = "lbl_cod_serviço";
            this.lbl_cod_serviço.Size = new System.Drawing.Size(199, 30);
            this.lbl_cod_serviço.TabIndex = 3;
            this.lbl_cod_serviço.Text = "Codigo do serviço";
            // 
            // txt_cod_serviço
            // 
            this.txt_cod_serviço.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod_serviço.Location = new System.Drawing.Point(572, 125);
            this.txt_cod_serviço.Name = "txt_cod_serviço";
            this.txt_cod_serviço.Size = new System.Drawing.Size(87, 35);
            this.txt_cod_serviço.TabIndex = 4;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data.Location = new System.Drawing.Point(380, 191);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(154, 30);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "Data de saida";
            // 
            // mtxt_data_saida
            // 
            this.mtxt_data_saida.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_data_saida.Location = new System.Drawing.Point(542, 189);
            this.mtxt_data_saida.Mask = "00/00/0000";
            this.mtxt_data_saida.Name = "mtxt_data_saida";
            this.mtxt_data_saida.Size = new System.Drawing.Size(117, 35);
            this.mtxt_data_saida.TabIndex = 7;
            this.mtxt_data_saida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_comp.Location = new System.Drawing.Point(64, 424);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(159, 30);
            this.lbl_comp.TabIndex = 8;
            this.lbl_comp.Text = "Complemento";
            // 
            // txt_comp
            // 
            this.txt_comp.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_comp.Location = new System.Drawing.Point(227, 424);
            this.txt_comp.Name = "txt_comp";
            this.txt_comp.Size = new System.Drawing.Size(430, 35);
            this.txt_comp.TabIndex = 9;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.Location = new System.Drawing.Point(64, 252);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(196, 30);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "Nome de retirada";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(275, 250);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(390, 35);
            this.txt_nome.TabIndex = 11;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bairro.Location = new System.Drawing.Point(64, 368);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(76, 30);
            this.lbl_bairro.TabIndex = 12;
            this.lbl_bairro.Text = "Bairro";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bairro.Location = new System.Drawing.Point(154, 366);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(213, 35);
            this.txt_bairro.TabIndex = 13;
            // 
            // txt_end
            // 
            this.txt_end.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_end.Location = new System.Drawing.Point(188, 309);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(260, 35);
            this.txt_end.TabIndex = 14;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_end.Location = new System.Drawing.Point(64, 311);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(109, 30);
            this.lbl_end.TabIndex = 15;
            this.lbl_end.Text = "Endereço";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor.Location = new System.Drawing.Point(444, 489);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(68, 30);
            this.lbl_valor.TabIndex = 18;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_n.Location = new System.Drawing.Point(530, 309);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(127, 35);
            this.txt_n.TabIndex = 19;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cep.Location = new System.Drawing.Point(463, 365);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_cep.Size = new System.Drawing.Size(53, 30);
            this.lbl_cep.TabIndex = 22;
            this.lbl_cep.Text = "CEP";
            // 
            // mtxt_cep
            // 
            this.mtxt_cep.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cep.Location = new System.Drawing.Point(532, 361);
            this.mtxt_cep.Mask = "00000 - 000";
            this.mtxt_cep.Name = "mtxt_cep";
            this.mtxt_cep.Size = new System.Drawing.Size(127, 35);
            this.mtxt_cep.TabIndex = 23;
            this.mtxt_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpf.Location = new System.Drawing.Point(66, 191);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(157, 30);
            this.lbl_cpf.TabIndex = 17;
            this.lbl_cpf.Text = "Cpf do cliente";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cpf.Location = new System.Drawing.Point(227, 189);
            this.mtxt_cpf.Mask = "000.000.000.00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(142, 35);
            this.mtxt_cpf.TabIndex = 24;
            this.mtxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(478, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "N°";
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor.Location = new System.Drawing.Point(518, 487);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(139, 35);
            this.txt_valor.TabIndex = 19;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.mtxt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_comp);
            this.Controls.Add(this.lbl_comp);
            this.Controls.Add(this.mtxt_data_saida);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_cod_serviço);
            this.Controls.Add(this.lbl_cod_serviço);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.p_cima);
            this.Name = "Delivery";
            this.Size = new System.Drawing.Size(731, 610);
            this.p_cima.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_cima;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label lbl_cod_serviço;
        private System.Windows.Forms.TextBox txt_cod_serviço;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.MaskedTextBox mtxt_data_saida;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.TextBox txt_comp;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.MaskedTextBox mtxt_cep;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_valor;
    }
}
