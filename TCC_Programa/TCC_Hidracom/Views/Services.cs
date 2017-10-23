using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using MetroFramework;

namespace TCC_Hidracom.Views
{
    public partial class Services : MetroForm
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                string nominho = NomeBox.Text;
                string observac = ObsBox.Text;

                

                string quer = $"INSERT INTO [dbo].[tcc_observacao_servicos] ([nome_servico] ,[observacao]) VALUES({nominho}, {observac})";


                new SqlCommand(quer, conn);         
                MetroMessageBox.Show(this, "Serviço Cadastrado");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }
    }
}
