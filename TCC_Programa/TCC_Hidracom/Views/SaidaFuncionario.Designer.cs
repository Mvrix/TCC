namespace TCC_Hidracom.Views
{
    partial class SaidaFuncionario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBscTec = new System.Windows.Forms.Button();
            this.tecnicoss = new MetroFramework.Controls.MetroComboBox();
<<<<<<< HEAD
=======
            this.tccservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TCC_Hidracom.DataSet1();
>>>>>>> master
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.dataMarcada = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroUserControl2 = new MetroFramework.Controls.MetroUserControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.metroUserControl3 = new MetroFramework.Controls.MetroUserControl();
            this.button2 = new System.Windows.Forms.Button();
            this.servicoss = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
=======
            this.button2 = new System.Windows.Forms.Button();
            this.servicoss = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroUserControl3 = new MetroFramework.Controls.MetroUserControl();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.tcc_servicosTableAdapter = new TCC_Hidracom.DataSet1TableAdapters.tcc_servicosTableAdapter();
            this.tccservicosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccservicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tccservicosBindingSource1)).BeginInit();
>>>>>>> master
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBscTec);
            this.groupBox1.Controls.Add(this.tecnicoss);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(23, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // BtnBscTec
            // 
            this.BtnBscTec.Location = new System.Drawing.Point(155, 55);
            this.BtnBscTec.Name = "BtnBscTec";
            this.BtnBscTec.Size = new System.Drawing.Size(118, 23);
            this.BtnBscTec.TabIndex = 16;
            this.BtnBscTec.Text = "Busca por Tecnico";
            this.BtnBscTec.UseVisualStyleBackColor = true;
<<<<<<< HEAD
=======
            this.BtnBscTec.Click += new System.EventHandler(this.BtnBscTec_Click);
>>>>>>> master
            // 
            // tecnicoss
            // 
            this.tecnicoss.FormattingEnabled = true;
            this.tecnicoss.ItemHeight = 23;
            this.tecnicoss.Location = new System.Drawing.Point(87, 20);
            this.tecnicoss.Name = "tecnicoss";
            this.tecnicoss.Size = new System.Drawing.Size(314, 29);
            this.tecnicoss.TabIndex = 15;
            this.tecnicoss.UseSelectable = true;
            // 
<<<<<<< HEAD
=======
            // tccservicosBindingSource
            // 
            this.tccservicosBindingSource.DataMember = "tcc_servicos";
            this.tccservicosBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
>>>>>>> master
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Técnico:";
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(166, 24);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 11;
            this.metroUserControl1.UseSelectable = true;
            // 
            // dataMarcada
            // 
            this.dataMarcada.Location = new System.Drawing.Point(94, 21);
            this.dataMarcada.Name = "dataMarcada";
            this.dataMarcada.Size = new System.Drawing.Size(314, 20);
            this.dataMarcada.TabIndex = 12;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Ocorreu em:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Busca por Data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroUserControl2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.dataMarcada);
            this.groupBox2.Location = new System.Drawing.Point(23, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 79);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // metroUserControl2
            // 
            this.metroUserControl2.Location = new System.Drawing.Point(166, 24);
            this.metroUserControl2.Name = "metroUserControl2";
            this.metroUserControl2.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl2.TabIndex = 11;
            this.metroUserControl2.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.servicoss);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroUserControl3);
            this.groupBox3.Location = new System.Drawing.Point(481, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 85);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
<<<<<<< HEAD
            // metroUserControl3
            // 
            this.metroUserControl3.Location = new System.Drawing.Point(166, 24);
            this.metroUserControl3.Name = "metroUserControl3";
            this.metroUserControl3.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl3.TabIndex = 11;
            this.metroUserControl3.UseSelectable = true;
            // 
=======
>>>>>>> master
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Busca por Servico";
            this.button2.UseVisualStyleBackColor = true;
<<<<<<< HEAD
=======
            this.button2.Click += new System.EventHandler(this.button2_Click);
>>>>>>> master
            // 
            // servicoss
            // 
            this.servicoss.FormattingEnabled = true;
            this.servicoss.ItemHeight = 23;
            this.servicoss.Location = new System.Drawing.Point(95, 19);
            this.servicoss.Name = "servicoss";
            this.servicoss.Size = new System.Drawing.Size(314, 29);
            this.servicoss.TabIndex = 24;
            this.servicoss.UseSelectable = true;
            // 
            // metroLabel2
<<<<<<< HEAD
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Serviço:";
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton2.Location = new System.Drawing.Point(445, 256);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 25;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
=======
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Serviço:";
            // 
            // metroUserControl3
            // 
            this.metroUserControl3.Location = new System.Drawing.Point(166, 24);
            this.metroUserControl3.Name = "metroUserControl3";
            this.metroUserControl3.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl3.TabIndex = 11;
            this.metroUserControl3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton2.Location = new System.Drawing.Point(445, 256);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 25;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tcc_servicosTableAdapter
            // 
            this.tcc_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // tccservicosBindingSource1
            // 
            this.tccservicosBindingSource1.DataMember = "tcc_servicos";
            this.tccservicosBindingSource1.DataSource = this.dataSet1BindingSource;
>>>>>>> master
            // 
            // SaidaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 284);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaidaFuncionario";
            this.Text = "Saída Funcionario";
            this.Load += new System.EventHandler(this.SaidaFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.tccservicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
>>>>>>> master
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.tccservicosBindingSource1)).EndInit();
>>>>>>> master
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBscTec;
        private MetroFramework.Controls.MetroComboBox tecnicoss;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private System.Windows.Forms.DateTimePicker dataMarcada;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroUserControl metroUserControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroComboBox servicoss;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroUserControl metroUserControl3;
        private MetroFramework.Controls.MetroButton metroButton2;
<<<<<<< HEAD
=======
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tccservicosBindingSource;
        private DataSet1TableAdapters.tcc_servicosTableAdapter tcc_servicosTableAdapter;
        private System.Windows.Forms.BindingSource tccservicosBindingSource1;
>>>>>>> master
    }
}