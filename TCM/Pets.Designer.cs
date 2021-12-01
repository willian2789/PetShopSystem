
namespace TCM
{
    partial class Pets
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
            this.lbl__cod_dono = new System.Windows.Forms.Label();
            this.txt_cod_dono = new System.Windows.Forms.TextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.lbl_raca = new System.Windows.Forms.Label();
            this.txt_raca = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_especie = new System.Windows.Forms.Label();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_porte = new System.Windows.Forms.Label();
            this.rdb_p = new System.Windows.Forms.RadioButton();
            this.rdb_m = new System.Windows.Forms.RadioButton();
            this.rdb_g = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_canelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_nome_pet = new System.Windows.Forms.Label();
            this.txt_nome_pet = new System.Windows.Forms.TextBox();
            this.cb_fem = new System.Windows.Forms.CheckBox();
            this.cb_masc = new System.Windows.Forms.CheckBox();
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
            this.lbl_pesquisa.Location = new System.Drawing.Point(88, 140);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(223, 30);
            this.lbl_pesquisa.TabIndex = 0;
            this.lbl_pesquisa.Text = "Pesquisa por código";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisa.Location = new System.Drawing.Point(315, 140);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(313, 35);
            this.txt_pesquisa.TabIndex = 1;
            // 
            // lbl__cod_dono
            // 
            this.lbl__cod_dono.AutoSize = true;
            this.lbl__cod_dono.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl__cod_dono.Location = new System.Drawing.Point(310, 325);
            this.lbl__cod_dono.Name = "lbl__cod_dono";
            this.lbl__cod_dono.Size = new System.Drawing.Size(191, 30);
            this.lbl__cod_dono.TabIndex = 2;
            this.lbl__cod_dono.Text = "Código do dono :";
            // 
            // txt_cod_dono
            // 
            this.txt_cod_dono.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod_dono.Location = new System.Drawing.Point(505, 325);
            this.txt_cod_dono.Name = "txt_cod_dono";
            this.txt_cod_dono.Size = new System.Drawing.Size(106, 35);
            this.txt_cod_dono.TabIndex = 3;
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod.Location = new System.Drawing.Point(93, 325);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(99, 30);
            this.lbl_cod.TabIndex = 4;
            this.lbl_cod.Text = "Código :";
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod.Location = new System.Drawing.Point(198, 325);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(97, 35);
            this.txt_cod.TabIndex = 5;
            // 
            // lbl_raca
            // 
            this.lbl_raca.AutoSize = true;
            this.lbl_raca.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_raca.Location = new System.Drawing.Point(94, 386);
            this.lbl_raca.Name = "lbl_raca";
            this.lbl_raca.Size = new System.Drawing.Size(74, 30);
            this.lbl_raca.TabIndex = 6;
            this.lbl_raca.Text = "Raça :";
            // 
            // txt_raca
            // 
            this.txt_raca.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_raca.Location = new System.Drawing.Point(174, 381);
            this.txt_raca.Name = "txt_raca";
            this.txt_raca.Size = new System.Drawing.Size(190, 35);
            this.txt_raca.TabIndex = 7;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpf.Location = new System.Drawing.Point(93, 452);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(156, 30);
            this.lbl_cpf.TabIndex = 8;
            this.lbl_cpf.Text = "CPF do dono :";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cpf.Location = new System.Drawing.Point(250, 450);
            this.mtxt_cpf.Mask = "000.000.000 - 00";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(161, 35);
            this.mtxt_cpf.TabIndex = 9;
            this.mtxt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_especie
            // 
            this.lbl_especie.AutoSize = true;
            this.lbl_especie.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_especie.Location = new System.Drawing.Point(383, 381);
            this.lbl_especie.Name = "lbl_especie";
            this.lbl_especie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_especie.Size = new System.Drawing.Size(102, 30);
            this.lbl_especie.TabIndex = 12;
            this.lbl_especie.Text = "Espécie :";
            // 
            // txt_especie
            // 
            this.txt_especie.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_especie.Location = new System.Drawing.Point(482, 378);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(146, 35);
            this.txt_especie.TabIndex = 13;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sexo.Location = new System.Drawing.Point(427, 449);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(74, 30);
            this.lbl_sexo.TabIndex = 14;
            this.lbl_sexo.Text = "Sexo :";
            // 
            // lbl_porte
            // 
            this.lbl_porte.AutoSize = true;
            this.lbl_porte.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_porte.Location = new System.Drawing.Point(93, 508);
            this.lbl_porte.Name = "lbl_porte";
            this.lbl_porte.Size = new System.Drawing.Size(190, 30);
            this.lbl_porte.TabIndex = 15;
            this.lbl_porte.Text = "Porte do animal :";
            // 
            // rdb_p
            // 
            this.rdb_p.AutoSize = true;
            this.rdb_p.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_p.Location = new System.Drawing.Point(289, 504);
            this.rdb_p.Name = "rdb_p";
            this.rdb_p.Size = new System.Drawing.Size(122, 34);
            this.rdb_p.TabIndex = 18;
            this.rdb_p.TabStop = true;
            this.rdb_p.Text = "Pequeno";
            this.rdb_p.UseVisualStyleBackColor = true;
            // 
            // rdb_m
            // 
            this.rdb_m.AutoSize = true;
            this.rdb_m.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_m.Location = new System.Drawing.Point(417, 504);
            this.rdb_m.Name = "rdb_m";
            this.rdb_m.Size = new System.Drawing.Size(97, 34);
            this.rdb_m.TabIndex = 19;
            this.rdb_m.TabStop = true;
            this.rdb_m.Text = "Médio";
            this.rdb_m.UseVisualStyleBackColor = true;
            // 
            // rdb_g
            // 
            this.rdb_g.AutoSize = true;
            this.rdb_g.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_g.Location = new System.Drawing.Point(521, 504);
            this.rdb_g.Name = "rdb_g";
            this.rdb_g.Size = new System.Drawing.Size(107, 34);
            this.rdb_g.TabIndex = 20;
            this.rdb_g.TabStop = true;
            this.rdb_g.Text = "Grande";
            this.rdb_g.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(47, 176);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(625, 30);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "____________________________________________________________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btn_consulta);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_alterar);
            this.panel1.Controls.Add(this.btn_canelar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 39);
            this.panel1.TabIndex = 22;
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
            this.btn_consulta.Image = global::TCM.Properties.Resources.icons8_search_962;
            this.btn_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta.Location = new System.Drawing.Point(0, -2);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(144, 41);
            this.btn_consulta.TabIndex = 23;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click_1);
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
            this.btn_salvar.Image = global::TCM.Properties.Resources.icons8_save_603;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(145, -2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(145, 41);
            this.btn_salvar.TabIndex = 24;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
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
            this.btn_alterar.Image = global::TCM.Properties.Resources.icons8_change_602;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(287, -2);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(149, 41);
            this.btn_alterar.TabIndex = 25;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_canelar
            // 
            this.btn_canelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_canelar.FlatAppearance.BorderSize = 0;
            this.btn_canelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_canelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_canelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_canelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canelar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_canelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_canelar.Image = global::TCM.Properties.Resources.icons8_delete_644;
            this.btn_canelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_canelar.Location = new System.Drawing.Point(431, -2);
            this.btn_canelar.Name = "btn_canelar";
            this.btn_canelar.Size = new System.Drawing.Size(155, 41);
            this.btn_canelar.TabIndex = 26;
            this.btn_canelar.Text = "Cancelar";
            this.btn_canelar.UseVisualStyleBackColor = true;
            this.btn_canelar.Click += new System.EventHandler(this.btn_canelar_Click);
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
            this.btn_excluir.Image = global::TCM.Properties.Resources.icons8_delete_bin_503;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(582, -2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(149, 41);
            this.btn_excluir.TabIndex = 27;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click_1);
            // 
            // lbl_nome_pet
            // 
            this.lbl_nome_pet.AutoSize = true;
            this.lbl_nome_pet.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome_pet.Location = new System.Drawing.Point(93, 283);
            this.lbl_nome_pet.Name = "lbl_nome_pet";
            this.lbl_nome_pet.Size = new System.Drawing.Size(161, 30);
            this.lbl_nome_pet.TabIndex = 23;
            this.lbl_nome_pet.Text = "Nome do Pet :";
            // 
            // txt_nome_pet
            // 
            this.txt_nome_pet.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome_pet.Location = new System.Drawing.Point(250, 278);
            this.txt_nome_pet.Name = "txt_nome_pet";
            this.txt_nome_pet.Size = new System.Drawing.Size(361, 35);
            this.txt_nome_pet.TabIndex = 24;
            // 
            // cb_fem
            // 
            this.cb_fem.AutoSize = true;
            this.cb_fem.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_fem.Location = new System.Drawing.Point(507, 450);
            this.cb_fem.Name = "cb_fem";
            this.cb_fem.Size = new System.Drawing.Size(43, 34);
            this.cb_fem.TabIndex = 25;
            this.cb_fem.Text = "F";
            this.cb_fem.UseVisualStyleBackColor = true;
            // 
            // cb_masc
            // 
            this.cb_masc.AutoSize = true;
            this.cb_masc.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_masc.Location = new System.Drawing.Point(575, 449);
            this.cb_masc.Name = "cb_masc";
            this.cb_masc.Size = new System.Drawing.Size(53, 34);
            this.cb_masc.TabIndex = 26;
            this.cb_masc.Text = "M";
            this.cb_masc.UseVisualStyleBackColor = true;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rdb_inativo);
            this.gb_status.Controls.Add(this.rdb_ativo);
            this.gb_status.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_status.Location = new System.Drawing.Point(94, 209);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(517, 52);
            this.gb_status.TabIndex = 27;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status do pet";
            // 
            // rdb_inativo
            // 
            this.rdb_inativo.AutoSize = true;
            this.rdb_inativo.Location = new System.Drawing.Point(276, 16);
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
            this.rdb_ativo.Location = new System.Drawing.Point(192, 16);
            this.rdb_ativo.Name = "rdb_ativo";
            this.rdb_ativo.Size = new System.Drawing.Size(78, 32);
            this.rdb_ativo.TabIndex = 0;
            this.rdb_ativo.TabStop = true;
            this.rdb_ativo.Text = "ativo";
            this.rdb_ativo.UseVisualStyleBackColor = true;
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.cb_masc);
            this.Controls.Add(this.cb_fem);
            this.Controls.Add(this.txt_nome_pet);
            this.Controls.Add(this.lbl_nome_pet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.rdb_g);
            this.Controls.Add(this.rdb_m);
            this.Controls.Add(this.rdb_p);
            this.Controls.Add(this.lbl_porte);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.txt_especie);
            this.Controls.Add(this.lbl_especie);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_raca);
            this.Controls.Add(this.lbl_raca);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.txt_cod_dono);
            this.Controls.Add(this.lbl__cod_dono);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.lbl_pesquisa);
            this.Name = "Pets";
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
        private System.Windows.Forms.Label lbl__cod_dono;
        private System.Windows.Forms.TextBox txt_cod_dono;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label lbl_raca;
        private System.Windows.Forms.TextBox txt_raca;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
        private System.Windows.Forms.Label lbl_especie;
        private System.Windows.Forms.TextBox txt_especie;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_porte;
        private System.Windows.Forms.RadioButton rdb_p;
        private System.Windows.Forms.RadioButton rdb_m;
        private System.Windows.Forms.RadioButton rdb_g;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_canelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lbl_nome_pet;
        private System.Windows.Forms.TextBox txt_nome_pet;
        private System.Windows.Forms.CheckBox cb_fem;
        private System.Windows.Forms.CheckBox cb_masc;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rdb_inativo;
        private System.Windows.Forms.RadioButton rdb_ativo;
    }
}
