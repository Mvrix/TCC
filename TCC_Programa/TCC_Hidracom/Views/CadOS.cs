using MetroFramework.Forms;
using System;
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
    public partial class CadOS : MetroForm
    {
        public CadOS()
        {
            InitializeComponent();


            PreencherFuncionario();
        }


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
                    servicoss.DisplayMember = "descricao";
                    servicoss.DataSource = dt;
                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        //selecionando a tabela e amostrando os dados NÃO ESTA FUNCIONANDO PRECIS AIDDA FAZER A FUCKING EVENTS NO GRID

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CadOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.tcc_pessoas' table. You can move, or remove it, as needed.
            this.tcc_pessoasTableAdapter.Fill(this.dataSet11.tcc_pessoas);
            // TODO: This line of code loads data into the 'dataSet1.tcc_observacao_servicos' table. You can move, or remove it, as needed.
            this.tcc_observacao_servicosTableAdapter.Fill(this.dataSet1.tcc_observacao_servicos);
            // TODO: This line of code loads data into the 'dataSet13.tcc_observacao_servicos' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSet1.tcc_observacao_servicos' table. You can move, or remove it, as needed.
            this.tcc_observacao_servicosTableAdapter.Fill(this.dataSet1.tcc_observacao_servicos);
            // TODO: This line of code loads data into the 'dataSet1.tcc_produto' table. You can move, or remove it, as needed.
            this.tcc_produtoTableAdapter.Fill(this.dataSet1.tcc_produto);
            // TODO: This line of code loads data into the 'dataSet12.tcc_pessoas' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataSet1.tcc_pessoas' table. You can move, or remove it, as needed.
            this.tcc_pessoasTableAdapter.Fill(this.dataSet1.tcc_pessoas);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            // tem ta tiva falha de selecionar txtNomePessoa.text = grid.selected.cells[0].text;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByFuncionarioToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tcc_pessoasTableAdapter.FillByFuncionario(this.dataSet1.tcc_pessoas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFuncionario1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tcc_pessoasTableAdapter.FillByFuncionario1(this.dataSet1.tcc_pessoas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFuncionarioToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tcc_pessoasTableAdapter.FillByFuncionario(this.dataSet1.tcc_pessoas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherServico();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                using (var sc = new SqlCommand("SELECT * FROM tcc_pessoas where tipo = 0 and nome like '%" + txtNome.Text + "%'", conn))
                {
                    SqlDataReader reader;

                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Columns.Add("id_pessoa", typeof(int));
                    dt.Columns.Add("nome", typeof(string));
                    dt.Columns.Add("endereco", typeof(string));
                    dt.Columns.Add("bairro", typeof(string));
                    dt.Columns.Add("cep", typeof(string));
                    dt.Columns.Add("telefone", typeof(string));
                    dt.Columns.Add("email", typeof(string));
                    dt.Columns.Add("rg", typeof(string));
                    dt.Columns.Add("cpf", typeof(string));
                    dt.Columns.Add("cidade", typeof(string));
                    dt.Columns.Add("datanasc", typeof(DateTime));
                    dt.Columns.Add("observacao", typeof(string));


                    dt.Load(reader);
                    dgvCliente.DataSource = dt;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString);
          
                conn.Open();
                string tecnico = tecnicoss.ValueMember;
                string servico = servicoss.ValueMember;
                DateTime DataBox = dataMarcada.Value;
                string descricao = CampoTexto.Text;
                string cliente = txtCliente.Text;

          
            SqlCommand comandoIN = new SqlCommand ("INSERT INTO [dbo].[tcc_servicos] ([pessoas_id] ,[tecnico_id] ,[data_marcada] ,[observacao_servico_id]) VALUES({cliente}, {tecnico}, {DataBox}, {servico}, {descricao}");                
            comandoIN.ExecuteNonQuery();
            conn.Close();
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            txtCliente.Text = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();
        }
     }
   }