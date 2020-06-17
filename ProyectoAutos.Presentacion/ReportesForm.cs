using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProyectoAutos.Reportes;

namespace ProyectoAutos.Presentacion
{
    public partial class ReportesForm : MetroFramework.Forms.MetroForm
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private ReportClass rpt;
        public void SetReporte(ReportClass rpt)
        {
            this.rpt = rpt;
        }

        private void ReportesForm_Load(object sender, System.EventArgs e)
        {
            reportViewer.ReportSource = rpt;
        }
    }
}
