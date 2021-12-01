
namespace TCM
{
    partial class Serviços
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serviços));
            this.lbl_data = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_cd = new System.Windows.Forms.Label();
            this.txt_cod_cli = new System.Windows.Forms.TextBox();
            this.lbl_nm = new System.Windows.Forms.Label();
            this.txt_nm_cli = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dgv_servico = new System.Windows.Forms.DataGridView();
            this.lbl_cod_func = new System.Windows.Forms.Label();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_cpf_cli = new System.Windows.Forms.MaskedTextBox();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.lbl_cod_pedido = new System.Windows.Forms.Label();
            this.lbl_cod_espcial = new System.Windows.Forms.Label();
            this.cb_servicos = new System.Windows.Forms.ComboBox();
            this.lbl_serviços = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_qt = new System.Windows.Forms.TextBox();
            this.lbl_qt = new System.Windows.Forms.Label();
            this.txt_valor_serv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data.Location = new System.Drawing.Point(456, 119);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(68, 30);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "Data ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_consulta);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_finalizar);
            this.panel1.Controls.Add(this.btn_alterar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 39);
            this.panel1.TabIndex = 27;
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
            this.btn_cancelar.Image = global::TCM.Properties.Resources.icons8_delete_645;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(445, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 41);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_consulta.Image = global::TCM.Properties.Resources.icons8_search_963;
            this.btn_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta.Location = new System.Drawing.Point(0, 0);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(145, 41);
            this.btn_consulta.TabIndex = 28;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
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
            this.btn_excluir.Image = global::TCM.Properties.Resources.icons8_delete_bin_504;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(596, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(135, 41);
            this.btn_excluir.TabIndex = 31;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatAppearance.BorderSize = 0;
            this.btn_finalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_finalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_finalizar.Image")));
            this.btn_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finalizar.Location = new System.Drawing.Point(145, 0);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(137, 41);
            this.btn_finalizar.TabIndex = 29;
            this.btn_finalizar.Text = "Inserir";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
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
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(282, 0);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(163, 41);
            this.btn_alterar.TabIndex = 30;
            this.btn_alterar.Text = "Finalizar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_cd
            // 
            this.lbl_cd.AutoSize = true;
            this.lbl_cd.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cd.Location = new System.Drawing.Point(54, 170);
            this.lbl_cd.Name = "lbl_cd";
            this.lbl_cd.Size = new System.Drawing.Size(195, 30);
            this.lbl_cd.TabIndex = 30;
            this.lbl_cd.Text = "Codigo do cliente";
            // 
            // txt_cod_cli
            // 
            this.txt_cod_cli.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod_cli.Location = new System.Drawing.Point(260, 174);
            this.txt_cod_cli.Name = "txt_cod_cli";
            this.txt_cod_cli.Size = new System.Drawing.Size(71, 35);
            this.txt_cod_cli.TabIndex = 31;
            // 
            // lbl_nm
            // 
            this.lbl_nm.AutoSize = true;
            this.lbl_nm.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nm.Location = new System.Drawing.Point(341, 179);
            this.lbl_nm.Name = "lbl_nm";
            this.lbl_nm.Size = new System.Drawing.Size(85, 30);
            this.lbl_nm.TabIndex = 32;
            this.lbl_nm.Text = "Cliente";
            // 
            // txt_nm_cli
            // 
            this.txt_nm_cli.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nm_cli.Location = new System.Drawing.Point(432, 177);
            this.txt_nm_cli.Name = "txt_nm_cli";
            this.txt_nm_cli.Size = new System.Drawing.Size(223, 35);
            this.txt_nm_cli.TabIndex = 33;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor.Location = new System.Drawing.Point(54, 293);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(68, 30);
            this.lbl_valor.TabIndex = 34;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor.Location = new System.Drawing.Point(132, 291);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(86, 35);
            this.txt_valor.TabIndex = 35;
            // 
            // dgv_servico
            // 
            this.dgv_servico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servico.Location = new System.Drawing.Point(59, 390);
            this.dgv_servico.Name = "dgv_servico";
            this.dgv_servico.RowTemplate.Height = 25;
            this.dgv_servico.Size = new System.Drawing.Size(604, 150);
            this.dgv_servico.TabIndex = 37;
            // 
            // lbl_cod_func
            // 
            this.lbl_cod_func.AutoSize = true;
            this.lbl_cod_func.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod_func.Location = new System.Drawing.Point(58, 65);
            this.lbl_cod_func.Name = "lbl_cod_func";
            this.lbl_cod_func.Size = new System.Drawing.Size(49, 30);
            this.lbl_cod_func.TabIndex = 39;
            this.lbl_cod_func.Text = "xxx";
            // 
            // lbl_dt
            // 
            this.lbl_dt.AutoSize = true;
            this.lbl_dt.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dt.ForeColor = System.Drawing.Color.Red;
            this.lbl_dt.Location = new System.Drawing.Point(530, 119);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(49, 30);
            this.lbl_dt.TabIndex = 40;
            this.lbl_dt.Text = "xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "CPF do cliente";
            // 
            // mtxt_cpf_cli
            // 
            this.mtxt_cpf_cli.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxt_cpf_cli.Location = new System.Drawing.Point(260, 119);
            this.mtxt_cpf_cli.Mask = "000.000.000-00";
            this.mtxt_cpf_cli.Name = "mtxt_cpf_cli";
            this.mtxt_cpf_cli.Size = new System.Drawing.Size(149, 35);
            this.mtxt_cpf_cli.TabIndex = 41;
            this.mtxt_cpf_cli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxt_cpf_cli.TextChanged += new System.EventHandler(this.mtxt_cpf_cli_TextChanged);
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pedido.Location = new System.Drawing.Point(260, 58);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(108, 37);
            this.lbl_pedido.TabIndex = 42;
            this.lbl_pedido.Text = "Pedido";
            // 
            // lbl_cod_pedido
            // 
            this.lbl_cod_pedido.AutoSize = true;
            this.lbl_cod_pedido.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_cod_pedido.Location = new System.Drawing.Point(374, 58);
            this.lbl_cod_pedido.Name = "lbl_cod_pedido";
            this.lbl_cod_pedido.Size = new System.Drawing.Size(62, 37);
            this.lbl_cod_pedido.TabIndex = 43;
            this.lbl_cod_pedido.Text = "xxx";
            // 
            // lbl_cod_espcial
            // 
            this.lbl_cod_espcial.AutoSize = true;
            this.lbl_cod_espcial.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod_espcial.Location = new System.Drawing.Point(59, 347);
            this.lbl_cod_espcial.Name = "lbl_cod_espcial";
            this.lbl_cod_espcial.Size = new System.Drawing.Size(49, 30);
            this.lbl_cod_espcial.TabIndex = 44;
            this.lbl_cod_espcial.Text = "xxx";
            // 
            // cb_servicos
            // 
            this.cb_servicos.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_servicos.FormattingEnabled = true;
            this.cb_servicos.Items.AddRange(new object[] {
            "Banho",
            "Tosa",
            "Banho e Tosa"});
            this.cb_servicos.Location = new System.Drawing.Point(191, 239);
            this.cb_servicos.Name = "cb_servicos";
            this.cb_servicos.Size = new System.Drawing.Size(140, 36);
            this.cb_servicos.TabIndex = 45;
            this.cb_servicos.SelectedIndexChanged += new System.EventHandler(this.cb_servicos_SelectedIndexChanged);
            // 
            // lbl_serviços
            // 
            this.lbl_serviços.AutoSize = true;
            this.lbl_serviços.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_serviços.Location = new System.Drawing.Point(51, 239);
            this.lbl_serviços.Name = "lbl_serviços";
            this.lbl_serviços.Size = new System.Drawing.Size(98, 30);
            this.lbl_serviços.TabIndex = 46;
            this.lbl_serviços.Text = "Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(451, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 47;
            this.label2.Text = "Valor total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Ebrima", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_total.Location = new System.Drawing.Point(595, 343);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(57, 36);
            this.lbl_total.TabIndex = 48;
            this.lbl_total.Text = "xxx";
            // 
            // txt_qt
            // 
            this.txt_qt.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_qt.Location = new System.Drawing.Point(569, 240);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(86, 35);
            this.txt_qt.TabIndex = 50;
            this.txt_qt.TextChanged += new System.EventHandler(this.txt_qt_TextChanged);
            // 
            // lbl_qt
            // 
            this.lbl_qt.AutoSize = true;
            this.lbl_qt.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_qt.Location = new System.Drawing.Point(423, 242);
            this.lbl_qt.Name = "lbl_qt";
            this.lbl_qt.Size = new System.Drawing.Size(135, 30);
            this.lbl_qt.TabIndex = 49;
            this.lbl_qt.Text = "Quantidade";
            // 
            // txt_valor_serv
            // 
            this.txt_valor_serv.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor_serv.Location = new System.Drawing.Point(569, 293);
            this.txt_valor_serv.Name = "txt_valor_serv";
            this.txt_valor_serv.Size = new System.Drawing.Size(86, 35);
            this.txt_valor_serv.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(409, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "Valor serviço";
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_valor_serv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_qt);
            this.Controls.Add(this.lbl_qt);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_serviços);
            this.Controls.Add(this.cb_servicos);
            this.Controls.Add(this.lbl_cod_espcial);
            this.Controls.Add(this.lbl_cod_pedido);
            this.Controls.Add(this.lbl_pedido);
            this.Controls.Add(this.mtxt_cpf_cli);
            this.Controls.Add(this.lbl_dt);
            this.Controls.Add(this.lbl_cod_func);
            this.Controls.Add(this.dgv_servico);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_nm_cli);
            this.Controls.Add(this.lbl_nm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cod_cli);
            this.Controls.Add(this.lbl_cd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_data);
            this.Name = "Serviços";
            this.Size = new System.Drawing.Size(731, 610);
            this.Load += new System.EventHandler(this.Serviços_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_cd;
        private System.Windows.Forms.TextBox txt_cod_cli;
        private System.Windows.Forms.Label lbl_nm;
        private System.Windows.Forms.TextBox txt_nm_cli;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DataGridView dgv_servico;
        private System.Windows.Forms.Label lbl_cod_func;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf_cli;
        private System.Windows.Forms.Label lbl_ppedido;
        private System.Windows.Forms.Label lbl_cod_pedido;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Label lbl_cod_espcial;
        private System.Windows.Forms.ComboBox cb_servicos;
        private System.Windows.Forms.Label lbl_serviços;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_qt;
        private System.Windows.Forms.Label lbl_qt;
        private System.Windows.Forms.TextBox txt_valor_serv;
        private System.Windows.Forms.Label label3;
    }
}
