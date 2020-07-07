using HospitalVSFundamentals.UI.Forms.Data;
using HospitalVSFundamentals.UI.Forms.Forms_MedicHistory;
using HospitalVSFundamentals.UI.Forms.Helpers;
using HospitalVSFundamentals.UI.Forms.ViewModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes
{
    public partial class Frm_MedicalRecipes : Form
    {

        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        public Guid guid = Guid.NewGuid();
        public String modo ="";
        public Recipe_DetailsModel recipess = new Recipe_DetailsModel();
        public Frm_MedicHistory frmFather = new Frm_MedicHistory();
        public MedicHistoryViewModel medHis = new MedicHistoryViewModel();
        public UserViewModel docvm = new UserViewModel();
        public Guid medHisGuid, docPatId, docUserId, patPatId;
        public DoctorViewModel doc = new DoctorViewModel();
        public PatientShowViewModel patmed = new PatientShowViewModel();

        public Frm_MedicalRecipes()
        {
            InitializeComponent();
        }

        public void updateDGVMedicalsRecipes()
        {
            var recipes = (from recipedet in context.Recipe_Details
                           where recipedet.RecipeId == guid select recipedet
                           ).Select(x => new Recipe_DetailsModel
            {
                RecipeId = x.RecipeId.ToString(),
                RecipeDetailId = x.RecipeDetailId,
                Medicine = x.Medicine,
                Description = x.Description,
                Quantity = x.Quantity.Value
            } ).ToList();
            DGVMedicalsRecipes.DataSource = recipes;
            DGVMedicalsRecipes.Columns[0].HeaderText = "N° Receta";
            DGVMedicalsRecipes.Columns[1].HeaderText = "ITEM";
            DGVMedicalsRecipes.Columns[2].HeaderText = "MEDICAMENTO";
            DGVMedicalsRecipes.Columns[3].HeaderText = "DESCRIPCION";
            DGVMedicalsRecipes.Columns[4].HeaderText = "CANTIDAD";
        }
        public Boolean CreateRecipe()
        {   bool rechead;
            modo = "Nuevo";
            DialogResult resul = MessageBox.Show("¿Desea Agregar receta médica?", "Alerta!",MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {   try
                {   var recipes = context.Recipes.Add(  new Recipes{   RecipeId = guid, Date_creation = Convert.ToDateTime(dtp_fecha.Text)  }   );
                    context.SaveChanges();
                    rechead = true;
                }
                catch (Exception ex)
                {   MessageBox.Show("Ocurrió un problema. "+ex);  rechead = false; }
            }
            else
            {   rechead = false;    }
            return rechead;
        }
        public Boolean CreateMedicalHistoryPatient()
        {   bool medHisPat;
            try
            {   
                /*Obtiene elcódigo del Doctor*/
                docUserId = Guid.Parse(docvm.Id);
                var patient = (from DocPat in context.Patients
                               where DocPat.UserId == docUserId select DocPat
                               ).Select(x => new DoctorViewModel
                               {
                                   PatientId = x.PacienteId.ToString()
                               }).ToList();
                foreach (var item in patient)
                {   docPatId = Guid.Parse(item.PatientId);  }

                /*Obtiene el código de Paciente*/
                patPatId = Guid.Parse(patmed.Id);
                var patientPat = (from patPat in context.Patients
                               where patPat.UserId == patPatId
                                  select patPat
                               ).Select(x => new PatientShowViewModel
                               {
                                   Id = x.PacienteId.ToString()
                               }).ToList();
                foreach (var item in patientPat)
                { patPatId = Guid.Parse(item.Id); }

                MessageBox.Show(docPatId.ToString()+" - "+ patPatId.ToString());

                medHisGuid = Guid.Parse(medHis.Id);
                var medHisPatiDoc = context.MedicHistory_Patient.Add(
                    new MedicHistory_Patient
                    {
                        PatientId= docPatId,
                        MedicHistoryId = medHisGuid
                    });
                context.SaveChanges();

                var medHisPatiPat = context.MedicHistory_Patient.Add(
                    new MedicHistory_Patient
                    {
                        PatientId = patPatId,
                        MedicHistoryId = medHisGuid
                    });
                context.SaveChanges();

                medHisPat = true;
             }
            catch (Exception ex)
            {   MessageBox.Show("Ocurrió un error en el sistema. "+ ex);
                medHisPat = false;   }
            return medHisPat;
        }

        private void Frm_MedicalRecipes_Load(object sender, EventArgs e)
        {
            CreateMedicalHistoryPatient();

            imprimirToolStripMenuItem.Enabled = false;
            if (CreateRecipe())
            {
                updateDGVMedicalsRecipes();
            }
            else
            {
                this.Close();
                return;
            }
        }

        private void validaData()
        {
                if (txtMedicine.Text == "" || txtMedicine.Text is null || txtMedicine.Text.Length <= 0)
                {
                    MessageBox.Show("Ingrese el Medicamento a Recetar");
                    txtMedicine.Focus();
                    return;
                }
                if (rtbDescription.Text == "" || rtbDescription.Text is null || rtbDescription.Text.Length <= 0)
                {
                    MessageBox.Show("Ingrese la descripción de la Receta");
                    rtbDescription.Focus();
                    return;
                }
                if (txtQuantity.Text == "" || txtQuantity.Text is null || txtQuantity.Text.Length <= 0)
                {
                    MessageBox.Show("Ingrese la Cantidad del Medicamento");
                    txtQuantity.Focus();
                    return;
                }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtMedicine.Text == "" || rtbDescription.Text == "" || txtQuantity.Text == "")
            {   validaData();  }
            else
            if (modo == "Nuevo")
            {
                try
                {
                    var recipesdet = context.Recipe_Details.Add(
                                            new Recipe_Details
                                            {
                                                RecipeId = guid,
                                                Medicine = txtMedicine.Text,
                                                Description = rtbDescription.Text,
                                                Quantity = Convert.ToDecimal(txtQuantity.Text)
                                            });
                    txtMedicine.Text = "";
                    rtbDescription.Text = "";
                    txtQuantity.Text = "";
                    context.SaveChanges();
                    updateDGVMedicalsRecipes();
                    MessageBox.Show("Registro Grabado Satisfactoriamente. ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en el Sistema. " + ex);
                }
            }
            if (modo == "Editar")
            {
                try
                {
                    var recipes = context.Recipe_Details
                        .Where(x => x.RecipeDetailId.Equals(recipess.RecipeDetailId))
                        .SingleOrDefault();
                    if (recipes != null)
                    {
                        recipes.Medicine = txtMedicine.Text;
                        recipes.Description = rtbDescription.Text;
                        recipes.Quantity = Convert.ToDecimal(txtQuantity.Text);
                        context.SaveChanges();
                        MessageBox.Show("Registro Grabado Satisfactoriamente. ");
                    }
                    updateDGVMedicalsRecipes();
                }
                catch (Exception ex)
                {   MessageBox.Show("Ocurrió un error en el Sistema. " + ex);   }
                txtMedicine.Enabled = false;
                rtbDescription.Enabled = false;
                txtQuantity.Enabled = false;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DGVMedicalsRecipes.RowCount ==0)
            {
                MessageBox.Show("No existen datos para actualizar.");
                return;
            }
            else if (DGVMedicalsRecipes.RowCount > 0)
            {
                modo = "Editar";
                txtMedicine.Enabled = true;
                rtbDescription.Enabled = true;
                txtQuantity.Enabled = true;
                txtMedicine.Focus();
            }
        }
        private void DGVMedicalsRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                recipess.RecipeDetailId  = int.Parse(DGVMedicalsRecipes.CurrentRow.Cells[1].Value.ToString());
                txtMedicine.Text        = DGVMedicalsRecipes.CurrentRow.Cells[2].Value.ToString();
                rtbDescription.Text     = DGVMedicalsRecipes.CurrentRow.Cells[3].Value.ToString();
                txtQuantity.Text        = DGVMedicalsRecipes.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. "+ex);
            }
            txtMedicine.Enabled = false;
            rtbDescription.Enabled = false;
            txtQuantity.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtMedicine.Text = "";
            rtbDescription.Text = "";
            txtQuantity.Text = "";
            modo = "Nuevo";
            txtMedicine.Enabled = true;
            rtbDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtMedicine.Focus();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVMedicalsRecipes.RowCount == 0)
                {
                    MessageBox.Show("No existen datos para Eliminar.");
                    return;
                }
                else
                if (DGVMedicalsRecipes.RowCount > 0)
                {   Recipe_DetailsModel recipes = getViewModelfromRowData();
                    recipes.RecipeDetailId      = int.Parse(DGVMedicalsRecipes.CurrentRow.Cells[1].Value.ToString());
                    DialogResult result = MessageBox.Show(
                        "¿Estas seguro que desea eliminar este registro?",
                        "¡Alerta!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var recipesElimina = context.Recipe_Details
                            .Where(x => x.RecipeDetailId.Equals(recipes.RecipeDetailId))
                            .SingleOrDefault();
                        context.Recipe_Details.Remove(recipesElimina);
                        context.SaveChanges();
                        updateDGVMedicalsRecipes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Sistema. "+ ex);
            }
        }
        private Recipe_DetailsModel getViewModelfromRowData()
        {
            Recipe_DetailsModel recipes = new Recipe_DetailsModel();
            foreach(DataGridViewRow dataRow in DGVMedicalsRecipes.SelectedRows)
            {
                recipes = DataRowViewToViewModel.convertRecipeDetailsModel(dataRow);
            }
            return recipes;
        }
        private void DGVMedicalsRecipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void imprimirRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recipess = new Recipe_DetailsModel();
            Frm_ReportRecipe frm_Report = new Frm_ReportRecipe();
            frm_Report.medrec.RecipeId = guid.ToString();
            frm_Report.frmmFather = this;
            frm_Report.ShowDialog();
        }
        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtMedicine_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                rtbDescription.Focus();
            }
        }
        private void btnGrabarData_Click(object sender, EventArgs e)
        {
            try
            {   //Codigo de MedicHistory
                medHisGuid = Guid.Parse(medHis.Id);

                var umedHis = context.MedicHistory
                              .Where(x => x.MedicHistoryId.Equals(medHisGuid))
                              .SingleOrDefault();
                if (umedHis != null)
                {
                    umedHis.RecipeId = guid;
                    context.SaveChanges();
                    MessageBox.Show("Receta Asignada al historial de paciente en curso.");
                    frmFather.updateDGVMedicHistory();
                    imprimirToolStripMenuItem.Enabled = true;
                    btngrabar.Enabled = false;
                    button1.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error en el Sistema.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Sistema. "+ex);
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
