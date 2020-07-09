using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFaturamento
{
    public partial class CadastroProduto : Form
    {
        Cliente cad = new Cliente();
        public String mensagem = "";
        Conexao conexao = new Conexao();
        DataTable dt = new DataTable();
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bdFaturaDataSet1.Produto);
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Item_venda'. Você pode movê-la ou removê-la conforme necessário.
            
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet1.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bdFaturaDataSet1.Produto);

           
        }
        private void LimpaTextBox()
        {
            id_produtoComboBox.Text = "";
            txtPreco.Text = "";
            txtProduto.Text = "";
            txtQtde.Text = "";
        }


        private void btnAlteraBanco_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" " + cad.alterarProd(id_vendaTextBox.Text, id_produtoComboBox.Text, valorTextBox.Text));
        }

        private void BtnNovoItem_Click_1(object sender, EventArgs e)
        {
            cad.cadastrarProd(txtProduto.Text, txtPreco.Text, txtQtde.Text);
            MessageBox.Show(cad.mensagem);
            LimpaTextBox();
        }

      

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            this.produtoTableAdapter.Fill(this.bdFaturaDataSet1.Produto);
            produtoDataGridView.Update();
            produtoDataGridView.Refresh();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.ToString();
            btnAtualizar.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+ cad.excluirProd(id_vendaTextBox.Text, id_produtoComboBox.Text, valorTextBox.Text));
            LimpaTextBox();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultVend_Click(object sender, EventArgs e)
        {
            ConsultaVendas abrir = new ConsultaVendas();
            abrir.Show();
            this.Hide();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente abrir = new CadastroCliente();
            abrir.Show();
            this.Hide();

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Faturamento abrir = new Faturamento();
            abrir.Show();
            this.Hide();
        }
    }
}
