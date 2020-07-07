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

namespace HospitalVSFundamentals.UI.Forms.Forms_Specialities
{
    public partial class Frm_Speciality : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();

        public Frm_Speciality()
        {
            InitializeComponent();
        }

        public void updateDGVEspecialidades()
        {
            // List<Speciality>  -> dgvEspecialidades.DataSource = context.Speciality.ToList();  = Select * from Speciality
            // List<SpecialityViewModel>
            var specilities = context.Speciality
                                           .Select(x => new SpecialityViewModel
                                           {
                                               Id = x.SpecialityId,
                                               Nombre = x.Name,
                                               NombreCorto = x.ShortName
                                           }).ToList();

            dgvEspecialidades.DataSource = specilities;

            dgvEspecialidades.Columns[2].HeaderText = "Nombre Corto";

        }

        private void Frm_Speciality_Load(object sender, EventArgs e)
        {
            updateDGVEspecialidades();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscar.Text.Length > 0)
            {
                dgvEspecialidades.DataSource = context.Speciality
                                           .Where(x => x.Name.Contains(txtBuscar.Text))
                                           .Select(x => new SpecialityViewModel
                                           {
                                               Id = x.SpecialityId,
                                               Nombre = x.Name,
                                               NombreCorto = x.ShortName
                                           }).ToList();
            }
            else
            {
                updateDGVEspecialidades();
            }

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frmCreate = new FrmCreateSpeciality();
            frmCreate.frmmFather = this;
            frmCreate.Show();

        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialityViewModel speciality = new SpecialityViewModel();
            foreach (DataGridViewRow dataRow in dgvEspecialidades.SelectedRows)
            {
                speciality = DataRowViewToViewModel.convertSpecialityViewModel(dataRow);
            }

            Frm_DetailSpeciality frm_Details = new Frm_DetailSpeciality();
            frm_Details.specialityViewModel = speciality;
            frm_Details.frmmFather = this;
            frm_Details.isEditable = false;
            frm_Details.Show();

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialityViewModel speciality = getViewModelfromRowData();

            Frm_DetailSpeciality frm_Details = new Frm_DetailSpeciality();
            frm_Details.specialityViewModel = speciality;
            frm_Details.frmmFather = this;
            frm_Details.isEditable = true;
            frm_Details.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SpecialityViewModel speciality = getViewModelfromRowData();

            try
            {

                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea eliminar este elemento",
                    "Alerta!",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    var especialidad = context.Speciality
                        .Where(x => x.SpecialityId.Equals(speciality.Id))
                        .SingleOrDefault();

                    context.Speciality.Remove(especialidad);
                    context.SaveChanges();

                    updateDGVEspecialidades();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema");
            }

        }

        private SpecialityViewModel getViewModelfromRowData()
        {
            SpecialityViewModel speciality = new SpecialityViewModel();
            foreach (DataGridViewRow dataRow in dgvEspecialidades.SelectedRows)
            {
                speciality = DataRowViewToViewModel.convertSpecialityViewModel(dataRow);
            }

            return speciality;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
