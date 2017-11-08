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

namespace TCC_Hidracom.Views
{
    public partial class SaidaFuncionario : MetroForm
    {
        public SaidaFuncionario()
        {
            InitializeComponent();
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

    }
}
