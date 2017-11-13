namespace TCC_Hidracom.Views
{
    partial class PsqFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PsqFuncionario));
            this.dgvHistorico = new MetroFramework.Controls.MetroGrid();
            this.tccpessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
            this.tcc_pessoasTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.tcc_pessoasTableAdapter();
            this.NomeBox = new MetroFramework.Controls.MetroTextBox();
            this.VoltarBtn = new MetroFramework.Controls.MetroButton();
            this.BoxCpf = new MetroFramework.Controls.MetroTextBox();
            this.BoxRg = new MetroFramework.Controls.MetroTextBox();
            this.BoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.BoxTelefone = new MetroFramework.Controls.MetroTextBox();
            this.BoxEndereco = new MetroFramework.Controls.MetroTextBox();
            this.boxNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CancelarBtn = new MetroFramework.Controls.MetroButton();
            this.SalvarBtn = new MetroFramework.Controls.MetroButton();
            this.idpessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccpessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.AllowUserToResizeRows = false;
            this.dgvHistorico.AutoGenerateColumns = false;
            this.dgvHistorico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHistorico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpessoaDataGridViewTextBoxColumn,
            this.nome,
            this.enderecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.dgvHistorico.DataSource = this.tccpessoasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorico.EnableHeadersVisualStyles = false;
            this.dgvHistorico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvHistorico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHistorico.Location = new System.Drawing.Point(7, 109);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(894, 57);
            this.dgvHistorico.TabIndex = 1;
            // 
            // tccpessoasBindingSource
            // 
            this.tccpessoasBindingSource.DataMember = "tcc_pessoas";
            this.tccpessoasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_pessoasTableAdapter
            // 
            this.tcc_pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // NomeBox
            // 
            // 
            // 
            // 
            this.NomeBox.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.NomeBox.CustomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NomeBox.CustomButton.Image = global::TCC_Hidracom.Properties.Resources.active_search;
            this.NomeBox.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.NomeBox.CustomButton.Name = "";
            this.NomeBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NomeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NomeBox.CustomButton.TabIndex = 1;
            this.NomeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NomeBox.CustomButton.UseCustomBackColor = true;
            this.NomeBox.CustomButton.UseSelectable = true;
            this.NomeBox.CustomButton.UseVisualStyleBackColor = false;
            this.NomeBox.Lines = new string[0];
            this.NomeBox.Location = new System.Drawing.Point(7, 63);
            this.NomeBox.MaxLength = 32767;
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.PasswordChar = '\0';
            this.NomeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NomeBox.SelectedText = "";
            this.NomeBox.SelectionLength = 0;
            this.NomeBox.SelectionStart = 0;
            this.NomeBox.ShortcutsEnabled = true;
            this.NomeBox.ShowButton = true;
            this.NomeBox.Size = new System.Drawing.Size(253, 23);
            this.NomeBox.TabIndex = 4;
            this.NomeBox.UseSelectable = true;
            this.NomeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NomeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NomeBox.TextChanged += new System.EventHandler(this.metroButton1_Click);
            this.NomeBox.Click += new System.EventHandler(this.NomeBox_Click);
            // 
            // VoltarBtn
            // 
            this.VoltarBtn.Location = new System.Drawing.Point(525, 308);
            this.VoltarBtn.Name = "VoltarBtn";
            this.VoltarBtn.Size = new System.Drawing.Size(75, 23);
            this.VoltarBtn.TabIndex = 52;
            this.VoltarBtn.Text = "Voltar";
            this.VoltarBtn.UseSelectable = true;
            this.VoltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // BoxCpf
            // 
            // 
            // 
            // 
            this.BoxCpf.CustomButton.Image = null;
            this.BoxCpf.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.BoxCpf.CustomButton.Name = "";
            this.BoxCpf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxCpf.CustomButton.TabIndex = 1;
            this.BoxCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxCpf.CustomButton.UseSelectable = true;
            this.BoxCpf.CustomButton.Visible = false;
            this.BoxCpf.Lines = new string[0];
            this.BoxCpf.Location = new System.Drawing.Point(601, 248);
            this.BoxCpf.MaxLength = 32767;
            this.BoxCpf.Name = "BoxCpf";
            this.BoxCpf.PasswordChar = '\0';
            this.BoxCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxCpf.SelectedText = "";
            this.BoxCpf.SelectionLength = 0;
            this.BoxCpf.SelectionStart = 0;
            this.BoxCpf.ShortcutsEnabled = true;
            this.BoxCpf.Size = new System.Drawing.Size(300, 23);
            this.BoxCpf.TabIndex = 49;
            this.BoxCpf.UseSelectable = true;
            this.BoxCpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxCpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoxRg
            // 
            // 
            // 
            // 
            this.BoxRg.CustomButton.Image = null;
            this.BoxRg.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.BoxRg.CustomButton.Name = "";
            this.BoxRg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxRg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxRg.CustomButton.TabIndex = 1;
            this.BoxRg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxRg.CustomButton.UseSelectable = true;
            this.BoxRg.CustomButton.Visible = false;
            this.BoxRg.Lines = new string[0];
            this.BoxRg.Location = new System.Drawing.Point(601, 210);
            this.BoxRg.MaxLength = 32767;
            this.BoxRg.Name = "BoxRg";
            this.BoxRg.PasswordChar = '\0';
            this.BoxRg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxRg.SelectedText = "";
            this.BoxRg.SelectionLength = 0;
            this.BoxRg.SelectionStart = 0;
            this.BoxRg.ShortcutsEnabled = true;
            this.BoxRg.Size = new System.Drawing.Size(300, 23);
            this.BoxRg.TabIndex = 48;
            this.BoxRg.UseSelectable = true;
            this.BoxRg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxRg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoxEmail
            // 
            // 
            // 
            // 
            this.BoxEmail.CustomButton.Image = null;
            this.BoxEmail.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.BoxEmail.CustomButton.Name = "";
            this.BoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxEmail.CustomButton.TabIndex = 1;
            this.BoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxEmail.CustomButton.UseSelectable = true;
            this.BoxEmail.CustomButton.Visible = false;
            this.BoxEmail.Lines = new string[0];
            this.BoxEmail.Location = new System.Drawing.Point(601, 172);
            this.BoxEmail.MaxLength = 32767;
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.PasswordChar = '\0';
            this.BoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxEmail.SelectedText = "";
            this.BoxEmail.SelectionLength = 0;
            this.BoxEmail.SelectionStart = 0;
            this.BoxEmail.ShortcutsEnabled = true;
            this.BoxEmail.Size = new System.Drawing.Size(300, 23);
            this.BoxEmail.TabIndex = 47;
            this.BoxEmail.UseSelectable = true;
            this.BoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoxTelefone
            // 
            // 
            // 
            // 
            this.BoxTelefone.CustomButton.Image = null;
            this.BoxTelefone.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.BoxTelefone.CustomButton.Name = "";
            this.BoxTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxTelefone.CustomButton.TabIndex = 1;
            this.BoxTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxTelefone.CustomButton.UseSelectable = true;
            this.BoxTelefone.CustomButton.Visible = false;
            this.BoxTelefone.Lines = new string[0];
            this.BoxTelefone.Location = new System.Drawing.Point(125, 261);
            this.BoxTelefone.MaxLength = 32767;
            this.BoxTelefone.Name = "BoxTelefone";
            this.BoxTelefone.PasswordChar = '\0';
            this.BoxTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxTelefone.SelectedText = "";
            this.BoxTelefone.SelectionLength = 0;
            this.BoxTelefone.SelectionStart = 0;
            this.BoxTelefone.ShortcutsEnabled = true;
            this.BoxTelefone.Size = new System.Drawing.Size(300, 23);
            this.BoxTelefone.TabIndex = 46;
            this.BoxTelefone.UseSelectable = true;
            this.BoxTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoxEndereco
            // 
            // 
            // 
            // 
            this.BoxEndereco.CustomButton.Image = null;
            this.BoxEndereco.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.BoxEndereco.CustomButton.Name = "";
            this.BoxEndereco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BoxEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BoxEndereco.CustomButton.TabIndex = 1;
            this.BoxEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BoxEndereco.CustomButton.UseSelectable = true;
            this.BoxEndereco.CustomButton.Visible = false;
            this.BoxEndereco.Lines = new string[0];
            this.BoxEndereco.Location = new System.Drawing.Point(125, 214);
            this.BoxEndereco.MaxLength = 32767;
            this.BoxEndereco.Name = "BoxEndereco";
            this.BoxEndereco.PasswordChar = '\0';
            this.BoxEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BoxEndereco.SelectedText = "";
            this.BoxEndereco.SelectionLength = 0;
            this.BoxEndereco.SelectionStart = 0;
            this.BoxEndereco.ShortcutsEnabled = true;
            this.BoxEndereco.Size = new System.Drawing.Size(300, 23);
            this.BoxEndereco.TabIndex = 43;
            this.BoxEndereco.UseSelectable = true;
            this.BoxEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BoxEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // boxNome
            // 
            // 
            // 
            // 
            this.boxNome.CustomButton.Image = null;
            this.boxNome.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.boxNome.CustomButton.Name = "";
            this.boxNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.boxNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.boxNome.CustomButton.TabIndex = 1;
            this.boxNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.boxNome.CustomButton.UseSelectable = true;
            this.boxNome.CustomButton.Visible = false;
            this.boxNome.Lines = new string[0];
            this.boxNome.Location = new System.Drawing.Point(125, 172);
            this.boxNome.MaxLength = 32767;
            this.boxNome.Name = "boxNome";
            this.boxNome.PasswordChar = '\0';
            this.boxNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxNome.SelectedText = "";
            this.boxNome.SelectionLength = 0;
            this.boxNome.SelectionStart = 0;
            this.boxNome.ShortcutsEnabled = true;
            this.boxNome.Size = new System.Drawing.Size(300, 23);
            this.boxNome.TabIndex = 42;
            this.boxNome.UseSelectable = true;
            this.boxNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.boxNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(14, 261);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 19);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Telefone:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(465, 176);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(44, 19);
            this.metroLabel8.TabIndex = 39;
            this.metroLabel8.Text = "Email:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(465, 252);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "CPF:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(465, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(29, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "RG:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Nome:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 218);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Endereço:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(316, 308);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 31;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseSelectable = true;
            // 
            // SalvarBtn
            // 
            this.SalvarBtn.Location = new System.Drawing.Point(422, 308);
            this.SalvarBtn.Name = "SalvarBtn";
            this.SalvarBtn.Size = new System.Drawing.Size(75, 23);
            this.SalvarBtn.TabIndex = 30;
            this.SalvarBtn.Text = "Salvar";
            this.SalvarBtn.UseSelectable = true;
            // 
            // idpessoaDataGridViewTextBoxColumn
            // 
            this.idpessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idpessoaDataGridViewTextBoxColumn.DataPropertyName = "id_pessoa";
            this.idpessoaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idpessoaDataGridViewTextBoxColumn.Name = "idpessoaDataGridViewTextBoxColumn";
            this.idpessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpessoaDataGridViewTextBoxColumn.Width = 68;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 60;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 78;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 73;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            this.rgDataGridViewTextBoxColumn.Width = 45;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Width = 49;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PsqFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 345);
            this.Controls.Add(this.VoltarBtn);
            this.Controls.Add(this.BoxCpf);
            this.Controls.Add(this.BoxRg);
            this.Controls.Add(this.BoxEmail);
            this.Controls.Add(this.BoxTelefone);
            this.Controls.Add(this.BoxEndereco);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.SalvarBtn);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.dgvHistorico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PsqFuncionario";
            this.Text = "Pesquisa de funcionário";
            this.Load += new System.EventHandler(this.PsqFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccpessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvHistorico;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tccpessoasBindingSource;
        private DataSet1TableAdapters.tcc_pessoasTableAdapter tcc_pessoasTableAdapter;
        private MetroFramework.Controls.MetroTextBox NomeBox;
        private MetroFramework.Controls.MetroButton VoltarBtn;
        private MetroFramework.Controls.MetroTextBox BoxCpf;
        private MetroFramework.Controls.MetroTextBox BoxRg;
        private MetroFramework.Controls.MetroTextBox BoxEmail;
        private MetroFramework.Controls.MetroTextBox BoxTelefone;
        private MetroFramework.Controls.MetroTextBox BoxEndereco;
        private MetroFramework.Controls.MetroTextBox boxNome;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton CancelarBtn;
        private MetroFramework.Controls.MetroButton SalvarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
    }
}