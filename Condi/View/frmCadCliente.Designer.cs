namespace Condi
{
    partial class frmCadCliente
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbInfoContato = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCadastrarAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpInfoPessoal.SuspendLayout();
            this.gbInfoContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpInfoPessoal
            // 
            this.gpInfoPessoal.BackColor = System.Drawing.Color.Transparent;
            this.gpInfoPessoal.Controls.Add(this.maskedTextBox1);
            this.gpInfoPessoal.Controls.Add(this.txtCpf);
            this.gpInfoPessoal.Controls.Add(this.btnConsultar);
            this.gpInfoPessoal.Controls.Add(this.lblRg);
            this.gpInfoPessoal.Controls.Add(this.txtNome);
            this.gpInfoPessoal.Controls.Add(this.lblCpf);
            this.gpInfoPessoal.Controls.Add(this.lblNome);
            this.gpInfoPessoal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpInfoPessoal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpInfoPessoal.Location = new System.Drawing.Point(30, 10);
            this.gpInfoPessoal.Name = "gpInfoPessoal";
            this.gpInfoPessoal.Padding = new System.Windows.Forms.Padding(5);
            this.gpInfoPessoal.Size = new System.Drawing.Size(585, 146);
            this.gpInfoPessoal.TabIndex = 2;
            this.gpInfoPessoal.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(135, 102);
            this.maskedTextBox1.Mask = "99,999,999 - 0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(104, 26);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(9, 102);
            this.txtCpf.Mask = "099,999,999 - 00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(120, 26);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(468, 102);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 36);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(131, 79);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(31, 20);
            this.lblRg.TabIndex = 0;
            this.lblRg.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(562, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(9, 78);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 20);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 22);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gbInfoContato
            // 
            this.gbInfoContato.BackColor = System.Drawing.Color.Transparent;
            this.gbInfoContato.Controls.Add(this.maskedTextBox2);
            this.gbInfoContato.Controls.Add(this.maskedTextBox3);
            this.gbInfoContato.Controls.Add(this.lblCelular);
            this.gbInfoContato.Controls.Add(this.textBox1);
            this.gbInfoContato.Controls.Add(this.lblTelefone);
            this.gbInfoContato.Controls.Add(this.lblEmail);
            this.gbInfoContato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbInfoContato.Location = new System.Drawing.Point(30, 165);
            this.gbInfoContato.Name = "gbInfoContato";
            this.gbInfoContato.Padding = new System.Windows.Forms.Padding(5);
            this.gbInfoContato.Size = new System.Drawing.Size(585, 146);
            this.gbInfoContato.TabIndex = 2;
            this.gbInfoContato.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(147, 101);
            this.maskedTextBox2.Mask = "(99) 99999 - 9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(132, 26);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(9, 101);
            this.maskedTextBox3.Mask = "(99) 9999 - 9999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(132, 26);
            this.maskedTextBox3.TabIndex = 3;
            this.maskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(143, 78);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(61, 20);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 78);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(114, 20);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Tel. residencial";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 22);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // btnCadastrarAtualizar
            // 
            this.btnCadastrarAtualizar.Location = new System.Drawing.Point(273, 317);
            this.btnCadastrarAtualizar.Name = "btnCadastrarAtualizar";
            this.btnCadastrarAtualizar.Size = new System.Drawing.Size(109, 36);
            this.btnCadastrarAtualizar.TabIndex = 4;
            this.btnCadastrarAtualizar.Text = "Cadastrar";
            this.btnCadastrarAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(388, 317);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 36);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(503, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 370);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrarAtualizar);
            this.Controls.Add(this.gbInfoContato);
            this.Controls.Add(this.gpInfoPessoal);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadCliente";
            this.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de clientes";
            this.gpInfoPessoal.ResumeLayout(false);
            this.gpInfoPessoal.PerformLayout();
            this.gbInfoContato.ResumeLayout(false);
            this.gbInfoContato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpInfoPessoal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.GroupBox gbInfoContato;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrarAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}

