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
    public partial class Pets : UserControl
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Pets()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txt_pesquisa.Text = "";
            txt_cod.Text = "";
            txt_cod_dono.Text = "";
            txt_raca.Text = "";
            txt_especie.Text = "";
            cb_fem.Checked = false;
            cb_masc.Checked = false;
            rdb_p.Checked = false;
            rdb_m.Checked = false;
            rdb_g.Checked = false;
            txt_nome_pet.Text = "";
            mtxt_cpf.Text = "";

        }

        //Metodo de consultar
        //finalizado
        private void btn_consulta_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_Pet where cd_Pet=@cd", con.ConectarBD());
            cmd.Parameters.AddWithValue("@cd", SqlDbType.Int).Value = txt_pesquisa.Text;

            if (txt_pesquisa.Text == "")
            {
                MessageBox.Show("Digite o código do pet");
            }

            con.ConectarBD();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == false)
            {
                MessageBox.Show("código não cadastrado");
            }

            else
            {
                dr.Read();
                txt_cod.Text = dr["cd_Pet"].ToString(); //Preenche a txt com o q esta escrito no sql
                txt_cod_dono.Text = dr["cd_Cliente"].ToString();
                txt_nome_pet.Text = dr["nm_Pet"].ToString();
                txt_raca.Text = dr["rç_Pet"].ToString();
                mtxt_cpf.Text = dr["cpf_Cliente"].ToString();
                txt_especie.Text = dr["ds_Especie"].ToString();

                string sex = dr["sg_Pet"].ToString();

                if (sex == "M")
                {
                    cb_masc.Checked = true;
                }
                else
                {
                    cb_fem.Checked = true;
                }

                string porte = dr["porte_Pet"].ToString();

                if (porte == "P")
                {
                    rdb_p.Checked = true;
                }
                if (porte == "M")
                {
                    rdb_m.Checked = true;
                }
                else
                {
                    rdb_g.Checked = true;
                }

                string status = dr["sg_Status"].ToString();

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


        //Metodo de cadastrar
        //Finalizado
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            if (txt_nome_pet.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Nome");
                txt_nome_pet.Focus();
                return;
            }

            if (txt_cod_dono.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o código do dono");
                txt_cod.Focus();
                return;
            }

            if (txt_especie.Text == "")
            {
                MessageBox.Show("Obrigatorio informar a espécie do animal, tais como: cachorro ou gato ");
                txt_cod.Focus();
                return;
            }
            else if (!rdb_p.Checked && !rdb_m.Checked && !rdb_g.Checked)
            {
                MessageBox.Show("Obrigatorio informar o porte do animal");
            }
            else if (!cb_fem.Checked && !cb_masc.Checked)
            {
                MessageBox.Show("Obrigatorio informar o sexo do animal");
            }
            else
            {
                char xp;

                if (cb_fem.Checked)
                {
                    xp = 'F';
                }
                else
                {
                    xp = 'M';
                }

                char pt;

                if (rdb_p.Checked)
                {
                    pt = 'P';
                }
                else if (rdb_m.Checked)
                {
                    pt = 'M';
                }
                else
                {
                    pt = 'G';
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "insert into tbl_Pet(sg_Pet,cd_Cliente,cpf_Cliente,rç_Pet,porte_Pet,nm_Pet,ds_Especie,sg_Status)values(@sx,@cod_cli,@cpf,@raca,@porte,@nome,@especie,1);";

                    cmd.Connection = con.ConectarBD();
                    cmd.Parameters.AddWithValue("@sx", xp);
                    cmd.Parameters.AddWithValue("@cod_cli", txt_cod_dono.Text);
                    cmd.Parameters.AddWithValue("@cpf", mtxt_cpf.Text);
                    cmd.Parameters.AddWithValue("@raca", txt_raca.Text);
                    cmd.Parameters.AddWithValue("@porte", pt);
                    cmd.Parameters.AddWithValue("@nome", txt_nome_pet.Text);
                    cmd.Parameters.AddWithValue("@especie", txt_especie.Text);

                    con.ConectarBD();
                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();
                }
                limparCampos();
                MessageBox.Show("Cadastro feito com sucesso");
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
            if (txt_nome_pet.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Nome");
                txt_nome_pet.Focus();
                return;
            }

            if (txt_cod_dono.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o código do dono");
                txt_cod.Focus();
                return;
            }

            if (txt_especie.Text == "")
            {
                MessageBox.Show("Obrigatorio informar a espécie do animal, tais como: cachorro ou gato ");
                txt_cod.Focus();
                return;
            }
            else if (!rdb_p.Checked && !rdb_m.Checked && !rdb_g.Checked)
            {
                MessageBox.Show("Obrigatorio informar o porte do animal");
            }
            else if (!cb_fem.Checked && !cb_masc.Checked)
            {
                MessageBox.Show("Obrigatorio informar o sexo do animal");
            }
            else
            {
                char xpp;

                if (cb_fem.Checked)
                {
                    xpp = 'F';
                }
                else
                {
                    xpp = 'M';
                }

                char ptt;

                if (rdb_p.Checked)
                {
                    ptt = 'P';
                }
                else if (rdb_m.Checked)
                {
                    ptt = 'M';
                }
                else
                {
                    ptt = 'G';
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


                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update tbl_Pet set  sg_Pet=@sg, cd_Cliente=@cd_cli, cpf_Cliente=@cpf_cli, rç_Pet=@rc, porte_Pet=@pt, nm_Pet=@nm, ds_Especie=@esp, sg_Status=@sts where cd_Pet=@cod_pet";

                    cmd.Connection = con.ConectarBD();
                    cmd.Parameters.AddWithValue("@cod_pet", txt_cod.Text);
                    cmd.Parameters.AddWithValue("@cd_cli", txt_cod_dono.Text);
                    cmd.Parameters.AddWithValue("@cpf_cli", mtxt_cpf.Text);
                    cmd.Parameters.AddWithValue("@sg", xpp);
                    cmd.Parameters.AddWithValue("@rc", txt_raca.Text);
                    cmd.Parameters.AddWithValue("@pt", ptt);
                    cmd.Parameters.AddWithValue("@nm", txt_nome_pet.Text);
                    cmd.Parameters.AddWithValue("@esp", txt_especie.Text);
                    cmd.Parameters.AddWithValue("@sts", st);

                    con.ConectarBD();
                    cmd.ExecuteNonQuery();
                    con.DesConectarBD();
                }

                limparCampos();
                MessageBox.Show("Cadastro atualizado com sucesso");
                return;
            }
        }

        //apaga os campos
        private void btn_canelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }


        //Metodo de excluir
        //Finalizado
        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            if (rdb_inativo.Checked)
            {
                MessageBox.Show("Para excluir um cadastro ele precisa estar ativo");
            }
            else
            {


                if (txt_cod.Text != "")
                {

                    string message = "deseja realmente deletar o cadastro de " + txt_nome_pet.Text + "?";
                    string caption = "Deletar cadastro";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    //Mostra a mensagem de pergunta

                    result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    if (result == DialogResult.No)
                    {
                        //retorna a tela de cadastro
                        return;
                    }

                    using (SqlCommand command = new SqlCommand())
                    {


                        command.Connection = con.ConectarBD();
                        command.CommandText = "Update  tbl_Pet set sg_Status=0 where cd_Pet=@cod";

                        command.Parameters.AddWithValue("@cod", txt_cod.Text);

                        command.ExecuteNonQuery();
                        con.DesConectarBD();
                    }

                    limparCampos();
                    MessageBox.Show("Cadastro de " + txt_nome_pet.Text + " deletado com sucesso");

                }

                else
                {
                    MessageBox.Show("Consulte o cadastro antes de deletar");
                }
            }
        }

        
    }
}
