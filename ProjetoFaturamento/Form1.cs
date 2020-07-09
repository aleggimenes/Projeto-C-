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
    public partial class Form1 : Form
    {
        Cliente cad = new Cliente();
        DataTable dt = new DataTable();
        int cont;
        public Form1()
        {
            InitializeComponent();
            cont = cad.consultar().Rows.Count - 1;

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cad.cadastrar(tbNome.Text, tbCel.Text, tbCpf.Text, tbEnd.Text, tbData.Text, tbUf.Text, tbCep.Text);
            MessageBox.Show(cad.mensagem);
            tbNome.Focus();
            if (tbcod.Text.Length == 0)
            {
                CliCrud aux = new CliCrud(
                    tbNome.Text, tbCel.Text, tbCpf.Text, tbEnd.Text, tbData.Text, tbUf.Text, tbCep.Text);
                aux.Inserir();
            }
            else
            {
                CliCrud aux = new CliCrud(int.Parse(tbcod.Text),
                tbNome.Text, tbCel.Text, tbCpf.Text, tbEnd.Text, tbData.Text, tbUf.Text, tbCep.Text);
                aux.Alterar();
            }
            //Preencherdatagrid(CliCrud.Consultar());
            LimpaTextBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaClienteDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bdFaturaClienteDataSet.Cliente);

            timer1.Start();
            //dataGridView.DataSource = CliCrud.Consultar();
        }
        private void Preencherdatagrid(List<CliCrud> lista)
        {
            dataGridView.DataSource = new BindingList<CliCrud>(lista);
        }
        private void LimpaTextBox()
        {
            tbcod.Text = "";
            tbNome.Text = "";
            tbCel.Text = "";
            tbCpf.Text = "";
            tbCep.Text = "";
            tbData.Text = "";
            tbEnd.Text = "";
            tbUf.Text = "";
        }
      

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }

        private void btnprimeiro_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();

            if(dt.Rows.Count > 0)
            {
                cont = 0;

                tbCel.Text = dt.Rows[cont]["telefone"].ToString();
                tbCep.Text = dt.Rows[cont]["cep"].ToString();
                tbcod.Text = dt.Rows[cont]["Id"].ToString(); 
                tbCpf.Text = dt.Rows[cont]["cpf"].ToString(); 
                tbData.Text = dt.Rows[cont]["data_nasc"].ToString(); 
                tbEnd.Text = dt.Rows[cont]["endereco"].ToString(); 
                tbNome.Text = dt.Rows[cont]["nome"].ToString(); 
                tbUf.Text = dt.Rows[cont]["uf"].ToString();
                
            }


        }
        private void btnanterior_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();

            if(cont == dt.Rows.Count - 1 || cont != 0)
            {
                cont--;

                tbCel.Text = dt.Rows[cont]["telefone"].ToString();
                tbCep.Text = dt.Rows[cont]["cep"].ToString();
                tbcod.Text = dt.Rows[cont]["Id"].ToString(); 
                tbCpf.Text = dt.Rows[cont]["cpf"].ToString(); 
                tbData.Text = dt.Rows[cont]["data_nasc"].ToString(); 
                tbEnd.Text = dt.Rows[cont]["endereco"].ToString(); 
                tbNome.Text = dt.Rows[cont]["nome"].ToString(); 
                tbUf.Text = dt.Rows[cont]["uf"].ToString();
                
            }
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();

            if(cont < dt.Rows.Count - 1)
            {
                cont++;

                tbCel.Text = dt.Rows[cont]["telefone"].ToString();
                tbCep.Text = dt.Rows[cont]["cep"].ToString();
                tbcod.Text = dt.Rows[cont]["Id"].ToString();
                tbCpf.Text = dt.Rows[cont]["cpf"].ToString();
                tbData.Text = dt.Rows[cont]["data_nasc"].ToString();
                tbEnd.Text = dt.Rows[cont]["endereco"].ToString();
                tbNome.Text = dt.Rows[cont]["nome"].ToString();
                tbUf.Text = dt.Rows[cont]["uf"].ToString();
                
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();

            cont = dt.Rows.Count - 1;

            tbCel.Text = dt.Rows[cont]["telefone"].ToString();
            tbCep.Text = dt.Rows[cont]["cep"].ToString();
            tbcod.Text = dt.Rows[cont]["Id"].ToString();
            tbCpf.Text = dt.Rows[cont]["cpf"].ToString();
            tbData.Text = dt.Rows[cont]["data_nasc"].ToString();
            tbEnd.Text = dt.Rows[cont]["endereco"].ToString();
            tbNome.Text = dt.Rows[cont]["nome"].ToString();
            tbUf.Text = dt.Rows[cont]["uf"].ToString();
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + cad.excluir(tbcod.Text));
            LimpaTextBox();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + cad.alterar(tbcod.Text, tbNome.Text, tbCel.Text, tbCpf.Text, tbEnd.Text, tbData.Text, tbUf.Text, tbCep.Text));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.bdFaturaClienteDataSet.Cliente);
            dataGridView.Update();
            dataGridView.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.ToString();
            btnAtualizar.ToString();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                cont = dataGridView.CurrentCell.RowIndex;
            
                tbcod.Text = row.Cells["Id"].Value.ToString();
                tbNome.Text = row.Cells["nome"].Value.ToString();
                tbCel.Text = row.Cells["telefone"].Value.ToString();
                tbCpf.Text = row.Cells["cpf"].Value.ToString();
                tbEnd.Text = row.Cells["endereco"].Value.ToString();
                tbData.Text = row.Cells["data_nasc"].Value.ToString();
                tbUf.Text = row.Cells["uf"].Value.ToString();
                tbCep.Text = row.Cells["cep"].Value.ToString();

            //MessageBox.Show("" + cont);
           
        }
    }
}