using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalVSFundamentals.UI.MVC.ViewModel
{
    public class BloodTypeViewModel
    {
        public int BloodTypeId { get; set; }

        [Required(ErrorMessage ="Este campo es requerido por favor ingresar un valor")]
        [Display(Name = "Nombre")]
        [StringLength(250,MinimumLength = 10, ErrorMessage ="Ingrese un nombre valido")]
        public string Name { get; set; }

    }
}