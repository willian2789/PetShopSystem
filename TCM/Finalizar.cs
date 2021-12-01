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
    public partial class Finalizar : UserControl
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Finalizar()
        {
            InitializeComponent();
        }

        //Metodo de Limpar
        //Finalizado
        private void limparCampos()
        {

            txt_valor.Text = "";
            rdb_cred.Checked = false;
            rdb_deb.Checked = false;
            rdb_din.Checked = false;
            rdb_pix.Checked = false;
            txt_cod_s.Text = "";
            dgv_pag.DataSource = null;

        }


        //Metodo de finalizar (cadastrar)
        //Finalizado
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (!rdb_cred.Checked && !rdb_deb.Checked && !rdb_din.Checked && !rdb_pix.Checked)
            {
                MessageBox.Show("Obrigatorio informar a foda  de pagamento");
            }
            else if (dgv_pag.DataSource == null)
            {
                MessageBox.Show("Obrigatorio consultar o pedido antes de finalizalo");
            }
            else
            {
                string form_pag;

                if (rdb_cred.Checked == true)
                {
                    form_pag = "Cartao de credito";
                }
                else if (rdb_deb.Checked == true)
                {
                    form_pag = "Cartao de debito";
                }
                else if (rdb_din.Checked == true)
                {
                    form_pag = "Dinheiro";
                }
                else
                {
                    form_pag = "Pix";
                }

                con.ConectarBD();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = "insert into tbl_Pagamento(ds_Pagamento, cd_Serviços,vl_Total)values(@pag,@cd_serv,@vl);";


                    cmd.Parameters.Add("@pag", SqlDbType.VarChar).Value = form_pag;
                    cmd.Parameters.Add("@cd_serv", SqlDbType.Int).Value = txt_cod_s.Text;
                    cmd.Parameters.Add("@vl", SqlDbType.Decimal).Value = txt_valor.Text;


                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();

                }
                limparCampos();
                MessageBox.Show("Pedido realizado com sucesso");
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //Metodo de consultar servico
        //Finalizado
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            preencherGrid();
        }

        //Metodo pra preencher o DataGrid
        //Finalizado
        private void preencherGrid()
        {
            try
            {
                con.ConectarBD();
                cmd.CommandText = "select * from tbl_Serviços where cd_Serviços=" + txt_cod_s.Text;
                cmd.Connection = con.ConectarBD();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dgv_pag.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
                con.DesConectarBD();
            }
        }

        //Puxa o valor total a partir do cod do serviço
        //Fnalizado
        private void txt_cod_s_TextChanged(object sender, EventArgs e)
        {
            if (txt_cod_s.Text == "")
            {
                txt_cod_s.Clear();
                txt_valor.Clear();
            }
            else
            {
                try
                {
                    con.ConectarBD();
                    string strSql = "select vl_Serviço from tbl_Serviços where cd_Serviços=" + txt_cod_s.Text;
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = strSql;
                    SqlDataReader leitor;
                    leitor = cmd.ExecuteReader();

                    if (!leitor.HasRows)
                    {
                        MessageBox.Show("Serviço não existente");
                        txt_cod_s.Clear();
                        txt_cod_s.Focus();
                    }
                    else
                    {
                        leitor.Read();
                        txt_valor.Text = leitor["vl_Serviço"].ToString();
                        con.DesConectarBD();
                    }
                    if (!leitor.IsClosed)
                    {
                        leitor.Close();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    con.DesConectarBD();
                }

            }
        }

        //Metodo de excluir
        //Finalizado
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_cod_s.Text != "")
            {


                string message = "Deseja realmente cancelar o pedido ?";
                string caption = "Cancelar pedido";
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
                    command.CommandText = "Delete from tbl_Pagamento   where cd_Serviços=" + txt_cod_s.Text;


                    command.ExecuteNonQuery();

                }
                con.DesConectarBD();
                limparCampos();
                MessageBox.Show("Pedido cancelado com sucesso");
            }

            else
            {
                MessageBox.Show("Consulte o pedido antes de deletar");
            }
        }


        //Metodo de alterar
        //A fazer
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (!rdb_cred.Checked && !rdb_deb.Checked && !rdb_din.Checked && !rdb_pix.Checked)
            {
                MessageBox.Show("Obrigatorio informar a foda  de pagamento");
            }
            else if (dgv_pag.DataSource == null)
            {
                MessageBox.Show("Obrigatorio consultar o pedido antes de finalizalo");
            }
            else
            {
                string form_pag;

                if (rdb_cred.Checked == true)
                {
                    form_pag = "Cartao de credito";
                }
                else if (rdb_deb.Checked == true)
                {
                    form_pag = "Cartao de debito";
                }
                else if (rdb_din.Checked == true)
                {
                    form_pag = "Dinheiro";
                }
                else
                {
                    form_pag = "Pix";
                }

                con.ConectarBD();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = "Update tbl_Pagamento set ds_Pagamento=@pag,vl_Total=@vl where  cd_Serviços=@cd_serv";


                    cmd.Parameters.Add("@pag", SqlDbType.VarChar).Value = form_pag;
                    cmd.Parameters.Add("@cd_serv", SqlDbType.Int).Value = txt_cod_s.Text;
                    cmd.Parameters.Add("@vl", SqlDbType.Decimal).Value = txt_valor.Text;


                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();

                }
                limparCampos();
                MessageBox.Show("Pedido atualizado com sucesso");
            }
        }
    }
}
