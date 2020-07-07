using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.doctor
{
    public partial class FrmGraficoCita1 : Form
    {
        public FrmGraficoCita1()
        {
            InitializeComponent();
        }
        public DateTime ffinicial { get; set; }
        public DateTime ffinal { get; set; }
        private void FrmGraficoCita1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            ffinicial = dateTimePicker1.Value;
            ffinal = dateTimePicker2.Value;
            // TODO: esta línea de código carga datos en la tabla 'DataSet1DoctorSolicitado.usp_DoctorSolicitado' Puede moverla o quitarla según sea necesario.
            this.usp_DoctorSolicitadoTableAdapter.Fill(this.DataSet1DoctorSolicitado.usp_DoctorSolicitado, ffinicial, ffinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
