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
    public partial class Frm_MedicHistory : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        public Frm_ShowPatient frmfather = new Frm_ShowPatient();
        public PatientShowViewModel patmed = new PatientShowViewModel();
        public Guid patIdGuid, medHisGuid, patIdGuid1;
        public UserViewModel docuv = new UserViewModel();

        public Frm_MedicHistory()
        {
            InitializeComponent();
        }
        public void updateDGVMedicHistory()
        {
            patIdGuid = Guid.Parse(patmed.Id);
            var pat = (from pats in context.Patients
                       where pats.UserId == patIdGuid
                       select pats)
                     .Select(x => new PatientShowViewModel
                     {
                         Id = x.PacienteId.ToString()
                     }).ToList();

            foreach (var item in pat)
            { patIdGuid = Guid.Parse(item.Id); }



            patIdGuid1 = patIdGuid;
            var History = (from mhis in context.MedicHistory
                           where mhis.PatiendId == patIdGuid1 select mhis
                           ).Select(x => new MedicHistoryViewModel
                           {
                               Id = x.MedicHistoryId.ToString(),
                               descripcion = x.Description,
                               altura = x.Height.ToString(),
                               peso = x.Weight.ToString(),
                               Motivo = x.Reason.ToString(),
                               Diagnostico = x.Diagnosis,
                               Temperatura = x.temperature.ToString()
                           }).ToList();
            dgvMedicHistory.DataSource = History;
            dgvMedicHistory.Columns[0].HeaderText = "CODIGO";
            dgvMedicHistory.Columns[1].HeaderText = "DESCRIPCIONT";
            dgvMedicHistory.Columns[2].HeaderText = "ALTURA";
            dgvMedicHistory.Columns[3].HeaderText = "PESO";
            dgvMedicHistory.Columns[4].HeaderText = "MOTIVO";
            dgvMedicHistory.Columns[5].HeaderText = "DIAGNOSTICO";
            dgvMedicHistory.Columns[6].HeaderText = "TEMPERATURA";
        }

        
        private void Frm_MedicHistory_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_HospitalVSFundamentalsDataSet2.MedicHistory' Puede moverla o quitarla según sea necesario.
            //this.medicHistoryTableAdapter.Fill(this.bD_HospitalVSFundamentalsDataSet2.MedicHistory);
            updateDGVMedicHistory();
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCreate = new Frm_CreateMedicHistory();
            frmCreate.patmed.Id = patIdGuid.ToString();
            frmCreate.frmmFather = this;
            frmCreate.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicHistory.RowCount>0)
                {
                    MedicHistoryViewModel medHis = new MedicHistoryViewModel();
                    medHis.Id = dgvMedicHistory.CurrentRow.Cells[0].Value.ToString();
                    medHis.descripcion = dgvMedicHistory.CurrentRow.Cells[1].Value.ToString();
                    medHis.altura = dgvMedicHistory.CurrentRow.Cells[2].Value.ToString();
                    medHis.peso = dgvMedicHistory.CurrentRow.Cells[3].Value.ToString();
                    medHis.Motivo = dgvMedicHistory.CurrentRow.Cells[4].Value.ToString();
                    medHis.Diagnostico = dgvMedicHistory.CurrentRow.Cells[5].Value.ToString();
                    medHis.Temperatura = dgvMedicHistory.CurrentRow.Cells[6].Value.ToString();
                    medHis.IdPatiend = patmed.Id.ToString();
                    Frm_DetailMedicHistory1 frm_Detail = new Frm_DetailMedicHistory1();
                    frm_Detail.MedicHistoryViewModel = medHis;
                    frm_Detail.frmmFather = this;
                    frm_Detail.isEditable = false;
                    frm_Detail.ShowDialog();
                }
                else
                {   MessageBox.Show("No existe información");   }
            }
            catch (Exception ex)
            {   MessageBox.Show("Ocurrió un error en el Sistema. "+ex); }
        }

        private void reporteMedicHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmReporte = new FrmReporteMedicHIstoryFinal();
            // frmCreate.frmmFather = this;
            frmReporte.Show();
        }

        private void dataTable1BindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvMedicHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
       

        private void RegistroRecetaMedicaMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void registrarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicHistory.RowCount == 0)
                {
                    MessageBox.Show("No existen Datos para registrar la Receta.");
                    return;
                }
                else
                if(dgvMedicHistory.RowCount > 0)
                {   MedicHistoryViewModel medHisGuid = getViewModelfromRowData();
                    medHisGuid.Id = dgvMedicHistory.CurrentRow.Cells[0].Value.ToString();
                    Frm_MedicalRecipes frmMedRec = new Frm_MedicalRecipes();
                    frmMedRec.medHis.Id = medHisGuid.Id;
                    frmMedRec.patmed.Id = patmed.Id;
                    frmMedRec.docvm.Id = docuv.Id;
                    frmMedRec.frmFather = this;
                    frmMedRec.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Sistema. "+ex);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicHistory.RowCount>0)
                {
                    MedicHistoryViewModel medHis = new MedicHistoryViewModel();
                    medHis.Id = dgvMedicHistory.CurrentRow.Cells[0].Value.ToString();
                    medHis.descripcion = dgvMedicHistory.CurrentRow.Cells[1].Value.ToString();
                    medHis.altura = dgvMedicHistory.CurrentRow.Cells[2].Value.ToString();
                    medHis.peso = dgvMedicHistory.CurrentRow.Cells[3].Value.ToString();
                    medHis.Motivo = dgvMedicHistory.CurrentRow.Cells[4].Value.ToString();
                    medHis.Diagnostico = dgvMedicHistory.CurrentRow.Cells[5].Value.ToString();
                    medHis.Temperatura = dgvMedicHistory.CurrentRow.Cells[6].Value.ToString();
                    medHis.IdPatiend = patmed.Id.ToString();
                    Frm_DetailMedicHistory1 frm_Detail = new Frm_DetailMedicHistory1();
                    frm_Detail.MedicHistoryViewModel = medHis;
                    frm_Detail.frmmFather = this;
                    frm_Detail.isEditable = true;
                    frm_Detail.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existe información");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Sistema. "+ex);
            }
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvMedicHistory.RowCount == 0)
                {
                    MessageBox.Show("No existen datos para borrar.");
                    return;
                }
                else
                if (dgvMedicHistory.RowCount > 0)
                { 
                    MedicHistoryViewModel medicHistory = new MedicHistoryViewModel();
                    medicHistory.Id = dgvMedicHistory.CurrentRow.Cells[0].Value.ToString();
                    medHisGuid = Guid.Parse(medicHistory.Id);
                    DialogResult result = MessageBox.Show(
                    "Seguro de eliminar este registro",
                    "Alerta!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(medHisGuid.ToString());
                        var medHis = context.MedicHistory
                            .Where(x => x.MedicHistoryId.Equals(medHisGuid))
                            .SingleOrDefault();
                        context.MedicHistory.Remove(medHis);
                        context.SaveChanges();
                        updateDGVMedicHistory();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema con el Sistema. "+ ex);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private MedicHistoryViewModel getViewModelfromRowData()
        {
            MedicHistoryViewModel medHis = new MedicHistoryViewModel();
            foreach (DataGridViewRow dataRow in dgvMedicHistory.SelectedRows)
            {
                medHis = DataRowViewToViewModel.convertMedicHistoryViewModel(dataRow);
            }
            return medHis;
        }
        private void registrarRecetaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

    }
}
