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
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();


        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            inicio.Controls.Clear();
            Inicio userInicio = new Inicio();
            inicio.Controls.Add(userInicio);
            //Deixa o UserControl visivel ou não

        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            inicio.Controls.Clear();
            Cliente userCliente = new Cliente();
            inicio.Controls.Add(userCliente);

        }

        private void btn_pets_Click(object sender, EventArgs e)
        {
            inicio.Controls.Clear();
            Pets userPet = new Pets();
            inicio.Controls.Add(userPet);

        }

        private void btn_serviço_Click(object sender, EventArgs e)
        {
            inicio.Controls.Clear();
            Serviços userServico = new Serviços();
            inicio.Controls.Add(userServico);

        }
        private void btn_delivery_Click(object sender, EventArgs e)
        {
            inicio.Controls.Clear();
            Delivery userDelivery = new Delivery();
            inicio.Controls.Add(userDelivery);
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            inicio.Controls.Clear();
            Finalizar userFinalizar = new Finalizar();
            inicio.Controls.Add(userFinalizar);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbl_usuario_logado.Text = Login.usuario;
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
