using HospitalVSFundamentals.UI.Forms.Data;
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
    public partial class Frm_CreateMedicHistory : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        public Frm_MedicHistory frmmFather = new Frm_MedicHistory();
        public PatientShowViewModel patmed = new PatientShowViewModel();
        public Guid patIdGuid, patId;
        public Frm_CreateMedicHistory()
        {
            InitializeComponent();
        }

        private void PatientShow()
        {
            try
            {
                patIdGuid = Guid.Parse(patmed.Id);
                var pat = (from user in context.Users
                           join pats in context.Patients on user.IdUser equals pats.UserId
                           where pats.PacienteId == patIdGuid select user)
                         .Select(x => new PatientShowViewModel
                         {
                             Nombre = x.Name,
                             Apellido = x.LastName,
                             DNI = x.DNI,
                         }).ToList();

                foreach (var item in pat)
                {
                    lblPaciente.Text = item.Apellido + "" + item.Nombre;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Sistema. "+ex);
            }
        }

        private void Frm_CreateMedicHistory_Load(object sender, EventArgs e)
        {
            PatientShow();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            patIdGuid = Guid.Parse(patmed.Id);
            try
            {
                patIdGuid = Guid.Parse(patmed.Id);
                var pat = (from pats in context.Patients
                           where pats.UserId == patIdGuid
                           select pats)
                         .Select(x => new PatientShowViewModel
                         {
                             Id= x.PacienteId.ToString()
                         }).ToList();

                foreach (var item in pat)
                {   patId = Guid.Parse(item.Id);    }


                Guid guid = Guid.NewGuid();
                var medHis = context.MedicHistory
                    .Add(new MedicHistory
                    {
                        MedicHistoryId = guid,
                        Description = txtEnfermedades.Text,
                        Height = Convert.ToDecimal(txtAltura.Text),
                        Weight = Convert.ToDecimal(txtPeso.Text),
                        temperature = Convert.ToDecimal(txtTemperatura.Text),
                        Reason = txtmotivo.Text,
                        Diagnosis = txtdiagnostico.Text,
                        PatiendId = patId
                    });
                context.SaveChanges();
                frmmFather.updateDGVMedicHistory();
                MessageBox.Show("Se registró satisfactoriamente. ");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Sistema. "+ex);
            }
        }
    }
}
