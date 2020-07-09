using ProjetoFaturamento.bdFaturaDataSet1TableAdapters;
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
using System.IO;
using System.Configuration;

namespace ProjetoFaturamento
{
    public partial class Faturamento : Form
    {
        int cont = 31;
        Cliente cad = new Cliente();
        float precototal;
        public String mensagem = "";
        Conexao conexao = new Conexao();
        DataTable dt = new DataTable();

        public Faturamento()
        {
            InitializeComponent();
        }
        
        private void Faturamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Item_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.item_vendaTableAdapter.Fill(this.bdFaturaDataSet1.Item_venda);
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bdFaturaDataSet1.Produto);
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.bdFaturaDataSet1.Venda);
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bdFaturaDataSet1.Cliente);

            this.vendaBindingSource.AddNew();
            
            txtData.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdFaturaDataSet1);
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            GroupBox.Visible = true;
            btnNovaVenda.Enabled = false;
            
        }
        
        private void LimpaTextBox()
        {
            
            dataGridView1.Rows.Clear();
            txtIdAdicionar.Text = "";
            txtQtdeAdicionar.Text = "";
            txtValorTotal.Text = "";
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try { 
                string strbanco;
                strbanco = ProjetoFaturamento.Properties.Settings.Default.strconexao;
                SqlConnection objconexao = new SqlConnection(strbanco);

                objconexao.Open();

                string tx = "select * from Produto where Id_produto = '" + txtIdAdicionar.Text + "'";
                SqlCommand cmd10 = new SqlCommand(tx, objconexao);

                SqlDataReader r = cmd10.ExecuteReader();

            while (r.Read())
            {
                int precoUnit = int.Parse(r[2].ToString());
                int preco = int.Parse(txtQtdeAdicionar.Text.ToString()) * int.Parse(r[2].ToString());
                precototal += preco;
        
                dataGridView1.Rows.Add(txtCodVenda.Text, r[0], r[1],  txtQtdeAdicionar.Text, precoUnit.ToString("C") ,preco.ToString("C"));
            }
                txtValorTotal.Text = precototal.ToString("C");

                cad.inserirVenda(txtValorTotal.Text, idTextBox.Text, txtCodVenda.Text, txtIdAdicionar.Text, txtData.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro" + erro.Message);
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
           

            //cad.inserirVenda(txtValorTotal.Text, txtTeste.Text, txtCodVenda.Text, txtIdAdicionar.Text);
            //MessageBox.Show(cad.mensagem);
            int increment = int.Parse(txtCodVenda.Text) + 1;
            txtCodVenda.Text = increment.ToString();

            GroupBox.Visible = false;
            dataGridView1.Rows.Clear();
            txtIdAdicionar.Text = "";
            txtQtdeAdicionar.Text = "";
            txtValorTotal.Text = "";
            btnNovaVenda.Enabled = true;   
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.ToString();
        }
        
        private void btnProxCompra_Click(object sender, EventArgs e)
        {

            //txtCodVenda.Text = increment.ToString();
            //int increment = int.Parse(txtCodVenda.Text) + 1;
            /*Numero = int.Parse(txtNumero.Text) + 1; //incrementa 1
            txtNumero.Text = Numero.ToString(); //converte para string*/
            //cad.codCompra(txtCodVenda.Text);
            //codCompra();
        }

        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            ConsultaVendas consulta = new ConsultaVendas();
            consulta.Show();
            this.Hide();
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CadastroProduto abrir = new CadastroProduto();
            abrir.Show();
            this.Hide();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente abrir = new CadastroCliente();
            abrir.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Hide();

        }

        private void btnConsultVend_Click(object sender, EventArgs e)
        {
            ConsultaVendas abrir = new ConsultaVendas();
            abrir.Show();
            this.Hide();
        }
        
        /*public DataTable codCompra()
        { 
            SqlConnection vConn = conexao.conectar();
            //cmd2.CommandText = "select * from Cliente";
            string vSQL = "select id_compra from Venda where id_compra = 2";
            SqlCommand cmd15 = new SqlCommand(vSQL, vConn);
            //cmd2.Connection = conexao.conectar();      
            //ler = cmd2.ExecuteReader();
            //dt.Load(ler);
            conexao.desconectar();
            return dt;
        }*/
    }
}
