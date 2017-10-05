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
namespace TCC_Hidracom.Views.Visualizar
{
    public partial class PesquisaCli : MetroForm

    {
        public PesquisaCli()
        {
            InitializeComponent();
        }

        private void PesquisaCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tcc_pessoas' table. You can move, or remove it, as needed.
            this.tcc_pessoasTableAdapter.Fill(this.dataSet1.tcc_pessoas);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }
    }
}
