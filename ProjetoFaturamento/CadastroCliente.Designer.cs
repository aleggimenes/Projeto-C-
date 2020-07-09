namespace ProjetoFaturamento
{
    partial class CadastroCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
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
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdFaturaDataSet = new ProjetoFaturamento.bdFaturaDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoTableAdapter = new ProjetoFaturamento.bdFaturaDataSetTableAdapters.TipoTableAdapter();
            this.tableAdapterManager = new ProjetoFaturamento.bdFaturaDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultVend = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaClienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(392, 170);
            this.tbCep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbCep.Mask = "00000-999";
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(148, 26);
            this.tbCep.TabIndex = 6;
            // 
            // tbUf
            // 
            this.tbUf.Location = new System.Drawing.Point(889, 89);
            this.tbUf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(148, 26);
            this.tbUf.TabIndex = 5;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(392, 98);
            this.tbCpf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbCpf.Mask = "000.999.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(148, 26);
            this.tbCpf.TabIndex = 2;
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(392, 206);
            this.tbCel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbCel.Mask = "(999) 00000-0000";
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(148, 26);
            this.tbCel.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(889, 53);
            this.tbData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbData.Mask = "00/00/0000";
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(148, 26);
            this.tbData.TabIndex = 4;
            this.tbData.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento:";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(392, 134);
            this.tbEnd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(284, 26);
            this.tbEnd.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(392, 56);
            this.tbNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(284, 26);
            this.tbNome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Endereço:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(905, 197);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(111, 35);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(262, 299);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Size = new System.Drawing.Size(840, 256);
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
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.ForeColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(852, 565);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(111, 35);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Excluir
            // 
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.ForeColor = System.Drawing.Color.White;
            this.Excluir.Location = new System.Drawing.Point(390, 564);
            this.Excluir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(111, 35);
            this.Excluir.TabIndex = 20;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Código:";
            // 
            // tbcod
            // 
            this.tbcod.Enabled = false;
            this.tbcod.Location = new System.Drawing.Point(392, 14);
            this.tbcod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbcod.Name = "tbcod";
            this.tbcod.Size = new System.Drawing.Size(284, 26);
            this.tbcod.TabIndex = 22;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnprimeiro
            // 
            this.btnprimeiro.ForeColor = System.Drawing.Color.Black;
            this.btnprimeiro.Location = new System.Drawing.Point(466, 256);
            this.btnprimeiro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnprimeiro.Name = "btnprimeiro";
            this.btnprimeiro.Size = new System.Drawing.Size(111, 35);
            this.btnprimeiro.TabIndex = 24;
            this.btnprimeiro.Text = "<<";
            this.btnprimeiro.UseVisualStyleBackColor = true;
            this.btnprimeiro.Click += new System.EventHandler(this.btnprimeiro_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.ForeColor = System.Drawing.Color.Black;
            this.btnanterior.Location = new System.Drawing.Point(588, 254);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(111, 35);
            this.btnanterior.TabIndex = 25;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.ForeColor = System.Drawing.Color.Black;
            this.btnproximo.Location = new System.Drawing.Point(710, 254);
            this.btnproximo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(111, 35);
            this.btnproximo.TabIndex = 26;
            this.btnproximo.Text = ">";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.ForeColor = System.Drawing.Color.Black;
            this.btnultimo.Location = new System.Drawing.Point(836, 254);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(111, 35);
            this.btnultimo.TabIndex = 27;
            this.btnultimo.Text = ">>";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.ForeColor = System.Drawing.Color.White;
            this.btnalterar.Location = new System.Drawing.Point(551, 565);
            this.btnalterar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(111, 35);
            this.btnalterar.TabIndex = 28;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(711, 564);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(111, 35);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboTipo
            // 
            this.comboTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoBindingSource, "Tipo_cliente", true));
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.comboTipo.Location = new System.Drawing.Point(889, 15);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(178, 28);
            this.comboTipo.TabIndex = 30;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "Tipo";
            this.tipoBindingSource.DataSource = this.bdFaturaDataSet;
            // 
            // bdFaturaDataSet
            // 
            this.bdFaturaDataSet.DataSetName = "bdFaturaDataSet";
            this.bdFaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(825, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tipo:";
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.TipoTableAdapter = this.tipoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoFaturamento.bdFaturaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnConsultVend);
            this.panel1.Controls.Add(this.btnCadCli);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 630);
            this.panel1.TabIndex = 33;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(218, 208);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 73);
            this.panelLeft.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(30, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 70);
            this.button2.TabIndex = 12;
            this.button2.Text = "Produto";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDash
            // 
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDash.Location = new System.Drawing.Point(30, 25);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(156, 70);
            this.btnDash.TabIndex = 10;
            this.btnDash.Text = "Dashboard";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(31, 538);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 70);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultVend
            // 
            this.btnConsultVend.FlatAppearance.BorderSize = 0;
            this.btnConsultVend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultVend.ForeColor = System.Drawing.Color.White;
            this.btnConsultVend.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultVend.Image")));
            this.btnConsultVend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultVend.Location = new System.Drawing.Point(30, 302);
            this.btnConsultVend.Name = "btnConsultVend";
            this.btnConsultVend.Size = new System.Drawing.Size(153, 70);
            this.btnConsultVend.TabIndex = 9;
            this.btnConsultVend.Text = "Relatório";
            this.btnConsultVend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultVend.UseVisualStyleBackColor = true;
            this.btnConsultVend.Click += new System.EventHandler(this.btnConsultVend_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.FlatAppearance.BorderSize = 0;
            this.btnCadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCli.ForeColor = System.Drawing.Color.White;
            this.btnCadCli.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCli.Image")));
            this.btnCadCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadCli.Location = new System.Drawing.Point(32, 208);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(149, 70);
            this.btnCadCli.TabIndex = 8;
            this.btnCadCli.Text = "Cliente";
            this.btnCadCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnVender
            // 
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Image = ((System.Drawing.Image)(resources.GetObject("btnVender.Image")));
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVender.Location = new System.Drawing.Point(30, 119);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(156, 70);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1201, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcod);
            this.Controls.Add(this.tbCep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.tbCel);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnprimeiro);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbData);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaClienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label8;
        private bdFaturaDataSet bdFaturaDataSet;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private bdFaturaDataSetTableAdapters.TipoTableAdapter tipoTableAdapter;
        private bdFaturaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultVend;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panelLeft;
    }
}

