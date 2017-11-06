using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace TCC_Hidracom.Views
{
    public partial class ReportHistorico : Form
    {
        public ReportHistorico(List<HistoricoServicos> dataSource)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.AppStarting;

            InitializeComponent();

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TCC_Hidracom.Report1.rdlc";
            var dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSource);
            reportViewer1.LocalReport.DataSources.Add(dataset);

            reportViewer1.RefreshReport();

            Mouse.OverrideCursor = null;

        }
    }
}
