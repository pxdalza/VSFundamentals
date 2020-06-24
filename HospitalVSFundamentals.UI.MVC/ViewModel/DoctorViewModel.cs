using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalVSFundamentals.UI.MVC.ViewModel
{
    public class DoctorViewModel
    {
            public String Id { get; set; }

            public string Nombre_Usuario { get; set; }

            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public string Correo_electronico { get; set; }

            public string Telefono { get; set; }

            //[Required]
            [Display(Name ="Documento de identidad")]
            //[StringLength(12, MinimumLength = 8, ErrorMessage ="El documento ingresado no es valido")]
            public string DNI { get; set; }
            
            public string CMP { get; set; }

            [Display(Name ="Fecha de cumpleanios")]
            public String Fecha_Nacimiento { get; set; }

            public string Estado { get; set; }

            public string Genero { get; set; }

            public String Epecialidad { get; set; }
    }
}