namespace ProjetoFaturamento
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.btnAlteraBanco = new System.Windows.Forms.Button();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.BtnNovoItem = new System.Windows.Forms.Button();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdFaturaDataSet1 = new ProjetoFaturamento.bdFaturaDataSet1();
            this.id_vendaTextBox = new System.Windows.Forms.TextBox();
            this.id_produtoComboBox = new System.Windows.Forms.ComboBox();
            this.produtoTableAdapter = new ProjetoFaturamento.bdFaturaDataSet1TableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new ProjetoFaturamento.bdFaturaDataSet1TableAdapters.TableAdapterManager();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultVend = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlteraBanco
            // 
            this.btnAlteraBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraBanco.ForeColor = System.Drawing.Color.White;
            this.btnAlteraBanco.Location = new System.Drawing.Point(642, 531);
            this.btnAlteraBanco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlteraBanco.Name = "btnAlteraBanco";
            this.btnAlteraBanco.Size = new System.Drawing.Size(140, 35);
            this.btnAlteraBanco.TabIndex = 47;
            this.btnAlteraBanco.Text = "Alterar";
            this.btnAlteraBanco.UseVisualStyleBackColor = true;
            this.btnAlteraBanco.Click += new System.EventHandler(this.btnAlteraBanco_Click);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(730, 150);
            this.lblVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(52, 20);
            this.lblVal.TabIndex = 46;
            this.lblVal.Text = "Valor:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(710, 106);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(71, 20);
            this.lblProduto.TabIndex = 45;
            this.lblProduto.Text = "Produto:";
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(701, 63);
            this.lblIdProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(90, 20);
            this.lblIdProd.TabIndex = 44;
            this.lblIdProd.Text = "Id Produto:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(446, 143);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(52, 20);
            this.lblValor.TabIndex = 43;
            this.lblValor.Text = "Valor:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(400, 106);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(102, 20);
            this.lblQtd.TabIndex = 42;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(426, 63);
            this.lblProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(71, 20);
            this.lblProd.TabIndex = 41;
            this.lblProd.Text = "Produto:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(519, 531);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(112, 35);
            this.btnAtualizar.TabIndex = 40;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(504, 137);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(148, 26);
            this.txtPreco.TabIndex = 39;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(504, 96);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(148, 26);
            this.txtQtde.TabIndex = 38;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(504, 54);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(148, 26);
            this.txtProduto.TabIndex = 37;
            // 
            // BtnNovoItem
            // 
            this.BtnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovoItem.ForeColor = System.Drawing.Color.White;
            this.BtnNovoItem.Location = new System.Drawing.Point(626, 195);
            this.BtnNovoItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoItem.Name = "BtnNovoItem";
            this.BtnNovoItem.Size = new System.Drawing.Size(189, 40);
            this.BtnNovoItem.TabIndex = 36;
            this.BtnNovoItem.Text = "Adicionar novo item";
            this.BtnNovoItem.UseVisualStyleBackColor = true;
            this.BtnNovoItem.Click += new System.EventHandler(this.BtnNovoItem_Click_1);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(790, 140);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(148, 26);
            this.valorTextBox.TabIndex = 34;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bdFaturaDataSet1;
            // 
            // bdFaturaDataSet1
            // 
            this.bdFaturaDataSet1.DataSetName = "bdFaturaDataSet1";
            this.bdFaturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_vendaTextBox
            // 
            this.id_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Id_produto", true));
            this.id_vendaTextBox.Location = new System.Drawing.Point(790, 54);
            this.id_vendaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_vendaTextBox.Name = "id_vendaTextBox";
            this.id_vendaTextBox.ReadOnly = true;
            this.id_vendaTextBox.Size = new System.Drawing.Size(148, 26);
            this.id_vendaTextBox.TabIndex = 33;
            // 
            // id_produtoComboBox
            // 
            this.id_produtoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "descricao", true));
            this.id_produtoComboBox.DisplayMember = "descricao";
            this.id_produtoComboBox.FormattingEnabled = true;
            this.id_produtoComboBox.Location = new System.Drawing.Point(790, 94);
            this.id_produtoComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_produtoComboBox.Name = "id_produtoComboBox";
            this.id_produtoComboBox.Size = new System.Drawing.Size(180, 28);
            this.id_produtoComboBox.TabIndex = 32;
            this.id_produtoComboBox.ValueMember = "Id_produto";
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Item_vendaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoFaturamento.bdFaturaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produtoDataGridView.Location = new System.Drawing.Point(548, 245);
            this.produtoDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.produtoDataGridView.Name = "produtoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.produtoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.produtoDataGridView.Size = new System.Drawing.Size(341, 276);
            this.produtoDataGridView.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(790, 531);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 48;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 630);
            this.panel1.TabIndex = 49;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(218, 398);
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
            this.button2.Location = new System.Drawing.Point(34, 401);
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
            this.btnDash.Location = new System.Drawing.Point(33, 25);
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
            this.btnSair.Location = new System.Drawing.Point(34, 552);
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
            this.btnConsultVend.Location = new System.Drawing.Point(33, 302);
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
            this.btnCadCli.Location = new System.Drawing.Point(35, 208);
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
            this.btnVender.Location = new System.Drawing.Point(31, 119);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(156, 70);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1201, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(this.btnAlteraBanco);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.BtnNovoItem);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.id_vendaTextBox);
            this.Controls.Add(this.id_produtoComboBox);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdFaturaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlteraBanco;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button BtnNovoItem;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox id_vendaTextBox;
        private System.Windows.Forms.ComboBox id_produtoComboBox;
        private bdFaturaDataSet1 bdFaturaDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private bdFaturaDataSet1TableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private bdFaturaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultVend;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnVender;
    }
}