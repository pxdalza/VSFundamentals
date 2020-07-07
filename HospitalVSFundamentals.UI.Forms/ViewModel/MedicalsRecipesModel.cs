using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalVSFundamentals.UI.Forms.ViewModel
{
    public class MedicalsRecipesModel
    {
        public String RecipeId { get; set; }
        public DateTime Date_Creation { get; set; }
    }

    public class Recipe_DetailsModel
    {
        public String RecipeId { get; set; }
        public int RecipeDetailId { get; set; }
        public String Medicine { get; set; }
        public String Description { get; set; }
        public Decimal Quantity { get; set; }

    }

    public class reportDetalleMedicRecipe
    {
        public int RecipeDetailId { get; set; }
        public String Medicine { get; set; }
        public String Description { get; set; }
        public Decimal Quantity { get; set; }
    }

    public class reportHeadMedicRecipe
    {
        public String RecipeId { get; set; }
        public DateTime Date_Creation { get; set; }
    }

    public class reportPatientMedicRecipe
    {
        public String Paciente { get; set; }
        public String DNI { get; set; }
        public String Genero { get; set; }
        public String Telefono { get; set; }
        public String Tipo { get; set; }
        public String TipoSangre { get; set; }
        public String Historia { get; set; }
        public Decimal Talla { get; set; }
        public Decimal Peso { get; set; }
        public String Doctor { get; set; }
    }

}

