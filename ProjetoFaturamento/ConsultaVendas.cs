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
    public partial class ConsultaVendas : Form
    {
        DataTable dbdataset;
        public ConsultaVendas()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdFaturaDataSet2);

        }

        private void ConsultaVendas_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet2.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.bdFaturaDataSet2.Venda);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Faturamento faturamento = new Faturamento();
            faturamento.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
            this.Hide();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Faturamento abrir = new Faturamento();
            abrir.Show();
            this.Hide();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente abrir = new CadastroCliente();
            abrir.Show();
            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroProduto abrir = new CadastroProduto();
            abrir.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource vbs = new BindingSource();
            vbs.DataSource = vendaDataGridView.DataSource;
            vbs.Filter = "data_compra LIKE '%"+textBox1.Text+"%'";
            vendaDataGridView.DataSource = vbs;
        }
    }
}
