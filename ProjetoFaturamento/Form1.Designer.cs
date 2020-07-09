namespace ProjetoFaturamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbCep = new System.Windows.Forms.MaskedTextBox();
            this.tbUf = new System.Windows.Forms.MaskedTextBox();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbCel = new System.Windows.Forms.MaskedTextBox();
            this.tbData = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdFaturaClienteDataSet = new ProjetoFaturamento.bdFaturaClienteDataSet();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcod = new System.Windows.Forms.MaskedTextBox();
            this.clienteTableAdapter = new ProjetoFaturamento.bdFaturaClienteDataSetTableAdapters.ClienteTableAdapter();
            this.btnprimeiro = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaClienteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(136, 214);
            this.tbCep.Mask = "00000-999";
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(100, 20);
            this.tbCep.TabIndex = 6;
            // 
            // tbUf
            // 
            this.tbUf.Location = new System.Drawing.Point(136, 188);
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(100, 20);
            this.tbUf.TabIndex = 5;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(136, 110);
            this.tbCpf.Mask = "000.999.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(100, 20);
            this.tbCpf.TabIndex = 2;
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(136, 84);
            this.tbCel.Mask = "(999) 00000-0000";
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(100, 20);
            this.tbCel.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(136, 162);
            this.tbData.Mask = "00/00/0000";
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 4;
            this.tbData.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(136, 136);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(192, 20);
            this.tbEnd.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(136, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(192, 20);
            this.tbNome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Endereço:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(764, 81);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nome,
            this.telefone,
            this.cpf,
            this.endereco,
            this.data_nasc,
            this.uf,
            this.cep});
            this.dataGridView.DataSource = this.clienteBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(21, 260);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(834, 459);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // data_nasc
            // 
            this.data_nasc.DataPropertyName = "data_nasc";
            this.data_nasc.HeaderText = "data_nasc";
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "uf";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "cep";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bdFaturaClienteDataSet;
            // 
            // bdFaturaClienteDataSet
            // 
            this.bdFaturaClienteDataSet.DataSetName = "bdFaturaClienteDataSet";
            this.bdFaturaClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(764, 112);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(764, 141);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 20;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cod";
            // 
            // tbcod
            // 
            this.tbcod.Enabled = false;
            this.tbcod.Location = new System.Drawing.Point(136, 32);
            this.tbcod.Name = "tbcod";
            this.tbcod.Size = new System.Drawing.Size(192, 20);
            this.tbcod.TabIndex = 22;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnprimeiro
            // 
            this.btnprimeiro.Location = new System.Drawing.Point(260, 216);
            this.btnprimeiro.Name = "btnprimeiro";
            this.btnprimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnprimeiro.TabIndex = 24;
            this.btnprimeiro.Text = "<<";
            this.btnprimeiro.UseVisualStyleBackColor = true;
            this.btnprimeiro.Click += new System.EventHandler(this.btnprimeiro_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(342, 215);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(75, 23);
            this.btnanterior.TabIndex = 25;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.Location = new System.Drawing.Point(423, 215);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(75, 23);
            this.btnproximo.TabIndex = 26;
            this.btnproximo.Text = ">";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(507, 215);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(75, 23);
            this.btnultimo.TabIndex = 27;
            this.btnultimo.Text = ">>";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(764, 170);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 28;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(764, 199);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.comboBox1.Location = new System.Drawing.Point(645, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 736);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimeiro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbcod);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCel);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbUf);
            this.Controls.Add(this.tbCep);
            this.Name = "Form1";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaClienteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbCep;
        private System.Windows.Forms.MaskedTextBox tbUf;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private System.Windows.Forms.MaskedTextBox tbCel;
        private System.Windows.Forms.MaskedTextBox tbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.MaskedTextBox tbNome;
        private System.Windows.Forms.DataGridView dataGridView;
        private bdFaturaClienteDataSet bdFaturaClienteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bdFaturaClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox tbcod;
        private System.Windows.Forms.Button btnprimeiro;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

