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
    public partial class Delivery : UserControl
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Delivery()
        {
            InitializeComponent();
        }

        //Metodo de limpar campos 
        //Finalizado
        private void limparCampos()
        {
            txt_cod.Text = "";
            txt_cod_serviço.Text = "";
            txt_comp.Text = "";
            txt_end.Text = "";
            txt_n.Text = "";
            txt_bairro.Text = "";
            txt_nome.Text = "";
            mtxt_cep.Text = "";
            mtxt_data_saida.Text = "";
            mtxt_cpf.Text = "";
            txt_valor.Text = "";
        }

        //Metodo de Consultar
        //Finalizado
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_Delivery  where cd_Delivery=@cod_delivery", con.ConectarBD());
            cmd.Parameters.AddWithValue("@cod_delivery", SqlDbType.Int).Value = txt_cod.Text;

            if (txt_cod.Text == "")
            {
                MessageBox.Show("Digite o Codigo do delivery");
            }
            con.ConectarBD();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == false)
            {
                MessageBox.Show("Delivery não cadastrado");
            }

            else
            {
                dr.Read();
                //Preenche a txt com o q esta escrito no sql
                txt_nome.Text = dr["nm_Retirada"].ToString();
                txt_cod_serviço.Text = dr["cd_Serviço"].ToString();
                mtxt_cpf.Text = dr["cpf_Cliente"].ToString();
                txt_end.Text = dr["nm_Logradouro"].ToString();
                txt_n.Text = dr["no_Logradouro"].ToString();
                txt_bairro.Text = dr["nm_Bairro"].ToString();
                txt_comp.Text = dr["ds_Complemento"].ToString();
                mtxt_cep.Text = dr["no_CEP"].ToString();
                mtxt_data_saida.Text = dr["dt_Saida"].ToString();
                txt_valor.Text = dr["vl_Delivery"].ToString();
                
            }
            con.DesConectarBD();

  

        }

        //Metodo de cadastrar
        //Finalizado
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_cod_serviço.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o código do serviço");
                txt_cod_serviço.Focus();
                return;
            }

            if (mtxt_data_saida.Text == "")
            {
                MessageBox.Show("Obrigatorio informar a data de saida");
                mtxt_data_saida.Focus();
                return;
            }
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o nome da retirada");
                txt_nome.Focus();
                return;
            }

            if (txt_bairro.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o bairro");
                txt_bairro.Focus();
                return;
            }

            if (txt_end.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o endereço");
                txt_end.Focus();
                return;
            }

            if (txt_n.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o número");
                txt_n.Focus();
                return;
            }
            if (mtxt_cep.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o cep");
                mtxt_cep.Focus();
                return;
            }

            if (mtxt_cpf.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o número");
                mtxt_cpf.Focus();
                return;
            }


            con.ConectarBD();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con.ConectarBD();
                cmd.CommandText = "insert into tbl_Delivery(cpf_Cliente,cd_Serviço,nm_Retirada,nm_Logradouro,no_Logradouro,nm_Bairro,ds_Complemento,no_CEP,dt_Saida,vl_Delivery)values(@cpf,@serviço,@retirada,@nmlog,@nolog,@bairro,@comp,@cep,@dtsaida,@valor)";

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mtxt_cpf.Text;
                cmd.Parameters.Add("@serviço", SqlDbType.Int).Value = txt_cod_serviço.Text;
                cmd.Parameters.Add("@retirada", SqlDbType.VarChar).Value = txt_nome.Text;
                cmd.Parameters.Add("@nmlog", SqlDbType.VarChar).Value = txt_end.Text;
                cmd.Parameters.Add("@nolog", SqlDbType.Int).Value = txt_n.Text;
                cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
                cmd.Parameters.Add("@comp", SqlDbType.VarChar).Value = txt_comp.Text;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = mtxt_cep.Text;
                cmd.Parameters.Add("@dtsaida", SqlDbType.Date).Value = mtxt_data_saida.Text;
                cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = txt_valor.Text;

                cmd.ExecuteNonQuery();
                con.DesConectarBD();

            }

            limparCampos();

            MessageBox.Show("Cadastro realizado com sucesso");
            return;
        }

        //Metodo de alterar
        //Finalizado
        private void btn_alterar_Click(object sender, EventArgs e)

        {
                if (txt_cod_serviço.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o código do serviço");
                    txt_cod_serviço.Focus();
                    return;
                }

                if (mtxt_data_saida.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar a data de saida");
                    mtxt_data_saida.Focus();
                    return;
                }
                if (txt_nome.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o nome da retirada");
                    txt_nome.Focus();
                    return;
                }

                if (txt_bairro.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o bairro");
                    txt_bairro.Focus();
                    return;
                }

                if (txt_end.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o endereço");
                    txt_end.Focus();
                    return;
                }

                if (txt_n.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o número");
                    txt_n.Focus();
                    return;
                }
                if (mtxt_cep.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o cep");
                    mtxt_cep.Focus();
                    return;
                }

                else if (mtxt_cpf.Text == "")
                {
                    MessageBox.Show("Obrigatorio informar o número");
                    mtxt_cpf.Focus();
                    return;
                }
            else { 

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = "Update tbl_Delivery set cpf_Cliente=@cpf , nm_Retirada=@retirada, nm_Logradouro=@nlog, no_Logradouro=@nolog, nm_Bairro=@bairro, ds_Complemento=@comp, no_CEP=@cep, dt_Saida=@saida, vl_Delivery=@valor";

                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mtxt_cpf.Text;
                    cmd.Parameters.Add("@retirada", SqlDbType.VarChar).Value = txt_nome.Text;
                    cmd.Parameters.Add("@nlog", SqlDbType.VarChar).Value =txt_end.Text;
                    cmd.Parameters.Add("@nolog", SqlDbType.Int).Value = txt_n.Text;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
                    cmd.Parameters.Add("@comp", SqlDbType.VarChar).Value =txt_comp.Text;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = mtxt_cep.Text;
                    cmd.Parameters.Add("@saida", SqlDbType.Date).Value = mtxt_data_saida.Text;
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = txt_valor.Text;

                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();

                }  
                
                //limpar
                limparCampos();

                MessageBox.Show("Cadastro realizado com sucesso");
                return;
            }
        }

        //Metodo de cancelar (limpa os campos)
        //Finalizado
        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        //Metodo de excluir
        //Finalizado
        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            if (txt_cod.Text != "")
            {


                string message = "Deseja realmente deletar o pedido ?";
                string caption = "Deletar pedido";

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
                    command.CommandText = "Delete from tbl_Delivery where cd_Delivery=@cod_excluir";

                    command.Parameters.AddWithValue("@cod_excluir", txt_cod.Text);

                    command.ExecuteNonQuery();

                }
                con.DesConectarBD();
                limparCampos();
                MessageBox.Show("Pedido deletado com sucesso");
            }

            else
            {
                MessageBox.Show("Consulte o pedido antes de deletar");
            }
        }


    }
}

   


       