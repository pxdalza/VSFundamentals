using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalVSFundamentals.UI.Forms.ViewModel
{
    public class MedicHistoryViewModel
    {
        public String Id { get; set; }
        public String descripcion { get; set; }
        public String altura { get; set; }
        public String peso  { get; set; }
        public String Motivo { get; set; }
        public String Diagnostico { get; set; }
        public String Temperatura { get; set; }
        public String IdPatiend { get; set; }
        public String IdRecipe { get; set; }

    }
    public class PatientShowViewModel
    {
        public String Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
    }

    public class DoctorViewModel
    {
        public int MedicHistory_Patient { get; set; }
        public String PatientId { get; set; }
        public String MedicHistoryId { get; set; }
    }
}
