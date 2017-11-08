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
using System.Windows;
<<<<<<< HEAD
=======
using System.Data.SqlClient;
>>>>>>> master

namespace TCC_Hidracom.Views
{
    public partial class SaidaFuncionario : MetroForm
    {
        public SaidaFuncionario()
        {
            InitializeComponent();
            PreencherFuncionario();
            //PreencherCliente();
            PreencherServico();
        }

        private void SaidaFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tcc_servicos' table. You can move, or remove it, as needed.
            this.tcc_servicosTableAdapter.Fill(this.dataSet1.tcc_servicos);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }

        private void BtnBscTec_Click(object sender, EventArgs e)
        {
            var data = new HistoricoServicos().Load(string.Format(Selects.SELECT_HISTORICO_BY_TECNICO_ID, tecnicoss.SelectedValue));
            new ReportHistorico(data).Show();

        }

        private void SaidaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }

        //new ReportHistorico(new HistoricoServicos().Load(string.Format(Selects.SELECT_HISTORICO_BY_PESSOA_ID, tecnicoss.SelectedValue)));

        public void PreencherFuncionario()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                using (var sc = new SqlCommand("SELECT * FROM tcc_pessoas where tipo = 1", conn))
                {
                    SqlDataReader reader;

                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Columns.Add("id_pessoa", typeof(string));
                    dt.Columns.Add("nome", typeof(string));

                    dt.Load(reader);
                    tecnicoss.ValueMember = "id_pessoa";
                    tecnicoss.DisplayMember = "nome";
                    tecnicoss.DataSource = dt;
                }
            }
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
                    tecnicoss.ValueMember = "id_pessoa";
                    tecnicoss.DisplayMember = "nome";
                    tecnicoss.DataSource = dt;
                }
            }
        }

        public void PreencherServico()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                using (var sc = new SqlCommand("SELECT * FROM tcc_observacao_servicos", conn))
                {
                    SqlDataReader reader;

                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Columns.Add("id_observacao_servicos", typeof(string));
                    dt.Columns.Add("nome_servico", typeof(string));

                    dt.Load(reader);
                    servicoss.ValueMember = "id_observacao_servicos";
                    servicoss.DisplayMember = "nome_servico";
                    servicoss.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = new HistoricoServicos().Load(string.Format(Selects.SELECT_HISTORICO_BY_SERVICO_ID, servicoss.SelectedValue));
            new ReportHistorico(data).Show();
        }
    }
}
