namespace Condi.View
{
    partial class frmConSaida
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
            this.cbTipoServ = new System.Windows.Forms.ComboBox();
            this.lblTipoServ = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpInfoPessoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gpInfoPessoal
            // 
            this.gpInfoPessoal.BackColor = System.Drawing.Color.Transparent;
            this.gpInfoPessoal.Controls.Add(this.cbTipoServ);
            this.gpInfoPessoal.Controls.Add(this.lblTipoServ);
            this.gpInfoPessoal.Controls.Add(this.dateTimePicker1);
            this.gpInfoPessoal.Controls.Add(this.lblDataFim);
            this.gpInfoPessoal.Controls.Add(this.dtpData);
            this.gpInfoPessoal.Controls.Add(this.lblDataInicio);
            this.gpInfoPessoal.Controls.Add(this.btnConsultar);
            this.gpInfoPessoal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpInfoPessoal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpInfoPessoal.Location = new System.Drawing.Point(30, 10);
            this.gpInfoPessoal.Name = "gpInfoPessoal";
            this.gpInfoPessoal.Padding = new System.Windows.Forms.Padding(5);
            this.gpInfoPessoal.Size = new System.Drawing.Size(502, 130);
            this.gpInfoPessoal.TabIndex = 4;
            this.gpInfoPessoal.TabStop = false;
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
            "Todos",
            "Outros"});
            this.cbTipoServ.Location = new System.Drawing.Point(255, 47);
            this.cbTipoServ.Name = "cbTipoServ";
            this.cbTipoServ.Size = new System.Drawing.Size(234, 28);
            this.cbTipoServ.TabIndex = 6;
            // 
            // lblTipoServ
            // 
            this.lblTipoServ.AutoSize = true;
            this.lblTipoServ.Location = new System.Drawing.Point(251, 24);
            this.lblTipoServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoServ.Name = "lblTipoServ";
            this.lblTipoServ.Size = new System.Drawing.Size(76, 20);
            this.lblTipoServ.TabIndex = 5;
            this.lblTipoServ.Text = "Tipo serv.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(130, 24);
            this.lblDataFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(94, 20);
            this.lblDataFim.TabIndex = 3;
            this.lblDataFim.Text = "Data de fim";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 47);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(115, 26);
            this.dtpData.TabIndex = 2;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(9, 24);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(111, 20);
            this.lblDataInicio.TabIndex = 3;
            this.lblDataInicio.Text = "Data de inicio";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(380, 81);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 36);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.tipo_serv,
            this.qtde_parcela,
            this.vlrTotal});
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvConsulta.Location = new System.Drawing.Point(30, 140);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowHeadersWidth = 40;
            this.dgvConsulta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(502, 169);
            this.dgvConsulta.TabIndex = 6;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 90;
            // 
            // tipo_serv
            // 
            this.tipo_serv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_serv.HeaderText = "Tipo serv.";
            this.tipo_serv.Name = "tipo_serv";
            this.tipo_serv.ReadOnly = true;
            // 
            // qtde_parcela
            // 
            this.qtde_parcela.HeaderText = "Qtde parc.";
            this.qtde_parcela.Name = "qtde_parcela";
            this.qtde_parcela.ReadOnly = true;
            this.qtde_parcela.Width = 115;
            // 
            // vlrTotal
            // 
            this.vlrTotal.HeaderText = "Total";
            this.vlrTotal.Name = "vlrTotal";
            this.vlrTotal.ReadOnly = true;
            // 
            // frmConSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 329);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.gpInfoPessoal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConSaida";
            this.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.ShowIcon = false;
            this.Text = "Consulta de cliente";
            this.gpInfoPessoal.ResumeLayout(false);
            this.gpInfoPessoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpInfoPessoal;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.ComboBox cbTipoServ;
        private System.Windows.Forms.Label lblTipoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrTotal;
    }
}