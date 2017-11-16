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

namespace TCC_Hidracom.Views
{
    public partial class PsqCliente : MetroForm
    {
        public PsqCliente()
        {
            InitializeComponent();
        }

        private void PsqCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tcc_pessoas' table. You can move, or remove it, as needed.
            dgvHistorico.DataSource = tcc_pessoasTableAdapter.GetDataByCliente();

        }

        private void NomeBox_Click(object sender, EventArgs e)
        {
            dgvHistorico.DataSource = tcc_pessoasTableAdapter.GetDataByClientePsq(string.Format("%{0}%", NomeBox.Text));
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
    }
}
