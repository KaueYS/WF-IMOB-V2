namespace WFImobiliaria2
{
    partial class frmCadastro
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
            this.grpOutrasInformacoes = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtValorPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeDoImovelCompra = new System.Windows.Forms.TextBox();
            this.txtNomeImovelVendendo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObeservacoes = new System.Windows.Forms.TextBox();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeDoCliente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbIdentificar = new System.Windows.Forms.GroupBox();
            this.grdCadastro = new System.Windows.Forms.DataGridView();
            this.grpOutrasInformacoes.SuspendLayout();
            this.gbIdentificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOutrasInformacoes
            // 
            this.grpOutrasInformacoes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpOutrasInformacoes.Controls.Add(this.label4);
            this.grpOutrasInformacoes.Controls.Add(this.txtObeservacoes);
            this.grpOutrasInformacoes.Controls.Add(this.btnExcluir);
            this.grpOutrasInformacoes.Controls.Add(this.btnAlterar);
            this.grpOutrasInformacoes.Controls.Add(this.txtValorPedido);
            this.grpOutrasInformacoes.Controls.Add(this.label7);
            this.grpOutrasInformacoes.Controls.Add(this.txtNomeDoImovelCompra);
            this.grpOutrasInformacoes.Controls.Add(this.txtNomeImovelVendendo);
            this.grpOutrasInformacoes.Controls.Add(this.label18);
            this.grpOutrasInformacoes.Controls.Add(this.label17);
            this.grpOutrasInformacoes.Controls.Add(this.btnCadastrar);
            this.grpOutrasInformacoes.Controls.Add(this.btnLimpar);
            this.grpOutrasInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutrasInformacoes.Location = new System.Drawing.Point(470, 12);
            this.grpOutrasInformacoes.Name = "grpOutrasInformacoes";
            this.grpOutrasInformacoes.Size = new System.Drawing.Size(502, 284);
            this.grpOutrasInformacoes.TabIndex = 6;
            this.grpOutrasInformacoes.TabStop = false;
            this.grpOutrasInformacoes.Text = "Identificação do Imovel";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(146, 232);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 34);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(26, 232);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 34);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtValorPedido
            // 
            this.txtValorPedido.BackColor = System.Drawing.SystemColors.Menu;
            this.txtValorPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPedido.Location = new System.Drawing.Point(9, 114);
            this.txtValorPedido.Name = "txtValorPedido";
            this.txtValorPedido.Size = new System.Drawing.Size(179, 23);
            this.txtValorPedido.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Valor";
            // 
            // txtNomeDoImovelCompra
            // 
            this.txtNomeDoImovelCompra.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeDoImovelCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoImovelCompra.Location = new System.Drawing.Point(214, 114);
            this.txtNomeDoImovelCompra.Name = "txtNomeDoImovelCompra";
            this.txtNomeDoImovelCompra.Size = new System.Drawing.Size(272, 23);
            this.txtNomeDoImovelCompra.TabIndex = 7;
            // 
            // txtNomeImovelVendendo
            // 
            this.txtNomeImovelVendendo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeImovelVendendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeImovelVendendo.Location = new System.Drawing.Point(10, 58);
            this.txtNomeImovelVendendo.Name = "txtNomeImovelVendendo";
            this.txtNomeImovelVendendo.Size = new System.Drawing.Size(476, 23);
            this.txtNomeImovelVendendo.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(211, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Nome imovel Interesse";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Nome do Imovel Vendendo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(384, 232);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 34);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(264, 232);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 34);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Observações";
            // 
            // txtObeservacoes
            // 
            this.txtObeservacoes.BackColor = System.Drawing.SystemColors.Menu;
            this.txtObeservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObeservacoes.Location = new System.Drawing.Point(6, 170);
            this.txtObeservacoes.Multiline = true;
            this.txtObeservacoes.Name = "txtObeservacoes";
            this.txtObeservacoes.Size = new System.Drawing.Size(480, 50);
            this.txtObeservacoes.TabIndex = 8;
            // 
            // dtCadastro
            // 
            this.dtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(171, 114);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(156, 23);
            this.dtCadastro.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(168, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Data Cadastro";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(13, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Celular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // mskCelular
            // 
            this.mskCelular.BackColor = System.Drawing.SystemColors.Menu;
            this.mskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.Location = new System.Drawing.Point(13, 114);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(134, 23);
            this.mskCelular.TabIndex = 2;
            // 
            // txtNomeDoCliente
            // 
            this.txtNomeDoCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNomeDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoCliente.Location = new System.Drawing.Point(13, 58);
            this.txtNomeDoCliente.Name = "txtNomeDoCliente";
            this.txtNomeDoCliente.Size = new System.Drawing.Size(422, 23);
            this.txtNomeDoCliente.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(284, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 23);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.Visible = false;
            // 
            // gbIdentificar
            // 
            this.gbIdentificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbIdentificar.Controls.Add(this.txtCodigo);
            this.gbIdentificar.Controls.Add(this.txtNomeDoCliente);
            this.gbIdentificar.Controls.Add(this.mskCelular);
            this.gbIdentificar.Controls.Add(this.label1);
            this.gbIdentificar.Controls.Add(this.dtCadastro);
            this.gbIdentificar.Controls.Add(this.label6);
            this.gbIdentificar.Controls.Add(this.label14);
            this.gbIdentificar.Controls.Add(this.label11);
            this.gbIdentificar.Controls.Add(this.txtEmail);
            this.gbIdentificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentificar.Location = new System.Drawing.Point(12, 12);
            this.gbIdentificar.Name = "gbIdentificar";
            this.gbIdentificar.Size = new System.Drawing.Size(452, 284);
            this.gbIdentificar.TabIndex = 5;
            this.gbIdentificar.TabStop = false;
            this.gbIdentificar.Text = "Identificação do Cliente";
            // 
            // grdCadastro
            // 
            this.grdCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCadastro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCadastro.Location = new System.Drawing.Point(12, 327);
            this.grdCadastro.Name = "grdCadastro";
            this.grdCadastro.ReadOnly = true;
            this.grdCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCadastro.Size = new System.Drawing.Size(960, 307);
            this.grdCadastro.TabIndex = 13;
            this.grdCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCadastro_CellClick);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.grdCadastro);
            this.Controls.Add(this.grpOutrasInformacoes);
            this.Controls.Add(this.gbIdentificar);
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.grpOutrasInformacoes.ResumeLayout(false);
            this.grpOutrasInformacoes.PerformLayout();
            this.gbIdentificar.ResumeLayout(false);
            this.gbIdentificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOutrasInformacoes;
        private System.Windows.Forms.TextBox txtValorPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNomeDoImovelCompra;
        private System.Windows.Forms.TextBox txtNomeImovelVendendo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObeservacoes;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.TextBox txtNomeDoCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbIdentificar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView grdCadastro;
    }
}

