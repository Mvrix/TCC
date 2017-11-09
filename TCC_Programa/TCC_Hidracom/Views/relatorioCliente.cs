using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Windows;

namespace TCC_Hidracom.Views
{
    public partial class relatorioCliente : MetroForm
    {
        public relatorioCliente()
        {
            InitializeComponent();
            PreencherCliente();
        }

        public void PreencherCliente()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                using (var sc = new SqlCommand("SELECT * FROM tcc_pessoas where tipo = 0", conn))
                {
                    SqlDataReader reader;

                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Columns.Add("id_pessoa", typeof(string));
                    dt.Columns.Add("nome", typeof(string));

                    dt.Load(reader);
                    clientes.ValueMember = "id_pessoa";
                    clientes.DisplayMember = "nome";
                    clientes.DataSource = dt;
                }
            }
        }

        private void relatorioCliente_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            var data = new HistoricoServicos().Load(string.Format(Selects.SELECT_HISTORICO_BY_PESSOA_ID, clientes.SelectedValue));
            new ReportHistorico(data).Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var data = new HistoricoServicos().Load(string.Format(Selects.SELECT_HISTORICO_BY_PESSOA_ID, clientes.SelectedValue));
            new ReportHistorico(data).Show();
        }
    }
}
