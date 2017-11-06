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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistorico = new MetroFramework.Controls.MetroGrid();
            this.idservicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamarcadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gethistoricoservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.nomeToolStripTextBox = new MetroFramework.Controls.MetroTextBox();
            this.get_historico_servicosTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.get_historico_servicosTableAdapter();
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
            this.idservicosDataGridViewTextBoxColumn,
            this.nometecnicoDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.nomeservicoDataGridViewTextBoxColumn,
            this.datamarcadaDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.dgvHistorico.DataSource = this.gethistoricoservicosBindingSource;
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
            this.dgvHistorico.Location = new System.Drawing.Point(23, 111);
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
            this.dgvHistorico.Size = new System.Drawing.Size(720, 332);
            this.dgvHistorico.TabIndex = 0;
            // 
            // idservicosDataGridViewTextBoxColumn
            // 
            this.idservicosDataGridViewTextBoxColumn.DataPropertyName = "id_servicos";
            this.idservicosDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idservicosDataGridViewTextBoxColumn.Name = "idservicosDataGridViewTextBoxColumn";
            this.idservicosDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.nomeservicoDataGridViewTextBoxColumn.DataPropertyName = "nome_servico";
            this.nomeservicoDataGridViewTextBoxColumn.HeaderText = "Serviço";
            this.nomeservicoDataGridViewTextBoxColumn.Name = "nomeservicoDataGridViewTextBoxColumn";
            this.nomeservicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datamarcadaDataGridViewTextBoxColumn
            // 
            this.datamarcadaDataGridViewTextBoxColumn.DataPropertyName = "data_marcada";
            this.datamarcadaDataGridViewTextBoxColumn.HeaderText = "Data Marcada";
            this.datamarcadaDataGridViewTextBoxColumn.Name = "datamarcadaDataGridViewTextBoxColumn";
            this.datamarcadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Width = 175;
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 80);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Pesquisar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // nomeToolStripTextBox
            // 
            // 
            // 
            // 
            this.nomeToolStripTextBox.CustomButton.Image = null;
            this.nomeToolStripTextBox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.nomeToolStripTextBox.CustomButton.Name = "";
            this.nomeToolStripTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomeToolStripTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomeToolStripTextBox.CustomButton.TabIndex = 1;
            this.nomeToolStripTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomeToolStripTextBox.CustomButton.UseSelectable = true;
            this.nomeToolStripTextBox.CustomButton.Visible = false;
            this.nomeToolStripTextBox.Lines = new string[0];
            this.nomeToolStripTextBox.Location = new System.Drawing.Point(160, 80);
            this.nomeToolStripTextBox.MaxLength = 32767;
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.PasswordChar = '\0';
            this.nomeToolStripTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomeToolStripTextBox.SelectedText = "";
            this.nomeToolStripTextBox.SelectionLength = 0;
            this.nomeToolStripTextBox.SelectionStart = 0;
            this.nomeToolStripTextBox.ShortcutsEnabled = true;
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(116, 23);
            this.nomeToolStripTextBox.TabIndex = 2;
            this.nomeToolStripTextBox.UseSelectable = true;
            this.nomeToolStripTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomeToolStripTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nomeToolStripTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // get_historico_servicosTableAdapter
            // 
            this.get_historico_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // Historico_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 504);
            this.Controls.Add(this.nomeToolStripTextBox);
            this.Controls.Add(this.metroButton1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeservicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamarcadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox nomeToolStripTextBox;
    }
}