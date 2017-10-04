using System;
using MetroFramework.Forms;



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
    }
}
