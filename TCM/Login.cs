using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class Login : Form
    {
        // criando a string de conexão com o banco
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();

        }

        public static string usuario;
        public static string  codUsuario;

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            DataTable dados = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_funcionario where ds_Login=@user and ds_Senha=@senha", con.ConectarBD()); //Ligação com uma parte especifica do Banco de dados
            da.SelectCommand.Parameters.AddWithValue("@user", txt_usuario.Text); //Lê o que foi escrito na TextBox
            da.SelectCommand.Parameters.AddWithValue("@senha", txt_senha.Text); //Lê o que foi escrito na TextBox
            da.Fill(dados); //Puxa dos dados do banco



            if (dados.Rows.Count == 0) //Se não tiver nada escrito (0 caracteres)
            {
                MessageBox.Show("Usuario/Senha invalidos");
            }
            else
            {
                usuario = dados.Rows[0]["nm_Funcionario"].ToString();
                codUsuario = dados.Rows[0]["cd_Funcionario"].ToString();
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.Show();

            }

        }
    }
}
