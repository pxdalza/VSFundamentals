using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalVSFundamentals.UI.MVC.Models;
using HospitalVSFundamentals.UI.MVC.ViewModel;

namespace HospitalVSFundamentals.UI.MVC.Controllers
{
    //[Authorize(Roles ="ADM")]
    public class BloodTypesController : Controller
    {
        private BD_HospitalVSFundamentalsEntities db = new BD_HospitalVSFundamentalsEntities();

        //[HttpPost] esta etiqueta se usa para indicar que una accion es create o update y recivira data en el request
        //[HttpGet] esta etiqueta se usa para indicar que la accion solo te muestra informacion (para mvc es opcional ponerlo)
        //[HttpPut] esta etiqueta se usa para indicar que la accion solo sera un update y recivira data en el request
        //[HttpDelete] esta etiqueta se usa para indicar que la accion  solo sera un delete

        // GET: BloodTypes
        public ActionResult Index()
        {
            var blooftypes = db.BloodType.Select(x => new BloodTypeViewModel {
            BloodTypeId = x.BloodTypeId,
            Name = x.Name
            }).ToList();
            return View(blooftypes);
        }

        // GET: BloodTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodType bloodType = db.BloodType.Find(id);
            if (bloodType == null)
            {
                return HttpNotFound();
            }
            return View(bloodType);
        }

        // GET: BloodTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BloodTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                db.BloodType.Add(new BloodType {
                    Name = model.Name
                });
                db.SaveChanges();

                //return RedirectToRoute("/Home/Index");
                //return JsonResult();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: BloodTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodType bloodType = db.BloodType.Find(id);
            if (bloodType == null)
            {
                return HttpNotFound();
            }
            return View(bloodType);
        }

        // POST: BloodTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BloodTypeId,Name")] BloodType bloodType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloodType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloodType);
        }

        // GET: BloodTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodType bloodType = db.BloodType.Find(id);
            if (bloodType == null)
            {
                return HttpNotFound();
            }
            return View(bloodType);
        }

        // POST: BloodTypes/Delete/5
        //ActionName("Delete")  -> le cambia el nombre de tu funcion de manera logica para el ruteo
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloodType bloodType = db.BloodType.Find(id);
            db.BloodType.Remove(bloodType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
