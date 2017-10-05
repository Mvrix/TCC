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

namespace TCC_Hidracom.Views
{
    public partial class CadOS : MetroForm
    {
        public CadOS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        //selecionando a tabela e amostrando os dados

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> listaDosIdsNaGrid = new List<int>();
            metroGrid1.Rows.Add(metroComboBox1.SelectedText);
            listaDosIdsNaGrid.Add((int)metroComboBox1.SelectedValue);
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CadOS_Load(object sender, EventArgs e)
        {
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
    }
}
