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
    public class OoredoesController : ApiController
    {
        private WebApplication3Context db = new WebApplication3Context();

        // GET: api/Ooredoes
        public IQueryable<Ooredo> GetOoredoes()
        {
            return db.Ooredoes;
        }

        // GET: api/Ooredoes/5
        [ResponseType(typeof(Ooredo))]
        public IHttpActionResult GetOoredo(int id)
        {
            Ooredo ooredo = db.Ooredoes.Find(id);
            if (ooredo == null)
            {
                return NotFound();
            }

            return Ok(ooredo);
        }

        // PUT: api/Ooredoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOoredo(int id, Ooredo ooredo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ooredo.Id)
            {
                return BadRequest();
            }

            db.Entry(ooredo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OoredoExists(id))
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

        // POST: api/Ooredoes
        [ResponseType(typeof(Ooredo))]
        public IHttpActionResult PostOoredo(Ooredo ooredo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ooredoes.Add(ooredo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ooredo.Id }, ooredo);
        }

        // DELETE: api/Ooredoes/5
        [ResponseType(typeof(Ooredo))]
        public IHttpActionResult DeleteOoredo(int id)
        {
            Ooredo ooredo = db.Ooredoes.Find(id);
            if (ooredo == null)
            {
                return NotFound();
            }

            db.Ooredoes.Remove(ooredo);
            db.SaveChanges();

            return Ok(ooredo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OoredoExists(int id)
        {
            return db.Ooredoes.Count(e => e.Id == id) > 0;
        }
    }
}