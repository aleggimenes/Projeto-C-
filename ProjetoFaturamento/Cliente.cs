using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.Security.Cryptography;

namespace ProjetoFaturamento
{
    public class Cliente
    {
        Conexao conexao = new Conexao();
        //SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataReader ler;
        DataGridView dataGridView = new DataGridView();
        public String mensagem = "";

        
        public String cadastrar(String nome, String telefone, String cpf, String endereco, String data_nasc, String uf, String cep, String Tipo_cliente)
        {
            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd5 = new SqlCommand();
            //Comando Sql -- SqlCommand
            cmd1.CommandText = "insert into Cliente (nome,telefone,cpf,endereco,data_nasc,uf,cep) values(@nome, @telefone, @cpf, @endereco, @data_nasc, @uf, @cep)";
            cmd5.CommandText = "insert into Tipo (Tipo_cliente) values (@Tipo_cliente)";

            //Parametros
            cmd1.Parameters.AddWithValue("@nome", nome);
            cmd1.Parameters.AddWithValue("@telefone", telefone);
            cmd1.Parameters.AddWithValue("@cpf", cpf);
            cmd1.Parameters.AddWithValue("@endereco", endereco);
            cmd1.Parameters.AddWithValue("@data_nasc", data_nasc);
            cmd1.Parameters.AddWithValue("@uf", uf);
            cmd1.Parameters.AddWithValue("@cep", cep);
            cmd5.Parameters.AddWithValue("@Tipo_cliente", Tipo_cliente);

            try
            {
                //conectar com o Banco -- Conexao
                cmd1.Connection = conexao.conectar();
                cmd5.Connection = conexao.conectar();
                //executar comando
                cmd1.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao se conectar com o Banco de Dados" + e;
                Application.Run();
            }
            return mensagem;
        }

        public DataTable consultar()
        {
            SqlCommand cmd2 = new SqlCommand();
            
            string vSQL = "select * from Cliente";
            
            //cmd2.CommandText = "select * from Cliente";
            SqlConnection vConn = conexao.conectar();
            
            //cmd2.Connection = conexao.conectar();
            SqlDataAdapter sqlda = new SqlDataAdapter(vSQL, vConn);
            
            //ler = cmd2.ExecuteReader();
            sqlda.Fill(dt);
           
            //dt.Load(ler);
            conexao.desconectar();

            return dt;
        }

        public DataTable tipoCliente()
        {
            SqlCommand cmd16 = new SqlCommand();
            string vSQL2 = "select * from Tipo";
            SqlConnection vConn2 = conexao.conectar();
            SqlDataAdapter sqlda2 = new SqlDataAdapter(vSQL2, vConn2);
            sqlda2.Fill(dt2);
            conexao.desconectar();
            return dt2;
        }

        public String excluir(string id, string idTipo)
        {
            
            SqlCommand cmd3 = new SqlCommand();
            SqlCommand cmd6 = new SqlCommand();
            cmd3.CommandText = "delete from Cliente where Id = @id";
            cmd3.Parameters.AddWithValue("@id", id);
            cmd6.CommandText = "delete from Tipo where Id_tipo = @idTipo";
            cmd6.Parameters.AddWithValue("@idTipo", idTipo);
            try
            {
                //conectar com o Banco -- Conexao
                cmd3.Connection = conexao.conectar();
                cmd6.Connection = conexao.conectar();
                //executar comando
                cmd3.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Deletado com Sucesso";

            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao deletar" + e;
            }
            return mensagem;
        }



        public String alterar(String Id, String nome, String telefone, String cpf, String endereco, String data_nasc, String uf, String cep, String Tipo_cliente)
        {
            SqlCommand cmd4 = new SqlCommand();
            SqlCommand cmd7 = new SqlCommand();
            
            cmd4.CommandText = "update Cliente set nome = @nome, telefone = @telefone, cpf = @cpf, endereco = @endereco, data_nasc = @data_nasc, uf = @uf, cep = @cep where Id = @Id";
            cmd7.CommandText = "update Tipo set Tipo_cliente = @Tipo_cliente where Id_tipo = @Id";

            cmd4.Parameters.AddWithValue("@Id", Id);
            cmd4.Parameters.AddWithValue("@nome", nome);
            cmd4.Parameters.AddWithValue("@telefone", telefone);
            cmd4.Parameters.AddWithValue("@cpf", cpf);
            cmd4.Parameters.AddWithValue("@endereco", endereco);
            cmd4.Parameters.AddWithValue("@data_nasc", data_nasc);
            cmd4.Parameters.AddWithValue("@uf", uf);
            cmd4.Parameters.AddWithValue("@cep", cep);

            cmd7.Parameters.AddWithValue("@Id", Id);
            cmd7.Parameters.AddWithValue("@Tipo_cliente", Tipo_cliente);
            try
            {
                //conectar com o Banco -- Conexao
                cmd4.Connection = conexao.conectar();
                cmd7.Connection = conexao.conectar();
                //executar comando
                cmd4.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Alterado com Sucesso";

            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao alterar" + e;
            }

            return mensagem;
            }

        public String cadastrarProd(String descricao, String valor,  String quantidade)
        {
            SqlCommand cmd8 = new SqlCommand();
            SqlCommand cmd9 = new SqlCommand();


            
            //Comando Sql -- SqlCommand
            cmd8.CommandText = "insert into Produto (descricao,valor) values(@descricao,@valor)";
            cmd9.CommandText = "insert into Item_venda (quantidade) values(@quantidade)";

            //Parametros
            cmd8.Parameters.AddWithValue("@descricao", descricao);
            cmd8.Parameters.AddWithValue("@valor", valor);
            cmd9.Parameters.AddWithValue("@quantidade", quantidade);
          

            try
            {
                //conectar com o Banco -- Conexao
                cmd8.Connection = conexao.conectar();
                cmd9.Connection = conexao.conectar();
                //executar comando
                cmd8.ExecuteNonQuery();
                cmd9.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Adcionado com Sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao se conectar com o Banco de Dados" + e;
                Application.Run();
            }
            return mensagem;
        }

        public String alterarProd(String Id_produto, String descricao, String valor)
        {
            SqlCommand cmd11 = new SqlCommand();

            cmd11.CommandText = "update Produto set descricao = @descricao, valor = @valor where Id_produto = @Id_produto" ;

            cmd11.Parameters.AddWithValue("@Id_produto", Id_produto);
            cmd11.Parameters.AddWithValue("@descricao",descricao);
            cmd11.Parameters.AddWithValue("@valor", valor);
            
            try
            {
                //conectar com o Banco -- Conexao
                cmd11.Connection = conexao.conectar();
                //executar comando
                cmd11.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Alterado com Sucesso";

            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao alterar" + e;
            }

            return mensagem;
        }

        public String inserirVenda(String valor, String id_cliente, String id_compra, String id_produto, String data_compra)
        {
            SqlCommand cmd13 = new SqlCommand();
            

            //Comando Sql -- SqlCommand
            cmd13.CommandText = "insert into Venda (valor, id_cliente,id_compra,id_produto,data_compra) values(@valor,@id_cliente,@id_compra,@id_produto,@data_compra)";
           

            //Parametros

            cmd13.Parameters.AddWithValue("@valor", valor);
            cmd13.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd13.Parameters.AddWithValue("@id_compra", id_compra);
            cmd13.Parameters.AddWithValue("@id_produto", id_produto);
            cmd13.Parameters.AddWithValue("@data_compra", data_compra);

            try
            {
                //conectar com o Banco -- Conexao
                cmd13.Connection = conexao.conectar();
                //executar comando
                cmd13.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Venda Concluida com sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao vender" + e;
                Application.Run();
            }
            return mensagem;
        }

        public String excluirProd(string id_produto, string descricao, string valor)
        {

            SqlCommand cmd17 = new SqlCommand();
            cmd17.CommandText = "delete from Produto where id_produto = @id_produto";
            cmd17.Parameters.AddWithValue("@id_produto", id_produto);
            try
            {
                //conectar com o Banco -- Conexao
                cmd17.Connection = conexao.conectar();
                //executar comando
                cmd17.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();

                //Mostrar Mensagem de Erro ou sucesso
                this.mensagem = "Deletado com Sucesso";

            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao deletar" + e;
            }
            return mensagem;
        }

    }
}

    

