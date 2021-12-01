
namespace TCM
{
    partial class Finalizar
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
            this.p_cima = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_pag = new System.Windows.Forms.Label();
            this.rdb_deb = new System.Windows.Forms.RadioButton();
            this.rdb_cred = new System.Windows.Forms.RadioButton();
            this.rdb_pix = new System.Windows.Forms.RadioButton();
            this.rdb_din = new System.Windows.Forms.RadioButton();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_cod_s = new System.Windows.Forms.TextBox();
            this.lbl_cod_s = new System.Windows.Forms.Label();
            this.dgv_pag = new System.Windows.Forms.DataGridView();
            this.p_cima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pag)).BeginInit();
            this.SuspendLayout();
            // 
            // p_cima
            // 
            this.p_cima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.p_cima.Controls.Add(this.btn_excluir);
            this.p_cima.Controls.Add(this.btn_consultar);
            this.p_cima.Controls.Add(this.btn_cancelar);
            this.p_cima.Controls.Add(this.btn_finalizar);
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
            this.btn_excluir.Image = global::TCM.Properties.Resources.icons8_delete_bin_508;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(600, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(131, 39);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
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
            this.btn_consultar.Image = global::TCM.Properties.Resources.icons8_search_967;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.Location = new System.Drawing.Point(0, 0);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(158, 39);
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
            this.btn_cancelar.Image = global::TCM.Properties.Resources.icons8_delete_649;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(455, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(146, 39);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_finalizar.Image = global::TCM.Properties.Resources.icons8_cash_register_603;
            this.btn_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finalizar.Location = new System.Drawing.Point(158, 0);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(164, 39);
            this.btn_finalizar.TabIndex = 2;
            this.btn_finalizar.Text = "Finalizar";
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
            this.btn_alterar.Image = global::TCM.Properties.Resources.icons8_change_607;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(322, 0);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(133, 39);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor.Location = new System.Drawing.Point(412, 160);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(68, 30);
            this.lbl_valor.TabIndex = 4;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_pag
            // 
            this.lbl_pag.AutoSize = true;
            this.lbl_pag.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pag.Location = new System.Drawing.Point(74, 370);
            this.lbl_pag.Name = "lbl_pag";
            this.lbl_pag.Size = new System.Drawing.Size(247, 30);
            this.lbl_pag.TabIndex = 5;
            this.lbl_pag.Text = "Forma de pagamento :";
            // 
            // rdb_deb
            // 
            this.rdb_deb.AutoSize = true;
            this.rdb_deb.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_deb.Location = new System.Drawing.Point(240, 424);
            this.rdb_deb.Name = "rdb_deb";
            this.rdb_deb.Size = new System.Drawing.Size(94, 32);
            this.rdb_deb.TabIndex = 6;
            this.rdb_deb.TabStop = true;
            this.rdb_deb.Text = "Débito";
            this.rdb_deb.UseVisualStyleBackColor = true;
            // 
            // rdb_cred
            // 
            this.rdb_cred.AutoSize = true;
            this.rdb_cred.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_cred.Location = new System.Drawing.Point(116, 424);
            this.rdb_cred.Name = "rdb_cred";
            this.rdb_cred.Size = new System.Drawing.Size(99, 32);
            this.rdb_cred.TabIndex = 7;
            this.rdb_cred.TabStop = true;
            this.rdb_cred.Text = "Crédito";
            this.rdb_cred.UseVisualStyleBackColor = true;
            // 
            // rdb_pix
            // 
            this.rdb_pix.AutoSize = true;
            this.rdb_pix.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_pix.Location = new System.Drawing.Point(483, 424);
            this.rdb_pix.Name = "rdb_pix";
            this.rdb_pix.Size = new System.Drawing.Size(59, 32);
            this.rdb_pix.TabIndex = 8;
            this.rdb_pix.TabStop = true;
            this.rdb_pix.Text = "Pix";
            this.rdb_pix.UseVisualStyleBackColor = true;
            // 
            // rdb_din
            // 
            this.rdb_din.AutoSize = true;
            this.rdb_din.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_din.Location = new System.Drawing.Point(355, 424);
            this.rdb_din.Name = "rdb_din";
            this.rdb_din.Size = new System.Drawing.Size(112, 32);
            this.rdb_din.TabIndex = 9;
            this.rdb_din.TabStop = true;
            this.rdb_din.Text = "Dinheiro";
            this.rdb_din.UseVisualStyleBackColor = true;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_valor.Location = new System.Drawing.Point(498, 158);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 35);
            this.txt_valor.TabIndex = 13;
            // 
            // txt_cod_s
            // 
            this.txt_cod_s.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cod_s.Location = new System.Drawing.Point(292, 158);
            this.txt_cod_s.Name = "txt_cod_s";
            this.txt_cod_s.Size = new System.Drawing.Size(100, 35);
            this.txt_cod_s.TabIndex = 10;
            this.txt_cod_s.TextChanged += new System.EventHandler(this.txt_cod_s_TextChanged);
            // 
            // lbl_cod_s
            // 
            this.lbl_cod_s.AutoSize = true;
            this.lbl_cod_s.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cod_s.Location = new System.Drawing.Point(74, 158);
            this.lbl_cod_s.Name = "lbl_cod_s";
            this.lbl_cod_s.Size = new System.Drawing.Size(199, 30);
            this.lbl_cod_s.TabIndex = 1;
            this.lbl_cod_s.Text = "Codigo do serviço";
            // 
            // dgv_pag
            // 
            this.dgv_pag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pag.Location = new System.Drawing.Point(74, 239);
            this.dgv_pag.Name = "dgv_pag";
            this.dgv_pag.RowTemplate.Height = 25;
            this.dgv_pag.Size = new System.Drawing.Size(528, 95);
            this.dgv_pag.TabIndex = 14;
            // 
            // Finalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_pag);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_cod_s);
            this.Controls.Add(this.rdb_din);
            this.Controls.Add(this.rdb_pix);
            this.Controls.Add(this.rdb_cred);
            this.Controls.Add(this.rdb_deb);
            this.Controls.Add(this.lbl_pag);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_cod_s);
            this.Controls.Add(this.p_cima);
            this.Name = "Finalizar";
            this.Size = new System.Drawing.Size(731, 610);
            this.p_cima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_cima;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_pag;
        private System.Windows.Forms.RadioButton rdb_deb;
        private System.Windows.Forms.RadioButton rdb_cred;
        private System.Windows.Forms.RadioButton rdb_pix;
        private System.Windows.Forms.RadioButton rdb_din;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_cod_s;
        private System.Windows.Forms.Label lbl_cod_s;
        private System.Windows.Forms.DataGridView dgv_pag;
    }
}
