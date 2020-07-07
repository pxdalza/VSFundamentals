using HospitalVSFundamentals.BL.BE;
using HospitalVSFundamentals.UI.Forms.Forms_MedicHistory;
using HospitalVSFundamentals.UI.Forms.Forms_Specialities;
using HospitalVSFundamentals.UI.Forms.Forms_Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalVSFundamentals.UI.Forms.ViewModel;
using HospitalVSFundamentals.UI.Forms.doctor;

namespace HospitalVSFundamentals.UI.Forms.Form_Main
{
    public partial class FMainMdc : Form
    {
        public UserLoginBE ulogin = new UserLoginBE();
        public UserViewModel uservm = new UserViewModel();

        public FMainMdc()
        {
            InitializeComponent();
        }

        private void FMainMdc_Load(object sender, EventArgs e)
        {

            lblNombre.Text = ulogin.Name + " " + ulogin.LastName;
            lblDNI.Text = "DNI: " + ulogin.DNI;
            lblRol.Text = "Rol: " + ulogin.Role;
            uservm.Id = ulogin.IdUser;
        }

        private void btnMedicHistory_Click(object sender, EventArgs e)
        {
            var FrmShowPatient = new Frm_ShowPatient();
            FrmShowPatient.docvm.Id = ulogin.IdUser;

            FrmShowPatient.ShowDialog();
        }

        private void btnReporteDoctor_Click(object sender, EventArgs e)
        {
            FrmDoctorSolicitado frmDoctor = new FrmDoctorSolicitado();
            frmDoctor.ShowDialog();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            FrmGraficoCita1 frmGrafico = new FrmGraficoCita1();
            frmGrafico.ShowDialog();
        }
    }
}
