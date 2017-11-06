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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataMarcada = new System.Windows.Forms.DateTimePicker();
            this.tecnicoss = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.servicoss = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tecnicoss);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 96);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dataMarcada
            // 
            this.dataMarcada.Location = new System.Drawing.Point(583, 134);
            this.dataMarcada.Name = "dataMarcada";
            this.dataMarcada.Size = new System.Drawing.Size(314, 20);
            this.dataMarcada.TabIndex = 12;
            // 
            // tecnicoss
            // 
            this.tecnicoss.DisplayMember = "nome";
            this.tecnicoss.FormattingEnabled = true;
            this.tecnicoss.ItemHeight = 23;
            this.tecnicoss.Location = new System.Drawing.Point(87, 20);
            this.tecnicoss.Name = "tecnicoss";
            this.tecnicoss.Size = new System.Drawing.Size(314, 29);
            this.tecnicoss.TabIndex = 15;
            this.tecnicoss.UseSelectable = true;
            this.tecnicoss.ValueMember = "id_pessoa";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(496, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Ocorreu em:";
            // 
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(503, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Serviço:";
            // 
            // servicoss
            // 
            this.servicoss.DisplayMember = "nome_servico";
            this.servicoss.FormattingEnabled = true;
            this.servicoss.ItemHeight = 23;
            this.servicoss.Location = new System.Drawing.Point(583, 36);
            this.servicoss.Name = "servicoss";
            this.servicoss.Size = new System.Drawing.Size(314, 29);
            this.servicoss.TabIndex = 21;
            this.servicoss.UseSelectable = true;
            this.servicoss.ValueMember = "id_observacao_servicos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Busca por Tecnico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Busca por Servico";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Busca por Data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SaidaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 401);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataMarcada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.servicoss);
            this.Controls.Add(this.metroLabel2);
            this.Name = "SaidaFuncionario";
            this.Text = "SaidaFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox tecnicoss;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private System.Windows.Forms.DateTimePicker dataMarcada;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox servicoss;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}