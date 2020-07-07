using HospitalVSFundamentals.UI.Forms.Data;
using HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes;
using HospitalVSFundamentals.UI.Forms.Helpers;
using HospitalVSFundamentals.UI.Forms.ViewModel;
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
    public partial class Frm_DetailMedicHistory1 : Form
    {
        //entity framework
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        //frm padre donde esta la grilla
        public Frm_MedicHistory frmmFather = new Frm_MedicHistory();
        //y este bool nos indica si el formulario es editable o no
        public bool isEditable = false;
        //y este es el modelo del objeto especialidad
        public MedicHistoryViewModel MedicHistoryViewModel = new MedicHistoryViewModel();
        public PatientShowViewModel patmed = new PatientShowViewModel();
        public Guid patIdGuid, medHisGuid;

        public Frm_DetailMedicHistory1()
        {
            InitializeComponent();
        }

        private void Frm_DetailMedicHistory1_Load(object sender, EventArgs e)
        {
            patIdGuid = Guid.Parse(MedicHistoryViewModel.IdPatiend);
            var pat = (from user in context.Users
                       join pats in context.Patients on user.IdUser equals pats.UserId
                       where pats.PacienteId == patIdGuid
                       select user)
                     .Select(x => new PatientShowViewModel
                     {   Nombre = x.Name,
                         Apellido = x.LastName,
                         DNI = x.DNI,
                     }).ToList();
            foreach (var item in pat)
            {
                lblPaciente.Text = item.Apellido + "" + item.Nombre;
            }
            if (!isEditable)
            {
                txtEnfermedades.Enabled = false;
                txtmotivo.Enabled = false;
                txtAltura.Enabled = false;
                txtdiagnostico.Enabled = false;
                txtmotivo.Enabled = false;
                txtPeso.Enabled = false;
                txtTemperatura.Enabled=false;
                btnButton.Visible = false;
            }
            txtEnfermedades.Text    = MedicHistoryViewModel.descripcion;
            txtmotivo.Text          = MedicHistoryViewModel.Motivo;
            txtAltura.Text          = MedicHistoryViewModel.altura;
            txtdiagnostico.Text     = MedicHistoryViewModel.Diagnostico;
            txtPeso.Text            = MedicHistoryViewModel.peso;
            txtTemperatura.Text     = MedicHistoryViewModel.Temperatura;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            medHisGuid = Guid.Parse(MedicHistoryViewModel.Id);
            try
            {
                var historial = context.MedicHistory
                .Where( x => x.MedicHistoryId.Equals
                (medHisGuid) )
                .SingleOrDefault();
                if (historial != null)
                {
                    historial.Description   = txtEnfermedades.Text;
                    historial.Reason        = txtmotivo.Text;
                    historial.Height        = Convert.ToDecimal(txtAltura.Text);
                    historial.Weight        = Convert.ToDecimal(txtPeso.Text);
                    historial.Diagnosis     = txtdiagnostico.Text;
                    historial.temperature   = Convert.ToDecimal(txtTemperatura.Text);
                    context.SaveChanges();

                    MessageBox.Show("Historial se actualizó correctamente.");
                }
                frmmFather.updateDGVMedicHistory();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurró un ´Problema en el Sistema. "+ex);
            }
        
        }
    }
}
