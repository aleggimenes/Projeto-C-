﻿using System;
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
    
    public partial class CadastroCliente : Form
    {
        
        Cliente cad = new Cliente();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        int cont, cont2;
        
        public CadastroCliente()
        {
            InitializeComponent();
            cont = cad.consultar().Rows.Count - 1;

        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cad.cadastrar(tbNome.Text, tbCel.Text, tbCpf.Text, tbEnd.Text, tbData.Text, tbUf.Text, tbCep.Text, comboTipo.Text);
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
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaDataSet.Tipo'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoTableAdapter.Fill(this.bdFaturaDataSet.Tipo);
            // TODO: esta linha de código carrega dados na tabela 'bdFaturaClienteDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bdFaturaClienteDataSet.Cliente);

            timer1.Start();
            comboTipo.Text = null;
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
            comboTipo.Text = "";
        }
      
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }

        private void btnprimeiro_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();
            dt2 = cad.tipoCliente();

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

            if (dt2.Rows.Count > 0)
            {
                cont2 = 0;

                comboTipo.Text = dt2.Rows[cont2]["Tipo_cliente"].ToString();
            }
        }
        private void btnanterior_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();
            dt2 = cad.tipoCliente();

            if (cont == dt.Rows.Count - 1 || cont != 0)
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

            if (cont2 == dt2.Rows.Count - 1 || cont2 !=0)
            {
                cont2--;

                comboTipo.Text = dt2.Rows[cont2]["Tipo_cliente"].ToString();
            }
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();
            dt2 = cad.tipoCliente();

            if (cont < dt.Rows.Count - 1)
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

            if(cont2 < dt2.Rows.Count - 1)
            {
                cont2++;
                comboTipo.Text = dt2.Rows[cont2]["Tipo_cliente"].ToString();
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            dt = cad.consultar();
            dt2 = cad.tipoCliente();

            cont = dt.Rows.Count - 1;
            cont2 = dt2.Rows.Count - 1;

            tbCel.Text = dt.Rows[cont]["telefone"].ToString();
            tbCep.Text = dt.Rows[cont]["cep"].ToString();
            tbcod.Text = dt.Rows[cont]["Id"].ToString();
            tbCpf.Text = dt.Rows[cont]["cpf"].ToString();
            tbData.Text = dt.Rows[cont]["data_nasc"].ToString();
            tbEnd.Text = dt.Rows[cont]["endereco"].ToString();
            tbNome.Text = dt.Rows[cont]["nome"].ToString();
            tbUf.Text = dt.Rows[cont]["uf"].ToString();

            comboTipo.Text = dt2.Rows[cont2]["Tipo_cliente"].ToString();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + cad.excluir(tbcod.Text, tbcod.Text));
            LimpaTextBox();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + cad.alterar(tbcod.Text, tbNome.Text, tbCel.Text, tbCpf.Text, tbEnd.Text, tbData.Text, tbUf.Text, tbCep.Text, comboTipo.Text));
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

        private void tipoCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroProduto abrir = new CadastroProduto();
            abrir.Show();
            this.Hide();

        }

        private void btnConsultVend_Click(object sender, EventArgs e)
        {
            ConsultaVendas abrir = new ConsultaVendas();
            abrir.Show();
            this.Hide();

        }
    }
}