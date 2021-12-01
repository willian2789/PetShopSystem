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
    public partial class Serviços : UserControl
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Serviços()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            // Serviço normal

           
            txt_valor.Text = "";
            cb_servicos.SelectedIndex = -1;
            mtxt_cpf_cli.Text = "";
            lbl_total.Text = "";
            dgv_servico.DataSource = null;

        }
        private void limparServico()
        {
            // Serviço normal

            
            txt_valor.Text = "";
            cb_servicos.SelectedIndex = -1;
            lbl_total.Text = "";
            txt_qt.Text = "";
            txt_valor_serv.Text = "";

        }

        //Metodo de inserir(cadastrar)
        //Finalizado
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (txt_cod_cli.Text == "")
            {
                MessageBox.Show("É obrigatorio informar o CPF do cliente");
            }
            else if (cb_servicos.SelectedIndex == -1)
            {
                MessageBox.Show("É importante informar o tipo de serviço");
            }
            else
            {
                con.ConectarBD();
                cmd.CommandText = "select * from tbl_Serviços where cd_Serviços=" + lbl_cod_pedido.Text;
                cmd.Connection = con.ConectarBD();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                da.Fill(dta);


                int cd_serv = Convert.ToInt32(lbl_cod_pedido.Text);
                int cd_cli = Convert.ToInt32(txt_cod_cli.Text);
                int cd_func = Convert.ToInt32(lbl_cod_func.Text);
                string dt = lbl_dt.Text;
                decimal vl_serv = 0;

                string cd_espec = lbl_cod_espcial.Text;
                decimal valor = Convert.ToDecimal(txt_valor_serv.Text);
                int qt = Convert.ToInt16(txt_qt.Text);


                if (dta.Rows.Count < 1)
                {


                    cmd.CommandText = "insert into tbl_Serviços(cd_Serviços,cd_Cliente,cd_Funcionario,dt_Serviço,vl_Serviço)values(@cd_Serviços,@cd_Cliente,@cd_Funcionario,@dt_Serviço,@vl_Serviço)";
                    cmd.Connection = con.ConectarBD();
                    cmd.Parameters.Add("@cd_Serviços", SqlDbType.Int).Value = cd_serv;
                    cmd.Parameters.Add("@cd_Cliente", SqlDbType.Int).Value = cd_cli;
                    cmd.Parameters.Add("@cd_Funcionario", SqlDbType.Int).Value = cd_func;
                    cmd.Parameters.Add("@dt_Serviço", SqlDbType.Date).Value = dt;
                    cmd.Parameters.Add("@vl_Serviço", SqlDbType.Decimal).Value = vl_serv;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "insert into tbl_Itens_Serviços(cd_Serviço,ds_Especialidade,qt_Servico,vl_Serviço)values(@cd_Serviço,@ds_Especialidade,@qt_Servico,@vl_Serviço)";

                    cmd.Parameters.Add("@cd_Serviço", SqlDbType.Int).Value = cd_serv;
                    cmd.Parameters.Add("@ds_Especialidade", SqlDbType.VarChar).Value = cd_espec;
                    cmd.Parameters.Add("@qt_Servico", SqlDbType.Int).Value = qt;
                    cmd.Parameters.Add("@vl_Serviço", SqlDbType.Decimal).Value = valor;


                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    limparServico();
                    preencherGrid();
                    calcularTotal();
                    con.DesConectarBD();
                }
                else
                {
                    
                    cmd.CommandText = "insert into tbl_Itens_Serviços(cd_Serviço,ds_Especialidade,qt_Servico,vl_Serviço)values(@cd_Serviço,@ds_Especialidade,@qt_Servico,@vl_Serviço)";

                    cmd.Parameters.Add("@cd_Serviço", SqlDbType.Int).Value = cd_serv;
                    cmd.Parameters.Add("@ds_Especialidade", SqlDbType.VarChar).Value = cd_espec;
                    cmd.Parameters.Add("@qt_Servico", SqlDbType.Int).Value = qt;
                    cmd.Parameters.Add("@vl_Serviço", SqlDbType.Decimal).Value = valor;


                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    limparServico();
                    preencherGrid();
                    calcularTotal();
                    con.DesConectarBD();
                }
            }
            

        }

        //Calcular o traotal de serviços 
        //Finalizado
        private void calcularTotal()
        {
            decimal total_servico = 0;
            foreach(DataGridViewRow row in dgv_servico.Rows)
            {
                total_servico += Convert.ToDecimal(row.Cells["vl_Serviço"].Value);
            }
            lbl_total.Text = total_servico.ToString();
        }

        //Preenche o data grid
        //Finalizada
        private void preencherGrid()
        {
            try
            {
                con.ConectarBD();
                cmd.CommandText = "select * from tbl_Itens_Serviços where cd_Serviço=" + lbl_cod_pedido.Text;
                cmd.Connection = con.ConectarBD();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dgv_servico.DataSource = dt;

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
                con.DesConectarBD();
            }
        }


        //Metodo de finalizar
        //Precisa fazer
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            decimal total_servico = 0;
            foreach (DataGridViewRow row in dgv_servico.Rows)
            {
                total_servico += Convert.ToDecimal(row.Cells["vl_Serviço"].Value);
            }
            cmd.CommandText = "update tbl_Serviços set vl_Serviço=@total where cd_Serviços=@cod";

            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = lbl_total.Text;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = lbl_cod_pedido.Text;
            con.ConectarBD();
            cmd.Connection = con.ConectarBD();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.DesConectarBD();
            limparCampos();
            carregaPedido();

        }

        //Limpar Campos
        //Finalizado
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //Puxa o codigo do usuario,põe a data de hoje
        //Finalizado
        private void Serviços_Load(object sender, EventArgs e)
        {
            lbl_cod_func.Text = Login.codUsuario;
            lbl_dt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            carregaPedido();

        }

        //Carrega o numero do pedido
        //Finalizado
        private void carregaPedido()
        {

            try
            {
                con.ConectarBD();
                cmd.CommandText = "select top 1 cd_Serviços from tbl_Serviços order by cd_Serviços desc";
                cmd.Connection = con.ConectarBD();
                SqlDataReader leitor;
                leitor = cmd.ExecuteReader();

                if (!leitor.HasRows)
                {
                    lbl_cod_pedido.Text = "1";
                }
                else
                {
                    leitor.Read();

                    string numero = leitor["cd_Serviços"].ToString();
                    int n = Convert.ToInt32(numero);
                    n++;
                    lbl_cod_pedido.Text = n.ToString();

                }
                if (!leitor.IsClosed)
                {
                    leitor.Close();
                }
                con.DesConectarBD();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                con.DesConectarBD();
            }

        }

        //Ele puxa apartir do cpf o nome do cliente
        //Finalizado
        private void mtxt_cpf_cli_TextChanged(object sender, EventArgs e)
        {
            if (mtxt_cpf_cli.Text.Length > 10)
            {
                try
                {
                    con.ConectarBD();
                    string strSql = "select cd_Cliente, nm_Cliente from tbl_Cliente where cpf_Cliente=" + mtxt_cpf_cli.Text;
                    cmd.Connection = con.ConectarBD();
                    cmd.CommandText = strSql;
                    SqlDataReader leitor;
                    leitor = cmd.ExecuteReader();

                    if (!leitor.HasRows)
                    {
                        MessageBox.Show("Cpf não cadastrado");
                        mtxt_cpf_cli.Clear();
                        mtxt_cpf_cli.Focus();
                    }
                    else
                    {
                        leitor.Read();
                        txt_cod_cli.Text = leitor["cd_Cliente"].ToString();
                        txt_nm_cli.Text = leitor["nm_Cliente"].ToString();
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
            else
            {
                txt_cod_cli.Clear();
                txt_nm_cli.Clear();
            }
        }


        //Metodo de escolher serviço
        //Finalizado
        private void cb_servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cb_servicos.SelectedIndex == 0)
            {
                txt_valor.Text = "60,00";
                lbl_cod_espcial.Text = "Banho";
                txt_qt.Text = "1";
            }
            else if (cb_servicos.SelectedIndex == 1)
            {
                txt_valor.Text = "80,00";
                lbl_cod_espcial.Text = "Tosa";
                txt_qt.Text = "1";
            }
            else if (cb_servicos.SelectedIndex == 2)
            {
                txt_valor.Text = "140,00";
                lbl_cod_espcial.Text = "Banho e Tosa";
                txt_qt.Text = "1";
            }


        }

        //Faz a conta de quantos serviços tem
        //Finalizado
        private void txt_qt_TextChanged(object sender, EventArgs e)
        {
            if(txt_qt.Text != "")
            {
                int quantidade = Convert.ToInt16(txt_qt.Text);
                decimal valor = Convert.ToDecimal(txt_valor.Text);
                decimal total_valor = quantidade * valor;
                txt_valor_serv.Text = total_valor.ToString();
            }
            else
            {
                txt_valor_serv.Text = "";
            }

        }

        //Metodo de excluir
        //Finalizado
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            dgv_servico.DataSource = null;  
            
        }

        //Metodo de consultar
        //Finalizado
        private void btn_consulta_Click(object sender, EventArgs e)
        {
            preencherGrid2();
        }

        //Metodo pra preencher o DataGrid
        //Finalizado
        private void preencherGrid2()
        {
            try
            {
                con.ConectarBD();
                cmd.CommandText = "select * from tbl_Serviços where cd_Cliente=" + txt_cod_cli.Text;
                cmd.Connection = con.ConectarBD();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dgv_servico.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
                con.DesConectarBD();
            }
        }
    }           
}
