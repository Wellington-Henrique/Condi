namespace Condi.View
{
    partial class frmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoServ = new System.Windows.Forms.ComboBox();
            this.lblTipoServ = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPag = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCarrinho = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlr_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gbDescricao = new System.Windows.Forms.GroupBox();
            this.txtVlrParcela = new System.Windows.Forms.TextBox();
            this.lblVlrParcela = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtdeParcela = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFaturar = new System.Windows.Forms.RadioButton();
            this.rdAtualizar = new System.Windows.Forms.RadioButton();
            this.rdCancelar = new System.Windows.Forms.RadioButton();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblLegendaCarrinho = new System.Windows.Forms.Label();
            this.rdPendente = new System.Windows.Forms.RadioButton();
            this.gpInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.gbDescricao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpInfo
            // 
            this.gpInfo.BackColor = System.Drawing.Color.Transparent;
            this.gpInfo.Controls.Add(this.txtDescricao);
            this.gpInfo.Controls.Add(this.lblObservacao);
            this.gpInfo.Controls.Add(this.btnAddCliente);
            this.gpInfo.Controls.Add(this.dtpData);
            this.gpInfo.Controls.Add(this.lblData);
            this.gpInfo.Controls.Add(this.textBox1);
            this.gpInfo.Controls.Add(this.label1);
            this.gpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpInfo.Location = new System.Drawing.Point(30, 10);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(5);
            this.gpInfo.Size = new System.Drawing.Size(680, 143);
            this.gpInfo.TabIndex = 0;
            this.gpInfo.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 102);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(529, 26);
            this.txtDescricao.TabIndex = 9;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(9, 77);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(103, 20);
            this.lblObservacao.TabIndex = 8;
            this.lblObservacao.Text = "Observação";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(549, 40);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(109, 36);
            this.btnAddCliente.TabIndex = 7;
            this.btnAddCliente.Text = "Adicionar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 45);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(115, 26);
            this.dtpData.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(9, 22);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do cliente";
            // 
            // cbTipoServ
            // 
            this.cbTipoServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServ.FormattingEnabled = true;
            this.cbTipoServ.Items.AddRange(new object[] {
            "Corrimão",
            "Escada",
            "Estruturas",
            "Ferrragens",
            "Grades",
            "Manutenção",
            "Portão",
            "Lixeiras",
            "Outros"});
            this.cbTipoServ.Location = new System.Drawing.Point(169, 47);
            this.cbTipoServ.Name = "cbTipoServ";
            this.cbTipoServ.Size = new System.Drawing.Size(193, 28);
            this.cbTipoServ.TabIndex = 4;
            // 
            // lblTipoServ
            // 
            this.lblTipoServ.AutoSize = true;
            this.lblTipoServ.Location = new System.Drawing.Point(169, 24);
            this.lblTipoServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoServ.Name = "lblTipoServ";
            this.lblTipoServ.Size = new System.Drawing.Size(76, 20);
            this.lblTipoServ.TabIndex = 0;
            this.lblTipoServ.Text = "Tipo serv.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(601, 584);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConcluir.Location = new System.Drawing.Point(486, 584);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(109, 36);
            this.btnConcluir.TabIndex = 1;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forma de pag.";
            // 
            // cbFormaPag
            // 
            this.cbFormaPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPag.FormattingEnabled = true;
            this.cbFormaPag.Items.AddRange(new object[] {
            "Débito",
            "Dinheiro",
            "Cheque",
            "Crédito"});
            this.cbFormaPag.Location = new System.Drawing.Point(13, 47);
            this.cbFormaPag.Name = "cbFormaPag";
            this.cbFormaPag.Size = new System.Drawing.Size(150, 28);
            this.cbFormaPag.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbFormaPag);
            this.groupBox2.Controls.Add(this.lblTipoServ);
            this.groupBox2.Controls.Add(this.cbTipoServ);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(30, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(680, 90);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // gbCarrinho
            // 
            this.gbCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.gbCarrinho.Controls.Add(this.dgvConsulta);
            this.gbCarrinho.Controls.Add(this.pnlBotoes);
            this.gbCarrinho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCarrinho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbCarrinho.Location = new System.Drawing.Point(30, 243);
            this.gbCarrinho.Name = "gbCarrinho";
            this.gbCarrinho.Padding = new System.Windows.Forms.Padding(5);
            this.gbCarrinho.Size = new System.Drawing.Size(680, 149);
            this.gbCarrinho.TabIndex = 14;
            this.gbCarrinho.TabStop = false;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.decricao,
            this.qtde,
            this.medida,
            this.vlr_unitario});
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvConsulta.Location = new System.Drawing.Point(5, 60);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowHeadersWidth = 40;
            this.dgvConsulta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(670, 81);
            this.dgvConsulta.TabIndex = 7;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Cod.";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Width = 60;
            // 
            // decricao
            // 
            this.decricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.decricao.HeaderText = "Descrição";
            this.decricao.Name = "decricao";
            this.decricao.ReadOnly = true;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 120;
            // 
            // medida
            // 
            this.medida.HeaderText = "UN";
            this.medida.Name = "medida";
            this.medida.ReadOnly = true;
            // 
            // vlr_unitario
            // 
            this.vlr_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vlr_unitario.HeaderText = "Vlr UN";
            this.vlr_unitario.Name = "vlr_unitario";
            this.vlr_unitario.ReadOnly = true;
            this.vlr_unitario.Width = 120;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.lblLegendaCarrinho);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(5, 24);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(670, 36);
            this.pnlBotoes.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(566, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 30);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(456, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(104, 30);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // gbDescricao
            // 
            this.gbDescricao.BackColor = System.Drawing.Color.Transparent;
            this.gbDescricao.Controls.Add(this.txtVlrParcela);
            this.gbDescricao.Controls.Add(this.lblVlrParcela);
            this.gbDescricao.Controls.Add(this.txtValor);
            this.gbDescricao.Controls.Add(this.lblValor);
            this.gbDescricao.Controls.Add(this.lblDesc);
            this.gbDescricao.Controls.Add(this.lblQtdeParcela);
            this.gbDescricao.Controls.Add(this.txtDesconto);
            this.gbDescricao.Controls.Add(this.textBox2);
            this.gbDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbDescricao.Location = new System.Drawing.Point(486, 392);
            this.gbDescricao.Name = "gbDescricao";
            this.gbDescricao.Padding = new System.Windows.Forms.Padding(5);
            this.gbDescricao.Size = new System.Drawing.Size(224, 183);
            this.gbDescricao.TabIndex = 16;
            this.gbDescricao.TabStop = false;
            // 
            // txtVlrParcela
            // 
            this.txtVlrParcela.Enabled = false;
            this.txtVlrParcela.Location = new System.Drawing.Point(115, 136);
            this.txtVlrParcela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVlrParcela.MaxLength = 50;
            this.txtVlrParcela.Name = "txtVlrParcela";
            this.txtVlrParcela.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVlrParcela.Size = new System.Drawing.Size(91, 26);
            this.txtVlrParcela.TabIndex = 17;
            this.txtVlrParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVlrParcela
            // 
            this.lblVlrParcela.AutoSize = true;
            this.lblVlrParcela.Location = new System.Drawing.Point(37, 139);
            this.lblVlrParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVlrParcela.Name = "lblVlrParcela";
            this.lblVlrParcela.Size = new System.Drawing.Size(70, 20);
            this.lblVlrParcela.TabIndex = 14;
            this.lblVlrParcela.Text = "Vlr Parc.";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(115, 28);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.MaxLength = 50;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 26);
            this.txtValor.TabIndex = 16;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(22, 31);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(85, 20);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor total";
            // 
            // lblQtdeParcela
            // 
            this.lblQtdeParcela.AutoSize = true;
            this.lblQtdeParcela.Location = new System.Drawing.Point(17, 103);
            this.lblQtdeParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeParcela.Name = "lblQtdeParcela";
            this.lblQtdeParcela.Size = new System.Drawing.Size(90, 20);
            this.lblQtdeParcela.TabIndex = 12;
            this.lblQtdeParcela.Text = "Qtde parc.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 100);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(91, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdPendente);
            this.groupBox1.Controls.Add(this.rdCancelar);
            this.groupBox1.Controls.Add(this.rdAtualizar);
            this.groupBox1.Controls.Add(this.rdFaturar);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(319, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(161, 183);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rdFaturar
            // 
            this.rdFaturar.AutoSize = true;
            this.rdFaturar.Checked = true;
            this.rdFaturar.Location = new System.Drawing.Point(8, 30);
            this.rdFaturar.Name = "rdFaturar";
            this.rdFaturar.Size = new System.Drawing.Size(78, 24);
            this.rdFaturar.TabIndex = 0;
            this.rdFaturar.TabStop = true;
            this.rdFaturar.Text = "Faturar";
            this.rdFaturar.UseVisualStyleBackColor = true;
            // 
            // rdAtualizar
            // 
            this.rdAtualizar.AutoSize = true;
            this.rdAtualizar.Location = new System.Drawing.Point(8, 66);
            this.rdAtualizar.Name = "rdAtualizar";
            this.rdAtualizar.Size = new System.Drawing.Size(89, 24);
            this.rdAtualizar.TabIndex = 0;
            this.rdAtualizar.Text = "Atualizar";
            this.rdAtualizar.UseVisualStyleBackColor = true;
            // 
            // rdCancelar
            // 
            this.rdCancelar.AutoSize = true;
            this.rdCancelar.Location = new System.Drawing.Point(8, 138);
            this.rdCancelar.Name = "rdCancelar";
            this.rdCancelar.Size = new System.Drawing.Size(96, 24);
            this.rdCancelar.TabIndex = 0;
            this.rdCancelar.Text = "Cancelar";
            this.rdCancelar.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(115, 64);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesconto.MaxLength = 50;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDesconto.Size = new System.Drawing.Size(91, 26);
            this.txtDesconto.TabIndex = 13;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(17, 67);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(80, 20);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Desconto";
            // 
            // logo
            // 
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(30, 398);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(283, 178);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 18;
            this.logo.TabStop = false;
            // 
            // lblLegendaCarrinho
            // 
            this.lblLegendaCarrinho.AutoSize = true;
            this.lblLegendaCarrinho.Location = new System.Drawing.Point(-4, 8);
            this.lblLegendaCarrinho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegendaCarrinho.Name = "lblLegendaCarrinho";
            this.lblLegendaCarrinho.Size = new System.Drawing.Size(165, 20);
            this.lblLegendaCarrinho.TabIndex = 4;
            this.lblLegendaCarrinho.Text = "Materiais necessários";
            // 
            // rdPendente
            // 
            this.rdPendente.AutoSize = true;
            this.rdPendente.Location = new System.Drawing.Point(8, 102);
            this.rdPendente.Name = "rdPendente";
            this.rdPendente.Size = new System.Drawing.Size(99, 24);
            this.rdPendente.TabIndex = 0;
            this.rdPendente.Text = "Pendente";
            this.rdPendente.UseVisualStyleBackColor = true;
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 633);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDescricao);
            this.Controls.Add(this.gbCarrinho);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.btnConcluir);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrada";
            this.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.ShowIcon = false;
            this.Text = "Entrada";
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCarrinho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.gbDescricao.ResumeLayout(false);
            this.gbDescricao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbTipoServ;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblTipoServ;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.ComboBox cbFormaPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbCarrinho;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn decricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlr_unitario;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.GroupBox gbDescricao;
        private System.Windows.Forms.TextBox txtVlrParcela;
        private System.Windows.Forms.Label lblVlrParcela;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtdeParcela;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCancelar;
        private System.Windows.Forms.RadioButton rdAtualizar;
        private System.Windows.Forms.RadioButton rdFaturar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblLegendaCarrinho;
        private System.Windows.Forms.RadioButton rdPendente;
    }
}