namespace TCC_Hidracom.Views
{
    partial class CadOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataMarcada = new MetroFramework.Controls.MetroDateTime();
            this.produtoBox = new MetroFramework.Controls.MetroComboBox();
            this.tccprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
            this.pro = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CampoTexto = new System.Windows.Forms.RichTextBox();
            this.servicoss = new MetroFramework.Controls.MetroComboBox();
            this.tccobservacaoservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicoss = new MetroFramework.Controls.MetroComboBox();
            this.tccpessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCliente = new MetroFramework.Controls.MetroTextBox();
            this.dgvCliente = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.tcc_pessoasTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.tcc_pessoasTableAdapter();
            this.tcc_observacao_servicosTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.tcc_observacao_servicosTableAdapter();
            this.tcc_produtoTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.tcc_produtoTableAdapter();
            this.btnVol = new MetroFramework.Controls.MetroButton();
            this.btnAva = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccobservacaoservicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccpessoasBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataMarcada);
            this.groupBox1.Controls.Add(this.produtoBox);
            this.groupBox1.Controls.Add(this.pro);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.CampoTexto);
            this.groupBox1.Controls.Add(this.servicoss);
            this.groupBox1.Controls.Add(this.tecnicoss);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(21, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dataMarcada
            // 
            this.dataMarcada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataMarcada.Location = new System.Drawing.Point(92, 110);
            this.dataMarcada.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataMarcada.Name = "dataMarcada";
            this.dataMarcada.Size = new System.Drawing.Size(104, 29);
            this.dataMarcada.TabIndex = 24;
            // 
            // produtoBox
            // 
            this.produtoBox.DataSource = this.tccprodutoBindingSource;
            this.produtoBox.DisplayMember = "descricao";
            this.produtoBox.FormattingEnabled = true;
            this.produtoBox.ItemHeight = 23;
            this.produtoBox.Location = new System.Drawing.Point(545, 110);
            this.produtoBox.Name = "produtoBox";
            this.produtoBox.Size = new System.Drawing.Size(326, 29);
            this.produtoBox.TabIndex = 23;
            this.produtoBox.UseSelectable = true;
            this.produtoBox.ValueMember = "id_produto";
            // 
            // tccprodutoBindingSource
            // 
            this.tccprodutoBindingSource.DataMember = "tcc_produto";
            this.tccprodutoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro
            // 
            this.pro.AutoSize = true;
            this.pro.Location = new System.Drawing.Point(479, 110);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(60, 19);
            this.pro.TabIndex = 22;
            this.pro.Text = "Produto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Serviço:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(471, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Descrição:";
            // 
            // CampoTexto
            // 
            this.CampoTexto.Location = new System.Drawing.Point(545, 16);
            this.CampoTexto.Name = "CampoTexto";
            this.CampoTexto.Size = new System.Drawing.Size(326, 83);
            this.CampoTexto.TabIndex = 19;
            this.CampoTexto.Text = "Adicione aqui a descrição do serviço.";
            // 
            // servicoss
            // 
            this.servicoss.DataSource = this.tccobservacaoservicosBindingSource;
            this.servicoss.DisplayMember = "nome_servico";
            this.servicoss.FormattingEnabled = true;
            this.servicoss.ItemHeight = 23;
            this.servicoss.Location = new System.Drawing.Point(92, 61);
            this.servicoss.Name = "servicoss";
            this.servicoss.Size = new System.Drawing.Size(314, 29);
            this.servicoss.TabIndex = 21;
            this.servicoss.UseSelectable = true;
            this.servicoss.ValueMember = "id_observacao_servicos";
            // 
            // tccobservacaoservicosBindingSource
            // 
            this.tccobservacaoservicosBindingSource.DataMember = "tcc_observacao_servicos";
            this.tccobservacaoservicosBindingSource.DataSource = this.dataSet1;
            // 
            // tecnicoss
            // 
            this.tecnicoss.DataSource = this.tccpessoasBindingSource;
            this.tecnicoss.DisplayMember = "nome";
            this.tecnicoss.FormattingEnabled = true;
            this.tecnicoss.ItemHeight = 23;
            this.tecnicoss.Location = new System.Drawing.Point(92, 16);
            this.tecnicoss.Name = "tecnicoss";
            this.tecnicoss.Size = new System.Drawing.Size(222, 29);
            this.tecnicoss.TabIndex = 15;
            this.tecnicoss.UseSelectable = true;
            this.tecnicoss.ValueMember = "id_pessoa";
            this.tecnicoss.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Ocorreu em:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Técnico:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(163, 24);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 11;
            this.metroUserControl1.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAva);
            this.groupBox2.Controls.Add(this.btnVol);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.dgvCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 200);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione o Cliente:";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.CustomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.CustomButton.Image = global::TCC_Hidracom.Properties.Resources.active_search;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseCustomBackColor = true;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.UseVisualStyleBackColor = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(7, 23);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.ShowButton = true;
            this.txtNome.Size = new System.Drawing.Size(253, 23);
            this.txtNome.TabIndex = 12;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.TextChanged += new System.EventHandler(this.NomeBox_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(335, 23);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Cliente:";
            // 
            // txtCliente
            // 
            // 
            // 
            // 
            this.txtCliente.CustomButton.Image = null;
            this.txtCliente.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtCliente.CustomButton.Name = "";
            this.txtCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCliente.CustomButton.TabIndex = 1;
            this.txtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCliente.CustomButton.UseSelectable = true;
            this.txtCliente.CustomButton.Visible = false;
            this.txtCliente.Lines = new string[0];
            this.txtCliente.Location = new System.Drawing.Point(393, 23);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.ShortcutsEnabled = true;
            this.txtCliente.Size = new System.Drawing.Size(171, 23);
            this.txtCliente.TabIndex = 10;
            this.txtCliente.UseSelectable = true;
            this.txtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.TextChanged += new System.EventHandler(this.metroTextBox1_Click);
            this.txtCliente.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCliente.Location = new System.Drawing.Point(6, 49);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(867, 119);
            this.dgvCliente.TabIndex = 9;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(454, 428);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Gravar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton2.Location = new System.Drawing.Point(373, 428);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tcc_pessoasTableAdapter
            // 
            this.tcc_pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_observacao_servicosTableAdapter
            // 
            this.tcc_observacao_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_produtoTableAdapter
            // 
            this.tcc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btnVol
            // 
            this.btnVol.Location = new System.Drawing.Point(6, 171);
            this.btnVol.Name = "btnVol";
            this.btnVol.Size = new System.Drawing.Size(75, 23);
            this.btnVol.TabIndex = 16;
            this.btnVol.Text = "<< Voltar";
            this.btnVol.UseSelectable = true;
            this.btnVol.Click += new System.EventHandler(this.btnVol_Click);
            // 
            // btnAva
            // 
            this.btnAva.Location = new System.Drawing.Point(796, 171);
            this.btnAva.Name = "btnAva";
            this.btnAva.Size = new System.Drawing.Size(75, 23);
            this.btnAva.TabIndex = 17;
            this.btnAva.Text = "Avançar >>";
            this.btnAva.UseSelectable = true;
            this.btnAva.Click += new System.EventHandler(this.btnAva_Click);
            // 
            // CadOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 464);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadOS";
            this.Text = "Cadastro de Ordem de O.S";
            this.Load += new System.EventHandler(this.CadOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccobservacaoservicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccpessoasBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroComboBox tecnicoss;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid dgvCliente;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.tcc_pessoasTableAdapter tcc_pessoasTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.RichTextBox CampoTexto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCliente;
        private MetroFramework.Controls.MetroComboBox servicoss;
        private System.Windows.Forms.BindingSource tccpessoasBindingSource;
        private System.Windows.Forms.BindingSource tccobservacaoservicosBindingSource;
        private DataSet1TableAdapters.tcc_observacao_servicosTableAdapter tcc_observacao_servicosTableAdapter;
        private MetroFramework.Controls.MetroComboBox produtoBox;
        private MetroFramework.Controls.MetroLabel pro;
        private System.Windows.Forms.BindingSource tccprodutoBindingSource;
        private DataSet1TableAdapters.tcc_produtoTableAdapter tcc_produtoTableAdapter;
        private MetroFramework.Controls.MetroDateTime dataMarcada;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroButton btnAva;
        private MetroFramework.Controls.MetroButton btnVol;
    }
}