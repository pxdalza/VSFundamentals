using HospitalVSFundamentals.UI.MVC.Models;
using HospitalVSFundamentals.UI.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalVSFundamentals.UI.MVC.Controllers
{
    public class DoctorController : Controller
    {
        private BD_HospitalVSFundamentalsEntities db = new BD_HospitalVSFundamentalsEntities();

        // GET: Doctor
        public ActionResult Index()
        {

            var users = (from u in db.Users
                         join r in db.Roles on u.User_Role equals r.User_Role_Id
                         join d in db.Doctor on u.IdUser equals d.Userid
                         join e in db.Speciality on d.SpecialityId equals e.SpecialityId
                         where r.ShortName.Equals("DOC")
                         select new DoctorViewModel
                         {
                             Id = u.IdUser.ToString(),
                             Apellido = u.LastName,
                             CMP = d.CMP,
                             Correo_electronico = u.Email,
                             DNI = u.DNI,
                             Epecialidad = e.Name,
                             Estado = u.Status,
                             Fecha_Nacimiento = u.Birthday.ToString(),
                             Genero = u.Gener,
                             Nombre = u.Name,
                             Nombre_Usuario = u.username,
                             Telefono = u.PhoneNumber
                         }).ToList();

            return View(users);
        }
    }
}