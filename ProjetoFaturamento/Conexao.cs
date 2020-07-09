using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ProjetoFaturamento
{
    public class Conexao
    {
        String strbanco;
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            strbanco = ProjetoFaturamento.Properties.Settings.Default.strconexao;
            con.ConnectionString = strbanco;
           
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        

        

    }

}