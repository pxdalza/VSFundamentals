using HospitalVSFundamentals.UI.API.Models;
using HospitalVSFundamentals.UI.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace HospitalVSFundamentals.UI.API.Controllers
{
    [RoutePrefix("api/bloodtype")]
    public class BloodTypeController : ApiController
    {
        private BD_HospitalVSFundamentalsEntities db = new BD_HospitalVSFundamentalsEntities();

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(List<BloodTypeViewModel>))]
        public IHttpActionResult get() {
            try
            {
                var bloodtypes = db.BloodType.Select(x => new BloodTypeViewModel {
                    BloodTypeId = x.BloodTypeId,
                    Name = x.Name
                }).ToList();

                return Ok(bloodtypes);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        [ResponseType(typeof(bool))]
        public IHttpActionResult createBlood(BloodTypeViewModel model)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    db.BloodType.Add(new BloodType { Name = model.Name });
                    db.SaveChanges();

                    return Ok(true);

                }
                else {
                    return Ok("campo nombre requerido");
                }


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getById")]
        [ResponseType(typeof(BloodTypeViewModel))]
        public IHttpActionResult get(int id)
        {
            try
            {
                var dat = DateTime.UtcNow;
                var date = DateTime.Now.ToString("dd-MM-yyyy");

                var bloodtypes = db.BloodType.Where(x=>x.BloodTypeId.Equals(id)).Select(x => new BloodTypeViewModel
                {
                    BloodTypeId = x.BloodTypeId,
                    Name = x.Name
                }).ToList();

                return Ok(bloodtypes);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        [ResponseType(typeof(bool))]
        public IHttpActionResult updateBlood(BloodTypeViewModel model)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    var blood = db.BloodType.Where(x => x.BloodTypeId.Equals(model.BloodTypeId)).SingleOrDefault();
                    blood.Name = model.Name;
                    db.SaveChanges();

                    return Ok(true);

                }
                else
                {
                    return Ok("campo nombre requerido");
                }


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("deleteById")]
        [ResponseType(typeof(bool))]
        public IHttpActionResult deletedBlood(int id)
        {
            try
            {
               

                var bloodtypes = db.BloodType.Where(x => x.BloodTypeId.Equals(id)).SingleOrDefault();

                db.BloodType.Remove(bloodtypes);
                db.SaveChanges();

                return Ok(true);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}