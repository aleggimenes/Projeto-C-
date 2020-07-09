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
    public partial class Menu : Form
    {
        Cliente cad = new Cliente();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnConsultarFt_Click(object sender, EventArgs e)
        {
            Faturamento form = new Faturamento();
            form.Show();
            this.Hide();
        }

        private void btnCadClient_Click(object sender, EventArgs e)
        {
            CadastroCliente form1 = new CadastroCliente();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Faturamento form = new Faturamento();
            form.Show();
            this.Hide();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            CadastroCliente form1 = new CadastroCliente();
            form1.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastroCliente form1 = new CadastroCliente();
            form1.Show();
            this.Hide();
        }

        private void btnCadCli_Click_1(object sender, EventArgs e)
        {
            CadastroCliente form1 = new CadastroCliente();
            form1.Show();
            this.Hide();
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            Faturamento fat = new Faturamento();
            fat.Show();
            this.Hide();
        }

        private void btnConsultVend_Click(object sender, EventArgs e)
        {
            ConsultaVendas abrir = new ConsultaVendas();
            abrir.Show();
            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroProduto abrir = new CadastroProduto();
            abrir.Show();
            this.Hide();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
