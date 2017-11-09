namespace TCC_Hidracom.Views
{
    partial class relatorioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorioCliente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientes = new MetroFramework.Controls.MetroComboBox();
            this.Button1 = new MetroFramework.Controls.MetroButton();
            this.metroUserControl2 = new MetroFramework.Controls.MetroUserControl();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientes);
            this.groupBox2.Controls.Add(this.Button1);
            this.groupBox2.Controls.Add(this.metroUserControl2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 79);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // clientes
            // 
            this.clientes.DisplayMember = "nome_servico";
            this.clientes.FormattingEnabled = true;
            this.clientes.ItemHeight = 23;
            this.clientes.Location = new System.Drawing.Point(70, 12);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(314, 29);
            this.clientes.TabIndex = 28;
            this.clientes.UseSelectable = true;
            this.clientes.ValueMember = "id_observacao_servicos";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(116, 47);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(191, 23);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "Buscar por cliente";
            this.Button1.UseSelectable = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // metroUserControl2
            // 
            this.metroUserControl2.Location = new System.Drawing.Point(166, 24);
            this.metroUserControl2.Name = "metroUserControl2";
            this.metroUserControl2.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl2.TabIndex = 11;
            this.metroUserControl2.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Cliente:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(198, 148);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "Voltar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // relatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 173);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "relatorioCliente";
            this.Text = "Relatório por cliente";
            this.Load += new System.EventHandler(this.relatorioCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox clientes;
        private MetroFramework.Controls.MetroButton Button1;
        private MetroFramework.Controls.MetroUserControl metroUserControl2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}