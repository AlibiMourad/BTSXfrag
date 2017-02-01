using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BTSxfrag.Mode;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TunisieTelecomsController : ApiController
    {
        private WebApplication1Context db = new WebApplication1Context();

        // GET: api/TunisieTelecoms
        public IQueryable<TunisieTelecom> GetTunisieTelecoms()
        {
            return db.TunisieTelecoms;
        }

        // GET: api/TunisieTelecoms/5
        [ResponseType(typeof(TunisieTelecom))]
        public IHttpActionResult GetTunisieTelecom(int id)
        {
            TunisieTelecom tunisieTelecom = db.TunisieTelecoms.Find(id);
            if (tunisieTelecom == null)
            {
                return NotFound();
            }

            return Ok(tunisieTelecom);
        }

        // PUT: api/TunisieTelecoms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTunisieTelecom(int id, TunisieTelecom tunisieTelecom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tunisieTelecom.Id)
            {
                return BadRequest();
            }

            db.Entry(tunisieTelecom).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TunisieTelecomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TunisieTelecoms
        [ResponseType(typeof(TunisieTelecom))]
        public IHttpActionResult PostTunisieTelecom(TunisieTelecom tunisieTelecom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TunisieTelecoms.Add(tunisieTelecom);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tunisieTelecom.Id }, tunisieTelecom);
        }

        // DELETE: api/TunisieTelecoms/5
        [ResponseType(typeof(TunisieTelecom))]
        public IHttpActionResult DeleteTunisieTelecom(int id)
        {
            TunisieTelecom tunisieTelecom = db.TunisieTelecoms.Find(id);
            if (tunisieTelecom == null)
            {
                return NotFound();
            }

            db.TunisieTelecoms.Remove(tunisieTelecom);
            db.SaveChanges();

            return Ok(tunisieTelecom);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TunisieTelecomExists(int id)
        {
            return db.TunisieTelecoms.Count(e => e.Id == id) > 0;
        }
    }
}