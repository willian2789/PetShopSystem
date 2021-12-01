using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class Tela_de_Splash : Form
    {
        public Tela_de_Splash()
        {
            InitializeComponent();
            // Componente progressbar iniciando até 100%
            pg_carrega.Maximum = 100;
            //Start do tempo
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pg_carrega.Value < 100)
            {
                //Carrega a parte verde duas vezes
                pg_carrega.Value = pg_carrega.Value + 2;
                //Faz a leitura da label até 100
                lbl_porcentagem.Text = pg_carrega.Value.ToString() + "%";
            }
            else
            {
                //após terminar de carregar
                lbl_porcentagem.Text = pg_carrega.Value.ToString();
                //Para o tempo mq foi iniciado
                timer1.Stop();
                //Fecha a tela de splash
                this.Hide();
                //Abre a tela de login
                Login login = new Login();
                login.Show();
            }
        }
    }
}
