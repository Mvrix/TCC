namespace TCC_Hidracom.Views
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ObsBox = new MetroFramework.Controls.MetroTextBox();
            this.NomeBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(47, 207);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Cadastrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nome:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Observação:";
            // 
            // ObsBox
            // 
            // 
            // 
            // 
            this.ObsBox.CustomButton.Image = null;
            this.ObsBox.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.ObsBox.CustomButton.Name = "";
            this.ObsBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ObsBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ObsBox.CustomButton.TabIndex = 1;
            this.ObsBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ObsBox.CustomButton.UseSelectable = true;
            this.ObsBox.CustomButton.Visible = false;
            this.ObsBox.Lines = new string[0];
            this.ObsBox.Location = new System.Drawing.Point(163, 147);
            this.ObsBox.MaxLength = 32767;
            this.ObsBox.Name = "ObsBox";
            this.ObsBox.PasswordChar = '\0';
            this.ObsBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ObsBox.SelectedText = "";
            this.ObsBox.SelectionLength = 0;
            this.ObsBox.SelectionStart = 0;
            this.ObsBox.ShortcutsEnabled = true;
            this.ObsBox.Size = new System.Drawing.Size(117, 23);
            this.ObsBox.TabIndex = 3;
            this.ObsBox.UseSelectable = true;
            this.ObsBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ObsBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NomeBox
            // 
            // 
            // 
            // 
            this.NomeBox.CustomButton.Image = null;
            this.NomeBox.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.NomeBox.CustomButton.Name = "";
            this.NomeBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NomeBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NomeBox.CustomButton.TabIndex = 1;
            this.NomeBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NomeBox.CustomButton.UseSelectable = true;
            this.NomeBox.CustomButton.Visible = false;
            this.NomeBox.Lines = new string[0];
            this.NomeBox.Location = new System.Drawing.Point(163, 98);
            this.NomeBox.MaxLength = 32767;
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.PasswordChar = '\0';
            this.NomeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NomeBox.SelectedText = "";
            this.NomeBox.SelectionLength = 0;
            this.NomeBox.SelectionStart = 0;
            this.NomeBox.ShortcutsEnabled = true;
            this.NomeBox.Size = new System.Drawing.Size(117, 23);
            this.NomeBox.TabIndex = 4;
            this.NomeBox.UseSelectable = true;
            this.NomeBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NomeBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(174, 207);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 256);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.NomeBox);
            this.Controls.Add(this.ObsBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Services";
            this.Text = "Cadastro de serviços";
            this.Load += new System.EventHandler(this.Services_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ObsBox;
        private MetroFramework.Controls.MetroTextBox NomeBox;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}