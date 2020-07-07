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
    public partial class FrmReportMedicHistoryCopia : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();

        public FrmReportMedicHistoryCopia()
        {
            InitializeComponent();
        }
    
        public string LastName { get; set; }


        private void FrmReportMedicHistory_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
