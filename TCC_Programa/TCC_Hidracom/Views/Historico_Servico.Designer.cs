namespace TCC_Hidracom.Views
{
    partial class Historico_Servico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistorico = new MetroFramework.Controls.MetroGrid();
<<<<<<< HEAD
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.NomeBox = new MetroFramework.Controls.MetroTextBox();
=======
            this.gethistoricoservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.NomeBox = new MetroFramework.Controls.MetroTextBox();
            this.get_historico_servicosTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.get_historico_servicosTableAdapter();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
>>>>>>> master
            this.idservicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamarcadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            this.gethistoricoservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
            this.get_historico_servicosTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.get_historico_servicosTableAdapter();
=======
>>>>>>> master
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gethistoricoservicosBindingSource)).BeginInit();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idservicosDataGridViewTextBoxColumn,
            this.nometecnicoDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.nomeservicoDataGridViewTextBoxColumn,
            this.datamarcadaDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.dgvHistorico.DataSource = this.gethistoricoservicosBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistorico.EnableHeadersVisualStyles = false;
            this.dgvHistorico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvHistorico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHistorico.Location = new System.Drawing.Point(23, 111);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(849, 332);
            this.dgvHistorico.TabIndex = 0;
            this.dgvHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellContentClick);
            // 
<<<<<<< HEAD
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton2.Location = new System.Drawing.Point(410, 449);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
=======
            // gethistoricoservicosBindingSource
            // 
            this.gethistoricoservicosBindingSource.DataMember = "get_historico_servicos";
            this.gethistoricoservicosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 80);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Pesquisar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
>>>>>>> master
            // 
            // NomeBox
            // 
            // 
            // 
            // 
<<<<<<< HEAD
            this.NomeBox.CustomButton.BackgroundImage = global::TCC_Hidracom.Properties.Resources.active_search;
            this.NomeBox.CustomButton.Image = null;
            this.NomeBox.CustomButton.Location = new System.Drawing.Point(231, 1);
=======
            this.NomeBox.CustomButton.Image = null;
            this.NomeBox.CustomButton.Location = new System.Drawing.Point(94, 1);
>>>>>>> master
            this.NomeBox.CustomButton.Name = "";
            this.NomeBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NomeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NomeBox.CustomButton.TabIndex = 1;
            this.NomeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NomeBox.CustomButton.UseSelectable = true;
            this.NomeBox.CustomButton.Visible = false;
            this.NomeBox.Lines = new string[0];
<<<<<<< HEAD
            this.NomeBox.Location = new System.Drawing.Point(23, 80);
=======
            this.NomeBox.Location = new System.Drawing.Point(160, 80);
>>>>>>> master
            this.NomeBox.MaxLength = 32767;
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.PasswordChar = '\0';
            this.NomeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NomeBox.SelectedText = "";
            this.NomeBox.SelectionLength = 0;
            this.NomeBox.SelectionStart = 0;
            this.NomeBox.ShortcutsEnabled = true;
<<<<<<< HEAD
            this.NomeBox.Size = new System.Drawing.Size(253, 23);
=======
            this.NomeBox.Size = new System.Drawing.Size(116, 23);
>>>>>>> master
            this.NomeBox.TabIndex = 2;
            this.NomeBox.UseSelectable = true;
            this.NomeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NomeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
<<<<<<< HEAD
            this.NomeBox.TextChanged += new System.EventHandler(this.metroButton1_Click);
            this.NomeBox.Click += new System.EventHandler(this.metroTextBox1_Click);
=======
            this.NomeBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // get_historico_servicosTableAdapter
            // 
            this.get_historico_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton2.Location = new System.Drawing.Point(410, 449);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
>>>>>>> master
            // 
            // idservicosDataGridViewTextBoxColumn
            // 
            this.idservicosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idservicosDataGridViewTextBoxColumn.DataPropertyName = "id_servicos";
            this.idservicosDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idservicosDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idservicosDataGridViewTextBoxColumn.Name = "idservicosDataGridViewTextBoxColumn";
            this.idservicosDataGridViewTextBoxColumn.ReadOnly = true;
            this.idservicosDataGridViewTextBoxColumn.Width = 68;
            // 
            // nometecnicoDataGridViewTextBoxColumn
            // 
            this.nometecnicoDataGridViewTextBoxColumn.DataPropertyName = "nome_tecnico";
            this.nometecnicoDataGridViewTextBoxColumn.HeaderText = "Técnico";
            this.nometecnicoDataGridViewTextBoxColumn.Name = "nometecnicoDataGridViewTextBoxColumn";
            this.nometecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeservicoDataGridViewTextBoxColumn
            // 
            this.nomeservicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeservicoDataGridViewTextBoxColumn.DataPropertyName = "nome_servico";
            this.nomeservicoDataGridViewTextBoxColumn.HeaderText = "Serviço";
            this.nomeservicoDataGridViewTextBoxColumn.Name = "nomeservicoDataGridViewTextBoxColumn";
            this.nomeservicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeservicoDataGridViewTextBoxColumn.Width = 66;
            // 
            // datamarcadaDataGridViewTextBoxColumn
            // 
            this.datamarcadaDataGridViewTextBoxColumn.DataPropertyName = "data_marcada";
            this.datamarcadaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.datamarcadaDataGridViewTextBoxColumn.HeaderText = "Data Marcada";
            this.datamarcadaDataGridViewTextBoxColumn.Name = "datamarcadaDataGridViewTextBoxColumn";
            this.datamarcadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.FillWeight = 300F;
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
<<<<<<< HEAD
            // 
            // gethistoricoservicosBindingSource
            // 
            this.gethistoricoservicosBindingSource.DataMember = "get_historico_servicos";
            this.gethistoricoservicosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_historico_servicosTableAdapter
            // 
            this.get_historico_servicosTableAdapter.ClearBeforeFill = true;
=======
>>>>>>> master
            // 
            // Historico_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 482);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.NomeBox);
<<<<<<< HEAD
=======
            this.Controls.Add(this.metroButton1);
>>>>>>> master
            this.Controls.Add(this.dgvHistorico);
            this.Name = "Historico_Servico";
            this.Text = "Histórico de Serviço";
            this.Load += new System.EventHandler(this.Historico_servico);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gethistoricoservicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private MetroFramework.Controls.MetroGrid dgvHistorico;
        private System.Windows.Forms.BindingSource gethistoricoservicosBindingSource;
        private DataSet1TableAdapters.get_historico_servicosTableAdapter get_historico_servicosTableAdapter;
<<<<<<< HEAD
=======
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox NomeBox;
>>>>>>> master
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamarcadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
<<<<<<< HEAD
        private MetroFramework.Controls.MetroTextBox NomeBox;
=======
>>>>>>> master
    }
}