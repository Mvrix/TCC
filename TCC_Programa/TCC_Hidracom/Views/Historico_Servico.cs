using System;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace TCC_Hidracom.Views
{
    public partial class Historico_Servico : MetroForm
    {
        public Historico_Servico()
        {
            InitializeComponent();
        }

        private void Historico_servico(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.get_historico_servicos' table. You can move, or remove it, as needed.
            this.get_historico_servicosTableAdapter.Fill(this.dataSet1.get_historico_servicos);
            // TODO: This line of code loads data into the 'dataSet1.tcc_observacao_servicos' table. You can move, or remove it, as needed.


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
        //    using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
        //    {
        //        conn.Open();
        //        using (var sc = new SqlCommand("SELECT * FROM tcc_ servico where pessoas_id and nome like '%" + nomeBox.Text + "%'", conn))
        //        {
        //            SqlDataReader reader;

        //            reader = sc.ExecuteReader();
        //            DataTable dt = new DataTable();

        //            dt.Columns.Add("observacao_servico_id", typeof(int));
        //            dt.Columns.Add("pessoas_id", typeof(int));
        //            dt.Columns.Add("tecnico_id", typeof(int));                 
        //            dt.Columns.Add("data_marcada", typeof(DateTime));
        //            dt.Columns.Add("observacao", typeof(string));
                    
        //            dt.Load(reader);
        //            dgvHistorico.DataSource = dt;
        //        }
        //    }
            }

        private void selectServicosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.get_historico_servicosTableAdapter.SelectServicos(this.dataSet1.get_historico_servicos, nomeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void selectServicosToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.get_historico_servicosTableAdapter.SelectServicos(this.dataSet1.get_historico_servicos, nomeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }

        private void dgvHistorico_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
    }

