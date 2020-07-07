using HospitalVSFundamentals.UI.Forms.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Helpers
{
    public static class DataRowViewToViewModel
    {

        public static UserViewModel convertUserViewModel(DataGridViewRow dr)
        {
            return new UserViewModel
            {
                Id = dr.Cells[0].Value.ToString(),
                Nombre_Usuario = dr.Cells[1].Value.ToString(),
                Nombre = dr.Cells[2].Value.ToString(),
                Apellido = dr.Cells[3].Value.ToString(),
                Correo_electronico = dr.Cells[4].Value.ToString(),
                Telefono = dr.Cells[5].Value.ToString(),
                DNI = dr.Cells[6].Value.ToString(),
                Fecha_Nacimiento = dr.Cells[7].Value.ToString(),
                Estado = dr.Cells[8].Value.ToString(),
                Genero = dr.Cells[9].Value.ToString()
            };

        }

        public static SpecialityViewModel  convertSpecialityViewModel(DataGridViewRow dr)
        {
            return new SpecialityViewModel
            {
                Id = Convert.ToInt32(dr.Cells[0].Value.ToString()),
                Nombre = dr.Cells[1].Value.ToString(),
                NombreCorto = dr.Cells[2].Value.ToString()

            };
        }
        public static MedicHistoryViewModel convertMedicHistoryViewModel(DataGridViewRow dr)
        {
            return new MedicHistoryViewModel
            {
                Id = dr.Cells[0].Value.ToString(),
                descripcion = dr.Cells[1].Value.ToString(),
                altura =    Convert.ToString(dr.Cells[2].Value).ToString(),
                peso = Convert.ToString(dr.Cells[3].Value).ToString(),
                Motivo = dr.Cells[4].Value.ToString(),
                Diagnostico = dr.Cells[5].Value.ToString(),
                Temperatura = Convert.ToString(dr.Cells[6].Value).ToString(),
                IdPatiend = dr.Cells[7].Value.ToString(),
                IdRecipe = dr.Cells[8].Value.ToString()
            };
        }
        public static Recipe_DetailsModel convertRecipeDetailsModel(DataGridViewRow dr)
        {
            return new Recipe_DetailsModel
            {
                RecipeId = dr.Cells[0].Value.ToString(),
                RecipeDetailId = Convert.ToInt32(dr.Cells[1].Value.ToString()),
                Medicine = dr.Cells[2].Value.ToString(),
                Description = dr.Cells[3].Value.ToString(),
                Quantity = Convert.ToDecimal(dr.Cells[4].Value.ToString())
            };
        }

        public static reportDetalleMedicRecipe convertReportRecipeDetailsViewModel(DataGridViewRow dr)
        {
            return new reportDetalleMedicRecipe
            {
                RecipeDetailId = Convert.ToInt32(dr.Cells[0].Value.ToString()),
                Medicine = dr.Cells[1].Value.ToString(),
                Description = dr.Cells[2].Value.ToString(),
                Quantity = Convert.ToDecimal(dr.Cells[3].Value.ToString())
            };
        }
        public static PatientShowViewModel convertPatientShowViewModel(DataGridViewRow dr)
        {
            return new PatientShowViewModel
            {
                Nombre      = dr.Cells[0].Value.ToString(),
                Apellido    = dr.Cells[1].Value.ToString(),
                DNI         = dr.Cells[2].Value.ToString(),
                Telefono    = dr.Cells[3].Value.ToString(),
                Genero      = dr.Cells[4].Value.ToString(),
                Id          = dr.Cells[5].Value.ToString()
            };
        }

    }
}
