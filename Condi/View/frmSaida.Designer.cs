namespace Condi.View
{
    partial class frmSaida
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
            this.gpInfoPessoal = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbTipoServ = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblTipoServ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQtdeParcela = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblVlrParcela = new System.Windows.Forms.Label();
            this.txtVlrParcela = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRegistrarAtualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpInfoPessoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpInfoPessoal
            // 
            this.gpInfoPessoal.BackColor = System.Drawing.Color.Transparent;
            this.gpInfoPessoal.Controls.Add(this.dtpData);
            this.gpInfoPessoal.Controls.Add(this.cbTipoServ);
            this.gpInfoPessoal.Controls.Add(this.lblTipoServ);
            this.gpInfoPessoal.Controls.Add(this.lblData);
            this.gpInfoPessoal.Controls.Add(this.txtVlrParcela);
            this.gpInfoPessoal.Controls.Add(this.lblVlrParcela);
            this.gpInfoPessoal.Controls.Add(this.textBox2);
            this.gpInfoPessoal.Controls.Add(this.lblQtdeParcela);
            this.gpInfoPessoal.Controls.Add(this.txtValor);
            this.gpInfoPessoal.Controls.Add(this.lblValor);
            this.gpInfoPessoal.Controls.Add(this.textBox1);
            this.gpInfoPessoal.Controls.Add(this.label1);
            this.gpInfoPessoal.Controls.Add(this.txtDescricao);
            this.gpInfoPessoal.Controls.Add(this.lblNome);
            this.gpInfoPessoal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpInfoPessoal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpInfoPessoal.Location = new System.Drawing.Point(30, 10);
            this.gpInfoPessoal.Name = "gpInfoPessoal";
            this.gpInfoPessoal.Padding = new System.Windows.Forms.Padding(5);
            this.gpInfoPessoal.Size = new System.Drawing.Size(556, 208);
            this.gpInfoPessoal.TabIndex = 0;
            this.gpInfoPessoal.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 164);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(529, 26);
            this.txtDescricao.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 139);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Descrição";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 83);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(85, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor total";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(13, 108);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.MaxLength = 50;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbTipoServ
            // 
            this.cbTipoServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoServ.FormattingEnabled = true;
            this.cbTipoServ.Items.AddRange(new object[] {
            "Aluguel",
            "Água",
            "Combustível",
            "Compra de materiais",
            "Compra de equipamentos",
            "Compra EPI",
            "Energia",
            "Frete",
            "Serv. terceirizados",
            "Segurança",
            "Outros"});
            this.cbTipoServ.Location = new System.Drawing.Point(308, 108);
            this.cbTipoServ.Name = "cbTipoServ";
            this.cbTipoServ.Size = new System.Drawing.Size(234, 28);
            this.cbTipoServ.TabIndex = 4;
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
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 45);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(115, 26);
            this.dtpData.TabIndex = 0;
            // 
            // lblTipoServ
            // 
            this.lblTipoServ.AutoSize = true;
            this.lblTipoServ.Location = new System.Drawing.Point(304, 85);
            this.lblTipoServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoServ.Name = "lblTipoServ";
            this.lblTipoServ.Size = new System.Drawing.Size(76, 20);
            this.lblTipoServ.TabIndex = 0;
            this.lblTipoServ.Text = "Tipo serv.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorecido";
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
            // lblQtdeParcela
            // 
            this.lblQtdeParcela.AutoSize = true;
            this.lblQtdeParcela.Location = new System.Drawing.Point(112, 83);
            this.lblQtdeParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdeParcela.Name = "lblQtdeParcela";
            this.lblQtdeParcela.Size = new System.Drawing.Size(90, 20);
            this.lblQtdeParcela.TabIndex = 0;
            this.lblQtdeParcela.Text = "Qtde parc.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(91, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVlrParcela
            // 
            this.lblVlrParcela.AutoSize = true;
            this.lblVlrParcela.Location = new System.Drawing.Point(210, 83);
            this.lblVlrParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVlrParcela.Name = "lblVlrParcela";
            this.lblVlrParcela.Size = new System.Drawing.Size(70, 20);
            this.lblVlrParcela.TabIndex = 0;
            this.lblVlrParcela.Text = "Vlr Parc.";
            // 
            // txtVlrParcela
            // 
            this.txtVlrParcela.Enabled = false;
            this.txtVlrParcela.Location = new System.Drawing.Point(210, 108);
            this.txtVlrParcela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVlrParcela.MaxLength = 50;
            this.txtVlrParcela.Name = "txtVlrParcela";
            this.txtVlrParcela.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVlrParcela.Size = new System.Drawing.Size(91, 26);
            this.txtVlrParcela.TabIndex = 3;
            this.txtVlrParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(477, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(362, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 36);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAtualizar
            // 
            this.btnRegistrarAtualizar.Location = new System.Drawing.Point(247, 224);
            this.btnRegistrarAtualizar.Name = "btnRegistrarAtualizar";
            this.btnRegistrarAtualizar.Size = new System.Drawing.Size(109, 36);
            this.btnRegistrarAtualizar.TabIndex = 1;
            this.btnRegistrarAtualizar.Text = "Registrar";
            this.btnRegistrarAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(30, 224);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 36);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 277);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gpInfoPessoal);
            this.Controls.Add(this.btnRegistrarAtualizar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaida";
            this.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.ShowIcon = false;
            this.Text = "Saída";
            this.gpInfoPessoal.ResumeLayout(false);
            this.gpInfoPessoal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpInfoPessoal;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbTipoServ;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblTipoServ;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtVlrParcela;
        private System.Windows.Forms.Label lblVlrParcela;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblQtdeParcela;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnRegistrarAtualizar;
        private System.Windows.Forms.Button btnConsultar;
    }
}