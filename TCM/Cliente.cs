using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCM
{
    public partial class Cliente : UserControl
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Cliente()
        {
            InitializeComponent();
            cmd.Connection = con.ConectarBD();
        }

        private void limparCampos()
        {
            txt_pesquisa.Text = "";
            txt_cod.Text = "";
            txt_email.Text = "";
            txt_nome.Text = ""; 
            mtxt_cel.Text = "";
            mtxt_cpf.Text = "";
            mtxt_fone.Text = "";
            rdb_fem.Checked = false;
            rdb_masc.Checked = false;


        }

        //Metodo de consultar
        //Finalizado
        private void btn_consulta_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_Cliente  where cd_Cliente=@codigo_cli", con.ConectarBD());
            cmd.Parameters.AddWithValue("@codigo_cli", SqlDbType.Int).Value = txt_pesquisa.Text;

             if (txt_pesquisa.Text == "")
            {
                MessageBox.Show("Digite o Codigo do cliente");
            }
            con.ConectarBD();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == false)
            {
                MessageBox.Show("Cliente não cadastrado");
            }

            else
            {
                dr.Read();
                txt_cod.Text = dr["cd_Cliente"].ToString(); //Preenche a txt com o q esta escrito no sql
                txt_nome.Text = dr["nm_Cliente"].ToString();
                txt_email.Text = dr["email_Cliente"].ToString();
                mtxt_cel.Text = dr["no_FoneCel"].ToString();
                mtxt_cpf.Text = dr["cpf_Cliente"].ToString();
                mtxt_fone.Text = dr["no_FoneRes"].ToString();

                string sex = dr["sg_SexoCli"].ToString();

                if (sex == "M")
                {
                    rdb_masc.Checked = true;
                }
                else
                {
                    rdb_fem.Checked = true;
                }

                string status = dr["sg_StatusCli"].ToString();

                if (status == "True")
                {
                    rdb_ativo.Checked = true;
                }

                else
                {
                    rdb_inativo.Checked = true;
                }
            }
            con.DesConectarBD();
        }

            //Metodo cadastrar
            //Finalizado
            private void btn_salvar_Click(object sender, EventArgs e)
            { 
            // ver se os campos necessarios estão vazios
            if(txt_nome.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Nome");
                txt_nome.Focus();
                return;
               
            }
            if(mtxt_cpf.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o CPF");
                mtxt_cpf.Focus();
                return;
            }
            if (mtxt_cel.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Telefone");
                mtxt_cel.Focus();
                return;
            }
            else if (rdb_inativo.Checked)
            {
                MessageBox.Show("Para cadastrar um clienete ele precisa estar ativo");
            }
            else if (!rdb_fem.Checked && !rdb_masc.Checked)
            {
                MessageBox.Show("Obrigatorio informar o sexo");
            }
            else
            {
                char sexo;

                if (rdb_fem.Checked == true)
                {
                    sexo = 'F';
                }
                else
                {
                    sexo = 'M';
                }

                string st;

                if (rdb_ativo.Checked == true)
                {
                    st = "1";
                }
                else
                {
                    st = "0";
                }




                con.ConectarBD();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = "insert into tbl_Cliente(nm_Cliente,email_Cliente,cpf_Cliente,no_FoneCel,no_FoneRes,sg_SexoCli,sg_StatusCli)values(@n_cli,@email_cli,@cpf_cli,@cel_cli,@fone_cli,@sexo_cli,@sts);";


                    cmd.Parameters.AddWithValue("@n_cli", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@email_cli", txt_email.Text);
                    cmd.Parameters.AddWithValue("@cpf_cli", mtxt_cpf.Text);
                    cmd.Parameters.AddWithValue("@cel_cli", mtxt_cel.Text);
                    cmd.Parameters.AddWithValue("@fone_cli", mtxt_fone.Text);
                    cmd.Parameters.AddWithValue("@sexo_cli", sexo);
                    cmd.Parameters.AddWithValue("@sts", st);


                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();

                }


                //limpar
                limparCampos();

                MessageBox.Show("Cadastro realizado com sucesso");
                return;
            }
 
        }

       

        //Metodo de alterar
        //Finalizado
        private void btn_alterar_Click(object sender, EventArgs e)
        {
        
            //restrições para alterar
            if (txt_cod.Text == "")
            {
                MessageBox.Show("Para alterar o cadastro é necessario o Codigo");
                txt_cod.Focus();
                return;
            }
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Nome");
                txt_nome.Focus();
                return;

            }
            if (mtxt_cpf.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o CPF");
                mtxt_cpf.Focus();
                return;
            }
            if (mtxt_cel.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Telefone");
                mtxt_cel.Focus();
                return;
            }
            else if (!rdb_fem.Checked && !rdb_masc.Checked)
            {
                MessageBox.Show("Obrigatorio informar o sexo");
            }
            else
            {
                char sexo;

                if (rdb_fem.Checked == true)
                {
                    sexo = 'F';
                }
                else
                {
                    sexo = 'M';
                }

                string status;

                if(rdb_ativo.Checked == true)
                {
                    status = "1";
                }
                else
                {
                    status = "0";
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = "Update tbl_Cliente set nm_Cliente=@nome, email_Cliente=@email, cpf_Cliente=@cpf, no_FoneCel=@cel, no_FoneRes=@fone, sg_SexoCli=@sexo, sg_StatusCli=@st where cd_Cliente=@cod";


                    cmd.Parameters.AddWithValue("@cod", txt_cod.Text);
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@cpf", mtxt_cpf.Text);
                    cmd.Parameters.AddWithValue("@cel", mtxt_cel.Text);
                    cmd.Parameters.AddWithValue("@fone", mtxt_fone.Text);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@st", status);
                    
                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();
                }

                //limpar
                limparCampos();

                MessageBox.Show("Cadastro realizado com sucesso");
                return;
            }

        }

        //Limpa os campos 
        //Finalizado
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //Metodo de excluir
        //Finalizado
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (rdb_inativo.Checked)
            {
                MessageBox.Show("Para excluir um cadastro ele precisa estar ativo");
            }
            else
            {


                if (txt_cod.Text != "")
                {


                    string message = "Deseja realmente deletar o cadastro de " + txt_nome.Text + "?";
                    string caption = "Deletar cadastro";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    //Mostra mensagem de confirmação
                    result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    if (result == DialogResult.No)
                    {
                        //retorna a tela caso desista
                        return;
                    }
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = con.ConectarBD();
                        command.CommandText = "Delete from tbl_Cliente where cd_Cliente=@cod_excluir";

                        command.Parameters.AddWithValue("@cod_excluir", txt_cod.Text);

                        command.ExecuteNonQuery();

                    }
                    con.DesConectarBD();
                    limparCampos();
                    MessageBox.Show("Cadastro deletado com sucesso");
                }

                else
                {
                    MessageBox.Show("Consulte o cadastro antes de deletar");
                }
            }
        }

        
    }
}
