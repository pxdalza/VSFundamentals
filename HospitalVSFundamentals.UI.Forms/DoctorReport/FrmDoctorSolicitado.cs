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
    public partial class FrmDoctorSolicitado : Form
    {
     //   private DateTime? FechaFin;
      //  private DateTime? finicial;

        public FrmDoctorSolicitado()
        {
            InitializeComponent();
        }
        public DateTime ffinicial { get; set; }
        public DateTime ffinal { get; set; }

        private void FrmDoctorSolicitado_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //   dateTimePicker1.Value = DateTime.Today;
            //  dateTimePicker2.Value = DateTime.Today;
           
            ffinicial = dateTimePicker1.Value;
            ffinal = dateTimePicker2.Value;
            // TODO: esta línea de código carga datos en la tabla 'DataSet1DoctorSolicitado.usp_DoctorSolicitado' Puede moverla o quitarla según sea necesario.

            this.usp_DoctorSolicitadoTableAdapter.Fill(this.DataSet1DoctorSolicitado.usp_DoctorSolicitado, ffinicial, ffinal);

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           DateTime ffinicial = dateTimePicker1.Value;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           DateTime ffinal = dateTimePicker1.Value;
        }
    }
}
