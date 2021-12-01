
namespace TCM
{
    partial class Tela_de_Splash
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
            this.components = new System.ComponentModel.Container();
            this.ptb_animal = new System.Windows.Forms.PictureBox();
            this.pg_carrega = new System.Windows.Forms.ProgressBar();
            this.lbl_porcentagem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_animal)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_animal
            // 
            this.ptb_animal.Image = global::TCM.Properties.Resources.Logo_cliente;
            this.ptb_animal.Location = new System.Drawing.Point(-1, -1);
            this.ptb_animal.Name = "ptb_animal";
            this.ptb_animal.Size = new System.Drawing.Size(1011, 305);
            this.ptb_animal.TabIndex = 0;
            this.ptb_animal.TabStop = false;
            // 
            // pg_carrega
            // 
            this.pg_carrega.Location = new System.Drawing.Point(-1, 281);
            this.pg_carrega.Name = "pg_carrega";
            this.pg_carrega.Size = new System.Drawing.Size(921, 44);
            this.pg_carrega.TabIndex = 1;
            // 
            // lbl_porcentagem
            // 
            this.lbl_porcentagem.AutoSize = true;
            this.lbl_porcentagem.Font = new System.Drawing.Font("Ebrima", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_porcentagem.Location = new System.Drawing.Point(918, 281);
            this.lbl_porcentagem.Name = "lbl_porcentagem";
            this.lbl_porcentagem.Size = new System.Drawing.Size(88, 36);
            this.lbl_porcentagem.TabIndex = 2;
            this.lbl_porcentagem.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tela_de_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 319);
            this.Controls.Add(this.lbl_porcentagem);
            this.Controls.Add(this.pg_carrega);
            this.Controls.Add(this.ptb_animal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_de_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_de_Splash";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_animal;
        private System.Windows.Forms.ProgressBar pg_carrega;
        private System.Windows.Forms.Label lbl_porcentagem;
        private System.Windows.Forms.Timer timer1;
    }
}