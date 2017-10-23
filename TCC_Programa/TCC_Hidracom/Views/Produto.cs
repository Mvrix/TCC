using System;
using MetroFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using System.Data.SqlClient;


namespace TCC_Hidracom.Views
{
    public partial class Produto : MetroFramework.Forms.MetroForm
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                string descricao = txtDescricao.Text;
                string marca = txtMarca.Text;
                string quantidade = txtQuant.Text;
                string preco = txtPreco.Text;                

                string query = $"INSERT INTO [dbo].[tcc_produto] ([quantidade] ,[descricao] ,[marca] ,[precounit]) VALUES({quantidade}, '{descricao}', '{marca}', {preco})";

                new SqlCommand(query, conn);
                MetroMessageBox.Show(this, "Novo produto cadastrado");
            }
        }
    }
}
