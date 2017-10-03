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



namespace TCC_Hidracom.Views
{
    public partial class GerarOS : MetroForm
    {
        public GerarOS()
        {
            InitializeComponent();
        }

        private void GerarOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tcc_observacao_servicos' table. You can move, or remove it, as needed.
            this.tcc_observacao_servicosTableAdapter.Fill(this.dataSet1.tcc_observacao_servicos);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
