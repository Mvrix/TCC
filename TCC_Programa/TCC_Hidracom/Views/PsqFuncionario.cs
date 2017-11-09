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

namespace TCC_Hidracom.Views
{
    public partial class PsqFuncionario : MetroForm
    {
        public PsqFuncionario()
        {
            InitializeComponent();
        }

        private void PsqFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tcc_pessoas' table. You can move, or remove it, as needed.
            dgvHistorico.DataSource = tcc_pessoasTableAdapter.GetDataByFuncionario();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dgvHistorico.DataSource = tcc_pessoasTableAdapter.GetDataByPsqFuncionario(string.Format("%{0}%", NomeBox.Text));
        }

        private void NomeBox_Click(object sender, EventArgs e)
        {

        }
    }
}
