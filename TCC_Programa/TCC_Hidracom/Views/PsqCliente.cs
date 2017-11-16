using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace TCC_Hidracom.Views
{
    public partial class PsqCliente : MetroForm
    {
        private int pagina = 0;
        private int num_por_pagina = 2;


        public PsqCliente()
        {
            InitializeComponent();
        }

        private void PsqCliente_Load(object sender, EventArgs e)
        {
            GerarPaginacao();

        }

        private void NomeBox_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = tcc_pessoasTableAdapter.GetDataByClientePsq(string.Format("%{0}%", NomeBox.Text));
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void boxNome_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        public void GerarPaginacao()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.db_01359_14_A_1_2015ConnectionString))
            {
                conn.Open();
                using (var sc = new SqlCommand(string.Format(Selects.SELECT_TCC_PESSOAS_PAGINACAO, pagina, num_por_pagina, 0), conn))
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
            pagina++;
            GerarPaginacao();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(pagina > 0)
            {
                pagina--;
                GerarPaginacao();
            }
        }
    }
}

