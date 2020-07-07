using HospitalVSFundamentals.UI.Forms.Data;
using HospitalVSFundamentals.UI.Forms.Helpers;
using HospitalVSFundamentals.UI.Forms.ViewModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Forms_MedicHistory
{
    public partial class Frm_ShowPatient : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        public PatientShowViewModel medhis = new PatientShowViewModel();
        public UserViewModel docvm = new UserViewModel();
        public Frm_ShowPatient()
        {
            InitializeComponent();
        }

        private void updateDGVShowPatient()
        {   var patient = (from pat in context.Users
                           where pat.Status == "A" &&
                           (pat.User_Role==3 || pat.User_Role==4)
                            select pat).Select(x => new PatientShowViewModel
                           {   Nombre = x.Name,
                               Apellido = x.LastName,
                               DNI      = x.DNI,
                               Telefono =x.PhoneNumber,
                               Genero = (x.Gener=="M")? "Masculino" : "Femenino",
                               Id = x.IdUser.ToString()
                           }).ToList();
            DGVShowPatient.DataSource = patient;
            DGVShowPatient.Columns[0].HeaderText = "CODIGO";
            DGVShowPatient.Columns[1].HeaderText = "NOMBRE";
            DGVShowPatient.Columns[2].HeaderText = "APELLIDOS";
            DGVShowPatient.Columns[3].HeaderText = "DNI";
            DGVShowPatient.Columns[4].HeaderText = "TELEFONO";
            DGVShowPatient.Columns[5].HeaderText = "GENERO";
        }
        private void Frm_ShowPatient_Load(object sender, EventArgs e)
        {
            updateDGVShowPatient();
        }
        private PatientShowViewModel getViewModelfromDataRow()
        {
            PatientShowViewModel medicHisto = new PatientShowViewModel();
            foreach (DataGridViewRow dataRow in DGVShowPatient.SelectedRows)
            {
                medicHisto = DataRowViewToViewModel.convertPatientShowViewModel(dataRow);
            }
            return medicHisto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DGVShowPatient.RowCount > 0)
            {
            PatientShowViewModel medhis = getViewModelfromDataRow();
            medhis.Id = DGVShowPatient.CurrentRow.Cells[0].Value.ToString();
            Frm_MedicHistory FrmMedicHistory = new Frm_MedicHistory();
            FrmMedicHistory.patmed.Id = medhis.Id;
            FrmMedicHistory.docuv.Id = docvm.Id;
            FrmMedicHistory.frmfather = this;
            FrmMedicHistory.ShowDialog();
            }
        }
    }
}
