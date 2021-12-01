using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source =PC\SQLEXPRESS01;Initial Catalog=db_Animalcity; User ID=PC\Aléxia; Integrated Security=True");
        public static string msg;

        public SqlConnection ConectarBD()
        {
            try
            {
                con.Open();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return con;
        }
        public SqlConnection DesConectarBD()
        {
            try
            {
                con.Close();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return con;
        }

    }
}
