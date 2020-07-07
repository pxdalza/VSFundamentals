using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalVSFundamentals.UI.Forms.Data;
using Microsoft.Reporting.WinForms;

namespace HospitalVSFundamentals.UI.Forms.Forms_MedicHistory
{
    public partial class FrmReportMedicHistory : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();

        public FrmReportMedicHistory()
        {
            InitializeComponent();
        }

        private void FrmReportMedicHistory_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_HospitalVSFundamentalsDataSet.MedicHistory' Puede moverla o quitarla según sea necesario.
            this.medicHistoryTableAdapter.Fill(this.bD_HospitalVSFundamentalsDataSet.MedicHistory);

            //   List<ReportParameter> lista = new List<ReportParameter>();

            //   this.reportViewer1.RefreshReport();


            //(reportViewer1, "RptMedicHistory", lista);



            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
