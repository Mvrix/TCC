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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.nomeBox = new MetroFramework.Controls.MetroTextBox();
            this.idservicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeservicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamarcadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gethistoricoservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
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
            this.dgvHistorico.Size = new System.Drawing.Size(720, 332);
            this.dgvHistorico.TabIndex = 0;
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
            // nomeBox
            // 
            // 
            // 
            // 
            this.nomeBox.CustomButton.Image = null;
            this.nomeBox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.nomeBox.CustomButton.Name = "";
            this.nomeBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomeBox.CustomButton.TabIndex = 1;
            this.nomeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomeBox.CustomButton.UseSelectable = true;
            this.nomeBox.CustomButton.Visible = false;
            this.nomeBox.Lines = new string[0];
            this.nomeBox.Location = new System.Drawing.Point(160, 80);
            this.nomeBox.MaxLength = 32767;
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.PasswordChar = '\0';
            this.nomeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomeBox.SelectedText = "";
            this.nomeBox.SelectionLength = 0;
            this.nomeBox.SelectionStart = 0;
            this.nomeBox.ShortcutsEnabled = true;
            this.nomeBox.Size = new System.Drawing.Size(116, 23);
            this.nomeBox.TabIndex = 2;
            this.nomeBox.UseSelectable = true;
            this.nomeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nomeBox.Click += new System.EventHandler(this.metroTextBox1_Click);
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
            // get_historico_servicosTableAdapter
            // 
            this.get_historico_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // Historico_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 504);
            this.Controls.Add(this.nomeBox);
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
        private MetroFramework.Controls.MetroTextBox nomeBox;
    }
}