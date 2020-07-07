using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Forms_MedicHistory
{
    public partial class FrmReporteMedicHIstoryFinal : Form
    {
        public FrmReporteMedicHIstoryFinal()
        {
            InitializeComponent();
            txtlas.Focus();
        }

        private void FrmReporteMedicHIstoryFinal_Load(object sender, EventArgs e)
        {
            txtlas.Focus();
            txtlas.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
           
            string las;
           
            las = Convert.ToString(txtlas.Text);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1Final.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dataSet1Final.DataTable1,las);

            this.reportViewer1.RefreshReport();
        }
    }
}
