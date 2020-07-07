using HospitalVSFundamentals.UI.Forms.Data;
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
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Data.Entity;
using Microsoft.Reporting.WinForms;

namespace HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes
{
    public partial class Frm_ReportRecipe : Form
    {
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        public Frm_MedicalRecipes frmmFather = new Frm_MedicalRecipes();
        public MedicalsRecipesModel medrec = new MedicalsRecipesModel();
        public Recipe_DetailsModel recipes = new Recipe_DetailsModel();

        public Guid guid;
        public Frm_ReportRecipe()
        {
            InitializeComponent();
            //this.Load += Frm_ReportRecipe_Load;
        }

        private void Frm_ReportRecipe_Load(object sender, EventArgs e)
        {
            guid = Guid.Parse(medrec.RecipeId);
            var recipehead = (from cab in context.Recipes
                              where cab.RecipeId == guid
                              select cab).Select(x => new reportHeadMedicRecipe
                              {   RecipeId = x.RecipeId.ToString(),
                                  Date_Creation = x.Date_creation.Value
                              });
            ReportDataSource rdshead = new ReportDataSource();
            rdshead.Name = "DSRecipeHead";
            rdshead.Value = recipehead;

            var recipes = (from recipedet in context.Recipe_Details
                           where recipedet.RecipeId == guid
                           select recipedet).Select(x => new reportDetalleMedicRecipe
                           {   RecipeDetailId = x.RecipeDetailId,
                               Medicine = x.Medicine,
                               Description = x.Description,
                               Quantity = x.Quantity.Value
                           });
            ReportDataSource rdsdet = new ReportDataSource();
            rdsdet.Name = "DSRecipeDetails";
            rdsdet.Value = recipes;

            var patience = (from medHis in context.MedicHistory
                            join pat in context.Patients on medHis.PatiendId equals pat.PacienteId
                            join bt in context.BloodType on pat.BloodType equals bt.BloodTypeId
                            join user in context.Users on pat.UserId equals user.IdUser
                            join Rol in context.Roles on user.User_Role equals Rol.User_Role_Id
                            join rec in context.Recipes on medHis.RecipeId equals rec.RecipeId
                            where rec.RecipeId == guid &&
                            user.User_Role == 3 || user.User_Role == 4

                            from udoc in context.Users
                            join pdoc in context.Patients on udoc.IdUser equals pdoc.UserId
                            join mhpdoc in context.MedicHistory_Patient on pdoc.PacienteId equals mhpdoc.PatientId
                            join mhdoc in context.MedicHistory on mhpdoc.MedicHistoryId equals mhdoc.MedicHistoryId
                            where mhdoc.RecipeId == guid &&
                            udoc.User_Role == 2

                            select new reportPatientMedicRecipe
                            {   Paciente =   user.LastName + ", " + user.Name,
                                DNI = user.DNI,
                                Genero = (user.Gener == "M") ? "Masculino" : "Femenino",
                                Telefono = user.PhoneNumber.ToString(),
                                Tipo = Rol.Name,
                                TipoSangre = bt.Name,
                                Historia = medHis.Description,
                                Talla = medHis.Height.Value,
                                Peso = medHis.Weight.Value,
                                Doctor = udoc.LastName + ", " + udoc.Name
                            });
            ReportDataSource rdspat = new ReportDataSource();
            rdspat.Name = "DSPatient";
            rdspat.Value = patience;

            /*Carga de Data Sources en el ReportViewer*/
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdshead);
            reportViewer1.LocalReport.DataSources.Add(rdsdet);
            reportViewer1.LocalReport.DataSources.Add(rdspat);
            reportViewer1.LocalReport.ReportPath = "D:/VSFundamentals/HospitalVSFundamentals.UI.Forms/Forms_Medicals_Recipes/InformeDetails.rdlc";
            reportViewer1.RefreshReport();
        }

        private void Recipe_DetailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void RecipesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
